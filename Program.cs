using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_蓝屏小工具
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TaskmgrKill.Run();
            Form1 form1 = new Form1();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                //加载界面加载完成  显示蓝屏窗体
                Application.Run(new FormBlue());
            }
        }
    }
}
