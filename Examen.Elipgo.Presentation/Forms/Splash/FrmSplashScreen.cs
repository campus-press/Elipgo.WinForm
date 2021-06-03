using Examen.Elipgo.Presentation.Configuration.Contexts;
using Examen.Elipgo.Presentation.Forms.Config;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Examen.Elipgo.BusinessLogic.Entities;
using Examen.Elipgo.BusinessLogic.Interfaces;

namespace Examen.Elipgo.Presentation.Forms.Splash
{
    public partial class FrmSplashScreen : Form
    {
        private System.Windows.Forms.Timer tmr;
        private bool viewConfig = false;
        private bool IsValudURL = true;
        private IServiceConnect _serviceConnect;
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private async void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var setting = db.ApplicationSettings.First();
                if (setting.IsFirstExecution)
                {
                    viewConfig = true;
                }
                else
                {
                    lblMessage.Text = "Verificando Conexion A Servicio.......";
                    _serviceConnect = new ServiceConnect(setting.UrlConnectionRestAPI);
                    IsValudURL = await _serviceConnect.ConnectionTest();
                }
            }
            tmr = new System.Windows.Forms.Timer();
            lblMessage.Text = "Validando Información.......";
            tmr.Tick += delegate {

                if (viewConfig)
                {
                    var t = new Thread(new ThreadStart(OpenFrm));
                    t.Start();
                    this.Close();
                }
                else
                {
                    var t = new Thread(new ThreadStart(OpenFrm));
                    t.Start();
                    this.Close();
                }

            };
            tmr.Interval = (int)TimeSpan.FromMilliseconds(4000).TotalMilliseconds;
            tmr.Start();
        }

        private void OpenFrm()
        {
            if (viewConfig | !IsValudURL)
            {
                var form = new FrmConfig();
                if (!IsValudURL)
                {
                    form.isFirstInitial = false;
                    form.MessageError = "FAIL_CONNECTION";
                }
                Application.Run(form);
            }
            else
            {
                Application.Run(new Login());
            }
        }

        
    }
}
