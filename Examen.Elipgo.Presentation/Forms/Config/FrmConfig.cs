using Examen.Elipgo.BusinessLogic.Entities;
using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.Presentation.Configuration.Contexts;
using Examen.Elipgo.Presentation.Forms.Loader;
using Examen.Elipgo.Presentation.Forms.MessageBoxUI;
using Examen.Elipgo.Presentation.Tools;
using Examen.Elipgo.Presentation.Tools.Enums;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Forms.Config
{
    public partial class FrmConfig : Form
    {
        public bool isFirstInitial = true;
        public string MessageError = "";
        private IServiceConnect _serviceConnect;
        private MessageBoxForm form = null;
        
        public FrmConfig()
        {
            InitializeComponent();
        }

        #region LoadView

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            UtilityTools.CenterX(pnlTitulo, lblTitulo);
           ValidStartForm();
           lblNote.Text =
               "El formato de la URL no debe terminar con una diagonal para garantizar" + Environment.NewLine +
               " la funcionalidad de la aplicación ejemplo http://myservice.com";
        }

        #endregion

        #region EventButtons

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            if (!ValidForm()) return;

            var Loading = new LoaderForm();
            Loading.Show(this);

            _serviceConnect = new ServiceConnect(txtUri.Text);
            var response = await _serviceConnect.ConnectionTest();
            Loading.Close();
            if (response)
            {
                form = new MessageBoxForm(
                    "Servicio Disponible",
                    "La Aplicación esta conectada al servicio",
                    TypeIcon.Success);
                form.ShowDialog();
            }
            else
            {
                form = new MessageBoxForm(
                    "Servicio No Disponible",
                    "La Aplicación no esta conectada al servicio, favor de verificar direccion o que el servicio este disponible",
                    TypeIcon.Warning);
                form.ShowDialog();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidForm())
                SaveConfig();
        }

        #endregion

        #region FormEvents

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            btnTest.ForeColor = Color.Black;
        }

        private void btnTest_MouseEnter(object sender, EventArgs e)
        {
            btnTest.ForeColor = Color.White;
        }

        private void btnTest_MouseDown(object sender, MouseEventArgs e)
        {
            btnTest.ForeColor = Color.Black;
        }

        private void btnTest_MouseUp(object sender, MouseEventArgs e)
        {
            btnTest.ForeColor = Color.White;
        }

        #endregion

        #region PrivateMethods

        private void SaveConfig()
        {
            var str = txtUri.Text;
            var url = str.EndsWith("/") ? str.Remove(str.Length - 1) : str;

            using (var db = new ApplicationDbContext())
            {
                var app = db.ApplicationSettings.SingleOrDefault(x => x.Id == 1);
                app.UrlConnectionRestAPI = url;
                app.IsFirstExecution = false;

                db.Entry(app).State = EntityState.Modified;
                db.SaveChanges();

                var dialog = new MessageBoxForm(
                    "URl Servico",
                    "Se actualizado la direccion de conexion a servicio",
                    TypeIcon.Success);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (isFirstInitial)
                    {
                        var t = new Thread(new ThreadStart(ThreadProc));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void ValidStartForm()
        {
            using (var db = new ApplicationDbContext())
            {
                var app = db.ApplicationSettings.SingleOrDefault(x => x.Id == 1);
                if (!app.IsFirstExecution)
                {
                    lblTitulo.Text = "Actualizar Servicio";
                    txtUri.Text = app.UrlConnectionRestAPI;
                    btnAceptar.Text = "Actualizar";
                    btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
                    btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
                    this.Text = "Actualizacion URL";
                }

                if (!string.IsNullOrEmpty(MessageError))
                {
                    form = new MessageBoxForm(
                        "Direccion No Valida",
                        "La dirección base cambio o el servicio no está disponible favor de intentar más tarde o actualizar la dirección",
                        TypeIcon.Warning);
                    form.ShowDialog();
                }
            }
        }

        private static void ThreadProc()
        {
            Application.Run(new Login());
        }

        private bool ValidForm()
        {
            if (!string.IsNullOrEmpty(txtUri.Text))
            {
                if (!Uri.IsWellFormedUriString(txtUri.Text, UriKind.RelativeOrAbsolute) ||
                    txtUri.Text.Contains("local")) return true;
                
                form = new MessageBoxForm(
                    "Direccion No Valida",
                    "Debe Ingrear una dirección URL valida verificar conexion",
                    TypeIcon.Warning);
                form.ShowDialog();
                return false;
            }
            else
            {
                form = new MessageBoxForm(
                    "Campo Vacio",
                    "Debe Ingrear una dirección URL para verificar conexion",
                    TypeIcon.Warning);
                form.ShowDialog();
                return false;
            }
        }
        #endregion

    }
}
