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
        private Timer timer = new Timer();
        private int pollInterval = Int32.Parse(ConfigurationManager.AppSettings["pollInterval"]);

        public EmissionsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer.Interval = pollInterval;
            timer.Elapsed += new ElapsedEventHandler(this.SendData);
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }

        // Сбор и отправка данных
        protected void SendData(object sender, ElapsedEventArgs args)
        {
            List<Value> values;

            values = Value.GetNew(DataService.DbConnectionString, pollInterval / 1000);

            if (values.Count == 0)
            {
                values = Value.GetLatest(DataService.DbConnectionString);
            }

            Console.WriteLine(DateTime.UtcNow.ToString());
            foreach (Value val in values)
            {
                Console.WriteLine(val.value);
            }
            Console.WriteLine();
        }

        // Для запуска в качестве консольного приложения
        internal void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }
    }
}
