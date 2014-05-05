using System;
using System.Windows.Forms;
using ChinaBest.BaseApplication.CGCoreLib.Template;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                BaseTypeConvert.Inite();
            }
            catch { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}