using System;
using System.Windows.Forms;

namespace encoder_Alpha
{
    static class Program
    {
        internal static string d1;
        static string ProcessInput(string s)
        {
            return s;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //foreach (string s in args)
            //{
            //    ProcessInput(s);
            //    d1 = s;
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Capture());
        }
    }
}
