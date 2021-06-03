using Examen.Elipgo.BusinessLogic.Entities;
using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.Presentation.Configuration.Contexts;
using Examen.Elipgo.Presentation.Configuration.DbEntities;
using Examen.Elipgo.Presentation.Forms.Loader;
using Examen.Elipgo.Presentation.Forms.MessageBoxUI;
using Examen.Elipgo.Presentation.Tools.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Forms
{
    public partial class Login : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly IAuthorizeRepository _authorizeRepository;
        private MessageBoxForm form = null;
        private bool isActiveSession = false;
        public Login()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _authorizeRepository = new AuthorizeRepository(_context.ApplicationSettings
                .Where(x => x.Id == 1)
                .Select(x => x.UrlConnectionRestAPI)
                .FirstOrDefault());
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            if(!ValidForm()) return;
            var user = new LoginDAO()
            {
                UserName = txtUser.Text,
                Password = txtPassword.Text
            };

            if (!isActiveSession)
            {
                var permission = new List<Permissions>();
               
                var loader = new LoaderForm();
                loader.Show(this);
                var response = await _authorizeRepository.Login(user);
                loader.Close();
                if (response.Success)
                {
                    response.Value.Permissions.ForEach(x =>
                    {
                        permission.Add(new Permissions()
                        {
                            Value = x.Value,
                            Type = x.Type
                        });
                    });

                    if (await _context.Users.AnyAsync(x => x.UserName.Equals(response.Value.UserName)))
                    {
                        var existUser =
                            await _context.Users
                                .Include(x => x.Permissions)
                                .FirstOrDefaultAsync(x => x.UserName.Equals(response.Value.UserName));

                        existUser.IsActiveSession = true;
                        existUser.Roles = string.Join(",", response.Value.RoleName);
                        existUser.Token = response.Value.Token;
                        existUser.LastAccess = DateTime.Now;
                        existUser.Permissions = permission;

                        _context.Users.AddOrUpdate(existUser);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        _context.Users.Add(new User()
                        {
                            IsActiveSession = true,
                            ExpirationToken = response.Value.Expiration,
                            LastAccess = DateTime.Now,
                            Token = response.Value.Token,
                            UserName = response.Value.UserName,
                            Email = response.Value.Email,
                            Roles = string.Join(",", response.Value.RoleName),
                            Permissions = permission,
                        });
                        await _context.SaveChangesAsync();
                    }


                    form = new MessageBoxForm(
                        "Inicio de sesión",
                        response.Message,
                        TypeIcon.Success);
                    form.ShowDialog();

                    var t = new Thread(new ThreadStart(ThreadProc));
                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();
                    this.Close();
                }
                else
                {
                    form = new MessageBoxForm(
                        "Inicio de sesión incorrecto",
                        response.Message_Error,
                        TypeIcon.Warning);
                    form.ShowDialog();
                }


            }
            else
            {
                var loader = new LoaderForm();
                loader.Show(this);
                var response = await _authorizeRepository.Login(user);
                loader.Close();
                if (response.Success)
                {
                    var userLocal = await _context.Users
                        .Include(x => x.Permissions)
                        .FirstOrDefaultAsync(x => x.IsActiveSession);
                    userLocal.IsActiveSession = false;
                    _context.Users.AddOrUpdate(userLocal);
                    _context.Permissions.RemoveRange(userLocal.Permissions);
                    await _context.SaveChangesAsync();

                    form = new MessageBoxForm(
                        "Sesión Cerrada",
                        "Ahora puede iniciar session con la nueva cuenta",
                        TypeIcon.Success);
                    form.ShowDialog();

                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                    lblTitleLogin.Text = "Control de Acceso";
                    btnLogin.Text = "Ingresar";
                    this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
                    this.btnLogin.FlatAppearance.BorderSize = 0;
                    isActiveSession = false;
                }
                else
                {
                    form = new MessageBoxForm(
                        "Inicio de sesión incorrecto",
                        response.Message_Error,
                        TypeIcon.Warning);
                    form.ShowDialog();
                }
            }

        }

        private bool ValidForm()
        {
            if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtUser.Text))
            {
                form = new MessageBoxForm(
                    "Error!",
                    "Debe ingresar un usuario y contraseña para ingresar",
                    TypeIcon.Warning);
                form.ShowDialog();
                txtUser.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                form = new MessageBoxForm(
                    "Error!",
                    "Debe ingresar un usuario para ingresar",
                    TypeIcon.Warning);
                form.ShowDialog();
                txtUser.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                form = new MessageBoxForm(
                    "Error!",
                    "Debe ingresar una contraseña para ingresar",
                    TypeIcon.Warning);
                form.ShowDialog();
                return false;
            }

            return true;
        }

        private void ThreadProc()
        {
            Application.Run(new MainForm());
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.IsActiveSession);
            if (user == null) return;
            lblTitleLogin.Text = "Sesión Activa";
            btnLogin.Text = "Cerrar Sesión";
            txtUser.Text = user.UserName;
            isActiveSession = true;
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
        }
    }
}
