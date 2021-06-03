using Examen.Elipgo.Presentation.Properties;
using Examen.Elipgo.Presentation.Tools.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Forms.MessageBoxUI
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm(string Title, string Message, TypeIcon TypeIcon, bool ShowButtonCancel = false)
        {
            InitializeComponent();
            lblTitle.Text = Title;
            txtMessage.Text = Message;

            switch (TypeIcon)
            {
                case TypeIcon.Success:
                    pbxIcon.Image = Resources.confirm;
                    break;
                case TypeIcon.Cancel:
                    pbxIcon.Image = Resources.calcel;
                    break;
                case TypeIcon.Info:
                    pbxIcon.Image = Resources.info;
                    break;
                case TypeIcon.Warning:
                    pbxIcon.Image = Resources.warnning;
                    break;
            }

            if (ShowButtonCancel)
            {
                btnCancelar.Visible = true;
                btnCancelar.Location = new Point(302, 5);
                btnAceptar.Location = new Point(198, 5);
            }
            else
            {
                btnAceptar.Location = new Point(302, 5);
            }

            //Message string lenght up to 150 
            if (!string.IsNullOrEmpty(Message) && Message.Length > 150)
            {
                this.Height = 350;

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
