using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace ProjectManagerService
{
    public partial class MainService : ServiceBase
    {
        private  Timer timer1 = null;
        private  Timer timer2 = null;
        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            
            Thread servicethread = new Thread(threadClass.Intance.Dowork);
            servicethread.Start();
            servicethread.Join();
            timer1 = threadClass.Intance.timer1;
            timer2 = threadClass.Intance.timer2;
        }

        protected override void OnStop()
        {
        }

       
    }
}
