using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceGestionFrais
{
    public partial class ServiceGestionFrais : ServiceBase
    {
        public ServiceGestionFrais()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 86400000;  //=1jour en ms
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer); 
        }

        protected override void OnStop()
        {
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            DbConnect database = DbConnect.GetConnect();
            DateTime maintenant = DateTime.Now;
            string moisPrecedent = DateTime.Now.Year.ToString() + Date.getMoisPrecedent(maintenant);
            if (Date.entre(1, 10, maintenant) == true)
            {
                Dictionary<string, string> tmp = new Dictionary<string, string>();
                tmp.Add("idetat", "CR");
                database.Update("fichefrais", tmp, "WHERE mois='" + moisPrecedent + "'");

            }
            if (Date.entre(20, 31, maintenant) == true)
            {
                Dictionary<string, string> tmp = new Dictionary<string, string>();
                tmp.Add("idetat", "RB");
                database.Update("fichefrais", tmp, "WHERE mois='" + moisPrecedent + "' AND idetat='VA'");




            }

        }



    }
}
