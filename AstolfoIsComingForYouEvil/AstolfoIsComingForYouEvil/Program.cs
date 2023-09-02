using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstolfoIsComingForYouEvil
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
            LoadAstolfoJpg();
            Application.Run(new Form1());
        }
        private static void LoadAstolfoJpg()
        {
            var bytes = Array.Empty<byte>();
            using (var s = Assembly.GetExecutingAssembly()
                       .GetManifestResourceStream("AstolfoIsComingForYouEvil.Resources.astolfo.jpg"))
            {
                bytes = new byte[s.Length];
                s.Read(bytes, 0, bytes.Length);
            }


            using (var fs = new BinaryWriter(File.OpenWrite("astolfo.jpg")))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}