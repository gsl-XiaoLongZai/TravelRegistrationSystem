﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using TravelRegistrationSystem.WinFormUI.Infrastructure;
using TravelRegistrationSystem.Domain.Concrete;

namespace TravelRegistrationSystem.WinFormUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            NinjectControllerFactory.AddBindings(new ApplicationModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
            //Application.Run(NinjectControllerFactory.Resolve<FrmMain>());
        }
    }
}
