using ATMW.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMW.Datas;
using System.Reflection;
using ATMW.Controls;
using Apulsetech.Util.Diagnostics;

namespace ATMW
{
    static class Program
    {
        private static readonly string TAG = typeof(Program).Name;
        private const bool I = true;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string moduleName = SysUtil.GetModuleName(assembly);
            ATrace.InitTrace(true);
            ATrace.i(TAG, I, "BEGIN. ==================== {0} ========================================",
                moduleName);

            Config.Load(assembly);

            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.ATMW_Main(/*1*/));
            //Application.Run(new LoginForm());
        }
    }
}
