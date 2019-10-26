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
            System.IO.File.WriteAllText($@"{dir}runner\script.js", code);

            webBrowser.ScriptErrorsSuppressed = true;
            Uri u = new Uri($@"{dir}runner\index.html");
            webBrowser.Navigate(u);

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            if (key != null)
            {
                key.SetValue("EasyCode IDE.exe", 11001, RegistryValueKind.DWord);
            }
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            if (key != null)
            {
                key.SetValue("EasyCode IDE.exe", 11001, RegistryValueKind.DWord);
            }

        }

        public Color button_default;
        public Color button_default_font;
        public Color default_back;
        private void MAIN_Load(object sender, EventArgs e)
        {
            new_file.BackColor = button_default;
            save_file.BackColor = button_default;
            open_file.BackColor = button_default;
            viewMinus.BackColor = button_default;
            viewPlus.BackColor = button_default;
            Light.BackColor = button_default;
            Dark.BackColor = button_default;
            run.BackColor = button_default;

            new_file.FlatAppearance.BorderColor = button_default;
            save_file.FlatAppearance.BorderColor = button_default;
            open_file.FlatAppearance.BorderColor = button_default;
            viewMinus.FlatAppearance.BorderColor = button_default;
            viewPlus.FlatAppearance.BorderColor = button_default;
            Light.FlatAppearance.BorderColor = button_default;
            Dark.FlatAppearance.BorderColor = button_default;
            run.FlatAppearance.BorderColor = button_default;

            new_file.ForeColor = button_default_font;
            save_file.ForeColor = button_default_font;
            open_file.ForeColor = button_default_font;
            viewMinus.ForeColor = button_default_font;
            viewPlus.ForeColor = button_default_font;
            Light.ForeColor = button_default_font;
            Dark.ForeColor = button_default_font;
            run.ForeColor = button_default_font;

            this.BackColor = default_back;
            codeBox.BackColor = Color.White;
            codeBox.ForeColor = Color.Black;
            button_default = new_file.BackColor;
            button_default_font = new_file.ForeColor;
            default_back = this.BackColor;
            AddFontResource($@"{dir}fonts\UbuntuMono-B.ttf");

            AddFontResource($@"{dir}fonts\UbuntuMono-BI.ttf");

            AddFontResource($@"{dir}fonts\UbuntuMono-R.ttf");

            AddFontResource($@"{dir}fonts\UbuntuMono-RI.ttf");
        }

        private void New_file_Click(object sender, EventArgs e)
        {
            codeBox.Text = "";
        }
        public int selectStart;
        public string theme_color = "white";
        public Color themeScript = new Color();

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (theme_color == "white")
            {
                themeScript = Color.Black;
            } else if (theme_color == "black")
            {
                themeScript = Color.AntiqueWhite;
            }
            if (this.codeBox.Text.Contains(word))
            {
                int index = -1;
                selectStart = this.codeBox.SelectionStart;

                while ((index = this.codeBox.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.codeBox.SelectionBackColor = Color.Transparent;
                    this.codeBox.Select((index + startIndex), word.Length);
                    this.codeBox.SelectionColor = color;
                    this.codeBox.Select(selectStart, 0);
                    this.codeBox.SelectionColor = themeScript;
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
            "clear()",
        };
        public string[] libraries = new string[] {
            "doc.",
            "math.",
            "style." ,
            "design.",
            //SUB LIBRARIES AND METHODS
            
            //DOC
            "doc.add.",
            "doc.add.p",
            "doc.add.html",
            "doc.add.css",
            "doc.add.block",
            "doc.hide",
            "doc.show",
            
            //MATH
            "math.pi",
            "math.PI",
            "math.power",
            "math.factorial",

            //STYLE
            "style.setBack",
            "style.setFont.color",
            "style.setFont.style",
            "style.setBackImg",

            //DESIGN
            "design.add",
            "design.add.label",
            "design.add.navbar",
        };
        #endregion



        private void CodeBox_text(object sender, EventArgs e)
        {

            if (theme_color == "white")
            {
                foreach (string key in normal_keywords)
                {
                    this.CheckKeyword(key, Color.Brown, 0);
                }
                foreach (string key in libraries)
                {
                    this.CheckKeyword(key, Color.MediumAquamarine, 0);
                }
            }
            else if (theme_color == "black")
            {
                foreach (string key in normal_keywords)
                {
                    this.CheckKeyword(key, Color.Pink, 0);
                }
                foreach (string key in libraries)
                {
                    this.CheckKeyword(key, Color.Aqua, 0);
                }
            }
            try
            {
                if (Convert.ToString(this.codeBox.Text[this.codeBox.Text.Length - 1]) == "{")
                {
                    selectStart = this.codeBox.SelectionStart;
                    this.codeBox.Text += "}";
                    this.codeBox.Select(selectStart, 0);
                }
                if (Convert.ToString(this.codeBox.Text[this.codeBox.Text.Length - 1]) == "(")
                {
                    selectStart = this.codeBox.SelectionStart;
                    this.codeBox.Text += ")";
                    this.codeBox.Select(selectStart, 0);
                }
                if (Convert.ToString(this.codeBox.Text[this.codeBox.Text.Length - 1]) == "[")
                {
                    selectStart = this.codeBox.SelectionStart;
                    this.codeBox.Text += "]";
                    this.codeBox.Select(selectStart, 0);
                }
                else
                {

                }
            }
            catch { }
            selectStart = this.codeBox.SelectionStart;
            this.codeBox.Select(selectStart, 0);
            this.codeBox.SelectionColor = themeScript;

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
        public int font = 14;

        private void ViewPlus_Click(object sender, EventArgs e)
        {
            if (font != 48)
            {
                font += 2;
                codeBox.Font = new Font(codeBox.Font.FontFamily, font);
            }
        }

        private void ViewMinus_Click(object sender, EventArgs e)
        {
            if (font != 10)
            {
                font -= 2;
                codeBox.Font = new Font(codeBox.Font.FontFamily, font);
            }
        }
        private void Dark_Click(object sender, EventArgs e)
        {
            Color button_color = Color.Gray;
            theme_color = "black";


            new_file.BackColor = button_color;
            new_file.FlatAppearance.BorderColor = button_color;
            new_file.ForeColor = Color.White;
            save_file.BackColor = button_color;
            save_file.FlatAppearance.BorderColor = button_color;
            save_file.ForeColor = Color.White;
            open_file.BackColor = button_color;
            open_file.FlatAppearance.BorderColor = button_color;
            open_file.ForeColor = Color.White;
            viewMinus.BackColor = button_color;
            viewMinus.FlatAppearance.BorderColor = button_color;
            viewMinus.ForeColor = Color.White;
            viewPlus.BackColor = button_color;
            viewPlus.FlatAppearance.BorderColor = button_color;
            viewPlus.ForeColor = Color.White;
            Light.BackColor = button_color;
            Light.FlatAppearance.BorderColor = button_color;
            Light.ForeColor = Color.White;
            Dark.BackColor = button_color;
            Dark.FlatAppearance.BorderColor = button_color;
            Dark.ForeColor = Color.White;
            run.BackColor = button_color;
            run.FlatAppearance.BorderColor = button_color;
            run.ForeColor = Color.White;

            this.BackColor = Color.DarkGray;
            codeBox.BackColor = Color.Black;
            codeBox.ForeColor = Color.White;
        }
        private void Light_Click(object sender, EventArgs e)
        {
            theme_color = "white";

            new_file.BackColor = button_default;
            save_file.BackColor = button_default;
            open_file.BackColor = button_default;
            viewMinus.BackColor = button_default;
            viewPlus.BackColor = button_default;
            Light.BackColor = button_default;
            Dark.BackColor = button_default;
            run.BackColor = button_default;

            new_file.FlatAppearance.BorderColor = button_default;
            save_file.FlatAppearance.BorderColor = button_default;
            open_file.FlatAppearance.BorderColor = button_default;
            viewMinus.FlatAppearance.BorderColor = button_default;
            viewPlus.FlatAppearance.BorderColor = button_default;
            Light.FlatAppearance.BorderColor = button_default;
            Dark.FlatAppearance.BorderColor = button_default;
            run.FlatAppearance.BorderColor = button_default;

            new_file.ForeColor = button_default_font;
            save_file.ForeColor = button_default_font;
            open_file.ForeColor = button_default_font;
            viewMinus.ForeColor = button_default_font;
            viewPlus.ForeColor = button_default_font;
            Light.ForeColor = button_default_font;
            Dark.ForeColor = button_default_font;
            run.ForeColor = button_default_font;

            this.BackColor = default_back;
            codeBox.BackColor = Color.White;
            codeBox.ForeColor = Color.Black;

        }
    }
}
