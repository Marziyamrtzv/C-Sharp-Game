using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mehmane_nakhande
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
public static mainform mymainform { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mymainform = new mainform();
            Application.Run(new loginform());
        }
        public static bool soundplayed
        { get; set; }

        public static bool name
        { get; set; }

        
    }
}
