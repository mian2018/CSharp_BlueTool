using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_蓝屏小工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //要显示的信息
        List<string> strLog = new List<string> { "加载配置信息", "增加首选项", "正在初始化", "增加脚本支持" };
        private void timerLog_Tick(object sender, EventArgs e)
        {
            if(strLog.Count > 0)
            {
                //更换显示信息
                labLog.Text = strLog[0];
                strLog.RemoveAt(0);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                timerLog.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
