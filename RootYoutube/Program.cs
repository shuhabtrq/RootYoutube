using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RootYoutube
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, arg) => { if (arg.Name.StartsWith("Newtonsoft")) return System.Reflection.Assembly.Load(Properties.Resources.Newtonsoft_Json); return null; };
            AppDomain.CurrentDomain.AssemblyResolve += (sender, arg) => { if (arg.Name.StartsWith("Youtube")) return System.Reflection.Assembly.Load(Properties.Resources.YoutubeExtractor); return null; };
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new YoutubeRooter());
        }
    }
}
