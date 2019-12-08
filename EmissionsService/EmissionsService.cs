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
using System.Runtime.InteropServices;
using System.Configuration;
using EmissionsLibrary;

namespace EmissionsService
{
    public partial class EmissionsService : ServiceBase
    {
        private readonly Timer timer = new Timer();
        private readonly int pollInterval = Int32.Parse(ConfigurationManager.AppSettings["pollInterval"]);

        public EmissionsService()
        {
            InitializeComponent();
        }

        // Для запуска в качестве консольного приложения
        internal void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }

        protected override void OnStart(string[] args)
        {
            timer.Interval = pollInterval;
            timer.Elapsed += new ElapsedEventHandler(this.ProcessData);
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }

        // Получение и отправка данных
        protected void ProcessData(object sender, ElapsedEventArgs args)
        {
            TransmitionService.SendData(DBService.GetData());            
        }
    }
}
