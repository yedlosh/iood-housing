using IOOD_Housing.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IOOD_Housing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DashboardPresenter dashboardPresenter = new DashboardPresenter(new DashboardView());
            Application.Run((Form)dashboardPresenter.dashboardView);
        }
    }
}
