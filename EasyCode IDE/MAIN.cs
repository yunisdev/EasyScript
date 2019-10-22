using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string dir = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("EasyCode IDE.exe", "");
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                         string lpFileName);

        private void Button1_Click(object sender, EventArgs e)
        {

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
            AddFontResource($@"{dir}fonts\UbuntuMono-B.ttf");

            AddFontResource($@"{dir}fonts\UbuntuMono-BI.ttf");

            AddFontResource($@"{dir}fonts\UbuntuMono-R.ttf");

            AddFontResource($@"{dir}fonts\UbuntuMono-RI.ttf");
        }

        private void New_file_Click(object sender, EventArgs e)
        {
            codeBox.Text = "";
        }



        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.codeBox.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.codeBox.SelectionStart;

                while ((index = this.codeBox.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.codeBox.SelectionBackColor =Color.Transparent;
                    this.codeBox.Select((index + startIndex), word.Length);
                    this.codeBox.SelectionColor = color;
                    this.codeBox.Select(selectStart, 0);
                    this.codeBox.SelectionColor = Color.Black;
                }
            }
        }

        #region Keywords
        public string[] normal_keywords = new string[] {
            "writeln",
            "write",
            "if","else",
            "while",
            "for",
            "msbox",
            "getDate",
        };
        public string[] libraries = new string[] { "doc.", "math.", "style."};
        public string[] inc_libraries = new string[] {"designer()" , "advanced()"};
        #endregion

        private void CodeBox_text(object sender, EventArgs e)
        {
            foreach (string key in inc_libraries)
            {
                this.CheckKeyword(key, Color.Red, 0);
            }
            foreach (string key in normal_keywords)
            {
                this.CheckKeyword(key, Color.Brown, 0);
            }
            foreach (string key in libraries)
            {
                this.CheckKeyword(key, Color.Aqua, 0);
            }

            this.CheckKeyword("include.", Color.Violet, 0);
        }

        private void Save_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "NewScript.easy";
            saveFileDialog1.Filter = "EasyCode script file (*.easy)|*.easy";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                codeBox.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void Open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "EasyCode script file (*.easy)|*.easy";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                codeBox.LoadFile(openFileDialog1.FileName);
            }
        }
    }
}
