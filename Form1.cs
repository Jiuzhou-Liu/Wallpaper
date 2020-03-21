using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Microsoft.Win32;

namespace Wallpaper
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\App.ini"))
                File.AppendAllText(Application.StartupPath + "\\App.ini", @"[System]
AutoStart=1
AutoChange=1
Frequency=15
Url=http://api.btstu.cn/sjbz/?lx=meizi
");

            if (INIHelper.Get("system", "AutoStart") != "0")
            {
                cbxAutoStart.Checked = true;
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.SetValue("Wallpaper", path);
                rk2.Close();
                rk.Close();
            }
            else
            {
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.DeleteValue("Wallpaper", false);
                rk2.Close();
                rk.Close();
            }

            timer1.Enabled = false;
            if (INIHelper.Get("system", "AutoChange") != "0")
            {
                cbxAutoChange.Checked = true;

                timer1.Interval = int.Parse(INIHelper.Get("system", "Frequency")) * 60000;
                timer1.Enabled = true;
            }

            txtFrequency.Text = INIHelper.Get("system", "Frequency");
            txtUrl.Text = INIHelper.Get("system", "Url");

        }

        private void ChangeWallpaper()
        {
            if (!Directory.Exists("Wallpaper"))
            {
                Directory.CreateDirectory("Wallpaper");
            }
            string path = Application.StartupPath + "\\Wallpaper\\" + DateTime.Now.ToFileTime() + ".jpg";
            try
            {
                new System.Net.WebClient().DownloadFile(INIHelper.Get("system", "Url"), path);
                SystemParametersInfo(0x14, 0, path, 2);
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            INIHelper.Set("system", "AutoStart", cbxAutoStart.Checked == true ? "1" : "0");
            INIHelper.Set("system", "AutoChange", cbxAutoChange.Checked == true ? "1" : "0");
            INIHelper.Set("system", "Frequency", txtFrequency.Text);
            INIHelper.Set("system", "Url", txtUrl.Text);

            Form1_Load(null, null);

            MessageBox.Show("保存成功", "提示");

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeWallpaper();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出吗", "退出", MessageBoxButtons.OKCancel) == DialogResult.OK)
                System.Environment.Exit(0);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal;
                Activate();
            }
        }

        private void 更换壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeWallpaper();
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {

        }
    }
}
