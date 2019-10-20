using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCode_IDE
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dir = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("EasyCode IDE.exe", "");

            string code = codeBox.Text;
            System.IO.File.WriteAllText($@"{dir}runner\script.js",code);




            webBrowser.ScriptErrorsSuppressed = true;
            Uri u = new Uri($@"{dir}runner\index.html");
            webBrowser.Navigate(u);
            
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",true);
            if (key != null)
            {
                key.SetValue("EasyCode IDE.exe",11001,RegistryValueKind.DWord);
            }
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",true);
            if (key != null)
            {
                key.SetValue("EasyCode IDE.exe",11001,RegistryValueKind.DWord);
            }
            
        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void New_file_Click(object sender, EventArgs e)
        {
            codeBox.Text = "";
        }
    }
}
