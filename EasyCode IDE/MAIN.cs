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
            webBrowser.ScriptErrorsSuppressed = true;
            Uri u = new Uri(@"D:\Programming\Programming Projects\EasyCode\runner\index.html");
            webBrowser.Navigate(u);
            var CurrentDocument = (mshtml.HTMLDocument)webBrowser1.Document.DomDocument;
            var styleSheet = CurrentDocument.createStyleSheet("", 0);

            StreamReader streamReader = new StreamReader(@"test.css"); //test.css is Stylesheet file
            string text = streamReader.ReadToEnd();
            streamReader.Close();
            styleSheet.cssText
        }
    }
}
