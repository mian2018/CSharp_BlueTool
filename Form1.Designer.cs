
namespace CSharp_蓝屏小工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labLog = new System.Windows.Forms.Label();
            this.timerLog = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labLog
            // 
            this.labLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(155)))));
            this.labLog.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLog.ForeColor = System.Drawing.SystemColors.Control;
            this.labLog.Location = new System.Drawing.Point(300, 380);
            this.labLog.Name = "labLog";
            this.labLog.Size = new System.Drawing.Size(100, 15);
            this.labLog.TabIndex = 0;
            this.labLog.Text = "加载面板";
            this.labLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLog
            // 
            this.timerLog.Enabled = true;
            this.timerLog.Interval = 1000;
            this.timerLog.Tick += new System.EventHandler(this.timerLog_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharp_蓝屏小工具.Properties.Resources.登陆界面;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.ControlBox = false;
            this.Controls.Add(this.labLog);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labLog;
        private System.Windows.Forms.Timer timerLog;
    }
}

