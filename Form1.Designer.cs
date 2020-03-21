namespace Wallpaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cbxAutoStart = new System.Windows.Forms.CheckBox();
            this.cbxAutoChange = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更换壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(77, 166);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(86, 25);
            this.txtFrequency.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "分钟/次";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(77, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(77, 248);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(165, 25);
            this.txtUrl.TabIndex = 0;
            // 
            // cbxAutoStart
            // 
            this.cbxAutoStart.AutoSize = true;
            this.cbxAutoStart.Location = new System.Drawing.Point(77, 48);
            this.cbxAutoStart.Name = "cbxAutoStart";
            this.cbxAutoStart.Size = new System.Drawing.Size(89, 19);
            this.cbxAutoStart.TabIndex = 4;
            this.cbxAutoStart.Text = "开机启动";
            this.cbxAutoStart.UseVisualStyleBackColor = true;
            // 
            // cbxAutoChange
            // 
            this.cbxAutoChange.AutoSize = true;
            this.cbxAutoChange.Location = new System.Drawing.Point(77, 90);
            this.cbxAutoChange.Name = "cbxAutoChange";
            this.cbxAutoChange.Size = new System.Drawing.Size(119, 19);
            this.cbxAutoChange.TabIndex = 4;
            this.cbxAutoChange.Text = "自动更换壁纸";
            this.cbxAutoChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "壁纸接口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "更换频率";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "最美壁纸";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.更换壁纸ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 更换壁纸ToolStripMenuItem
            // 
            this.更换壁纸ToolStripMenuItem.Name = "更换壁纸ToolStripMenuItem";
            this.更换壁纸ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.更换壁纸ToolStripMenuItem.Text = "更换壁纸";
            this.更换壁纸ToolStripMenuItem.Click += new System.EventHandler(this.更换壁纸ToolStripMenuItem_Click);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.显示主界面ToolStripMenuItem.Text = "打开设置";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 368);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxAutoChange);
            this.Controls.Add(this.cbxAutoStart);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "最美壁纸";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.CheckBox cbxAutoStart;
        private System.Windows.Forms.CheckBox cbxAutoChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更换壁纸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
    }
}

