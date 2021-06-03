using System;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Forms.Loader
{
    public partial class LoaderForm : Form
    {
        public LoaderForm()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            Form Return = (Form)this.Owner;
            Return.Enabled = false;

            
        }

        private void Loader_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Return = (Form)this.Owner;
            Return.Enabled = true;
            Return.ShowIcon = false;
        }
    }
}
