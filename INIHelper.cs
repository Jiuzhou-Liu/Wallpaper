using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Wallpaper
{
    /// <summary>
    /// ini配置文件 操作类
    /// </summary>
    public static class INIHelper
    {

        [DllImport("kernel32")]
        private static extern void WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32")]
        private static extern void GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileString(string section, string key, string def, Byte[] retVal, int size, string filePath);

        public static string path = System.Windows.Forms.Application.StartupPath + @"\App.ini";

        /// <summary>
        /// 设置属性值，键名不存在会自动创建
        /// </summary>
        /// <param name="section">段落名</param>
        /// <param name="key">键名</param>
        /// <param name="value">值内容<param>
        public static void Set(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="section">段落名</param>
        /// <param name="key">键名</param>
        /// <returns></returns>
        public static string Get(string section, string key)
        {
            StringBuilder str = new StringBuilder(2048);
            GetPrivateProfileString(section, key, "", str, 2048, path);
            return str.ToString();
        }

        /// <summary>
        /// 获取所有段落名
        /// </summary>
        /// <returns></returns>
        public static List<string> Get()
        {
            List<string> result = new List<string>();
            Byte[] buf = new Byte[65536];
            uint len = GetPrivateProfileString(null, null, null, buf, buf.Length, path);
            int j = 0;
            for (int i = 0; i < len; i++)
                if (buf[i] == 0)
                {
                    result.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            return result;
        }

        /// <summary>
        /// 获取段落下所有键名
        /// </summary>
        /// <param name="section">段落名</param>
        /// <returns></returns>
        public static List<string> Get(string section)
        {
            List<string> result = new List<string>();
            Byte[] buf = new Byte[65536];
            uint len = GetPrivateProfileString(section, null, null, buf, buf.Length, path);
            int j = 0;
            for (int i = 0; i < len; i++)
                if (buf[i] == 0)
                {
                    result.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            return result;
        }

    }
}

