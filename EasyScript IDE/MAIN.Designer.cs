namespace EasyCode_IDE
{
    partial class MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.run = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            this.new_file = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewMinus = new System.Windows.Forms.Button();
            this.viewPlus = new System.Windows.Forms.Button();
            this.Dark = new System.Windows.Forms.Button();
            this.Light = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(784, 12);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(10);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(711, 735);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Ubuntu Mono", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(561, 12);
            this.run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(176, 69);
            this.run.TabIndex = 2;
            this.run.Text = "RUN >";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.Button1_Click);
            // 
            // open_file
            // 
            this.open_file.Font = new System.Drawing.Font("Ubuntu Mono", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_file.Location = new System.Drawing.Point(379, 12);
            this.open_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(176, 69);
            this.open_file.TabIndex = 3;
            this.open_file.Text = "OPEN";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.Open_file_Click);
            // 
            // save_file
            // 
            this.save_file.Font = new System.Drawing.Font("Ubuntu Mono", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_file.Location = new System.Drawing.Point(197, 12);
            this.save_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(176, 69);
            this.save_file.TabIndex = 4;
            this.save_file.Text = "SAVE";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // new_file
            // 
            this.new_file.Font = new System.Drawing.Font("Ubuntu Mono", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_file.Location = new System.Drawing.Point(15, 12);
            this.new_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_file.Name = "new_file";
            this.new_file.Size = new System.Drawing.Size(176, 69);
            this.new_file.TabIndex = 5;
            this.new_file.Text = "NEW";
            this.new_file.UseVisualStyleBackColor = true;
            this.new_file.Click += new System.EventHandler(this.New_file_Click);
            // 
            // codeBox
            // 
            this.codeBox.AcceptsTab = true;
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeBox.Font = new System.Drawing.Font("Ubuntu Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(12, 142);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(742, 605);
            this.codeBox.TabIndex = 6;
            this.codeBox.Text = "";
            this.codeBox.TextChanged += new System.EventHandler(this.CodeBox_text);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "MyCode.easy";
            this.saveFileDialog1.Title = "Save your code.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // viewMinus
            // 
            this.viewMinus.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMinus.Location = new System.Drawing.Point(15, 87);
            this.viewMinus.Name = "viewMinus";
            this.viewMinus.Size = new System.Drawing.Size(80, 49);
            this.viewMinus.TabIndex = 7;
            this.viewMinus.Text = "-";
            this.viewMinus.UseVisualStyleBackColor = true;
            this.viewMinus.Click += new System.EventHandler(this.ViewMinus_Click);
            // 
            // viewPlus
            // 
            this.viewPlus.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPlus.Location = new System.Drawing.Point(111, 87);
            this.viewPlus.Name = "viewPlus";
            this.viewPlus.Size = new System.Drawing.Size(80, 49);
            this.viewPlus.TabIndex = 8;
            this.viewPlus.Text = "+";
            this.viewPlus.UseVisualStyleBackColor = true;
            this.viewPlus.Click += new System.EventHandler(this.ViewPlus_Click);
            // 
            // Dark
            // 
            this.Dark.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dark.Location = new System.Drawing.Point(608, 87);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(129, 49);
            this.Dark.TabIndex = 9;
            this.Dark.Text = "Dark";
            this.Dark.UseVisualStyleBackColor = true;
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // Light
            // 
            this.Light.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light.Location = new System.Drawing.Point(473, 86);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(129, 50);
            this.Light.TabIndex = 10;
            this.Light.Text = "Light";
            this.Light.UseVisualStyleBackColor = true;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 758);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.viewPlus);
            this.Controls.Add(this.viewMinus);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.new_file);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.run);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyCode IDE";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.Button new_file;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button viewMinus;
        private System.Windows.Forms.Button viewPlus;
        private System.Windows.Forms.Button Dark;
        private System.Windows.Forms.Button Light;
    }
}

