using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaProject.DAL;
using AviaProject.DAL.Entities;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Repositories;
using AviaProject.DAL.Repositories.TextFileSaves;
using AviaProject.BLL.Infrastructure;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Services;

namespace AviaProjectWF.PL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new AdminWorkplace());
            Application.Run(new LoginForm());
        }
    }
}
