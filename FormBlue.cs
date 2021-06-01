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
    public partial class FormBlue : Form
    {
        public FormBlue()
        {
            InitializeComponent();
        }

        private void FormBlue_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
