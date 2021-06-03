using Examen.Elipgo.Presentation.Forms.Config;
using Examen.Elipgo.Presentation.Tools;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Examen.Elipgo.Presentation.Configuration.Contexts;

namespace Examen.Elipgo.Presentation.Forms
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        #region LoadView

        private async void MainForm_Load(object sender, EventArgs e)
        {
            UtilityTools.CenterX(pnlRole, lblRole);
            UtilityTools.CenterX(pnlHeader, lblDealName);
            MaximizeWindow();
            var user = await _context.Users.Where(x => x.IsActiveSession).FirstOrDefaultAsync();
            lblRole.Text = user.Roles;
            lblUser.Text = user.UserName;
            lblEmail.Text = user.Email;
            lblUserId.Text = $"Terminal: {user.Id.ToString().PadLeft(5, '0')}";
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UtilityTools.CenterX(pnlHeader, lblDealName);
        }

        #endregion

        #region AcctionButtons

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowForm("Products");
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            var idUser = Convert.ToInt32(lblUserId.Text.Split(':')[1].Trim());
            var user = await _context.Users
                .Include(x => x.Permissions)
                .Where(x => x.Id == idUser).FirstOrDefaultAsync();
            user.IsActiveSession = false;
            _context.Users.AddOrUpdate(user);
            _context.Permissions.RemoveRange(user.Permissions);
            await _context.SaveChangesAsync();
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowForm("Inventory");
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            ShowForm("Stores");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var formConfig = new FrmConfig();
            formConfig.isFirstInitial = false;
            formConfig.ShowDialog();
        }

        #endregion

        #region FormEvents

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            ResizableWindow();
        }

        #endregion

        #region PrivateMethods

        private void MaximizeWindow()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            var workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        }

        private void ResizableWindow()
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ShowForm(string nameForm)
        {
            var t = Type.GetType(typeof(MainForm).Namespace + ".Views." + nameForm);
            if (!(Activator.CreateInstance(t ?? throw new InvalidOperationException()) is Form newForm)) return;
            newForm.Owner = this;
            AddFormInPanel(newForm);
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);
            fh.Visible = false;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(fh);
            this.pnlContent.Tag = fh;
            fh.Show();
        }

        #endregion

    }
}
