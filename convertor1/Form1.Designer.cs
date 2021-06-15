namespace convertor1
{
    partial class Form1
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
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmb1.Location = new System.Drawing.Point(280, 60);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 0;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmb2.Location = new System.Drawing.Point(280, 127);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 21);
            this.cmb2.TabIndex = 1;
            this.cmb2.SelectedIndexChanged += new System.EventHandler(this.cmb2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(205, 199);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 4;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnconvert;
    }
}

