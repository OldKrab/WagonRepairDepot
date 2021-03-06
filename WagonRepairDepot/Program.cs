using System;
using System.Linq;
using System.Windows.Forms;
using WagonRepairDepot.Contexts;
using WagonRepairDepot.Windows;

namespace WagonRepairDepot
{
    internal static class Program
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

            using TrainContext db = new();
            /*
            AuthenticationForm af;
            Application.Run(af = new AuthenticationForm());
            if(af.isSuccess())
            {
                Application.Run(new EditBrigadeForm(db.Brigades.First(b => b.BrigadeId == 18)));
            }
            */
            Application.Run(new Form1());

        }
    }
}
