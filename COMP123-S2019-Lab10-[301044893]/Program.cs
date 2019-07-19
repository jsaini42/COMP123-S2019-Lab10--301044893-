using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10__301044893_
{
    static class Program
    {
        public static MainForm mainform { get; set; }
        public static  EndForm endform { get; set; }
        public static StartForm startform { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainform = new MainForm();
            endform = new EndForm();
            startform = new StartForm();
            Application.Run(new StartForm());
            
        }
    }
}
