namespace Wordle
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(135, 13);
            richTextBox1.MaxLength = 5;
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(168, 73);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.KeyPress += onGuess;
            // 
            // richTextBox2
            // 
            richTextBox2.DetectUrls = false;
            richTextBox2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(135, 92);
            richTextBox2.MaxLength = 5;
            richTextBox2.Multiline = false;
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(168, 73);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            richTextBox2.KeyPress += onGuess;
            // 
            // richTextBox3
            // 
            richTextBox3.DetectUrls = false;
            richTextBox3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(135, 171);
            richTextBox3.MaxLength = 5;
            richTextBox3.Multiline = false;
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(168, 73);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            richTextBox3.KeyPress += onGuess;
            // 
            // richTextBox4
            // 
            richTextBox4.DetectUrls = false;
            richTextBox4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(135, 250);
            richTextBox4.MaxLength = 5;
            richTextBox4.Multiline = false;
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox4.Size = new Size(168, 73);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = "";
            richTextBox4.KeyPress += onGuess;
            // 
            // richTextBox5
            // 
            richTextBox5.DetectUrls = false;
            richTextBox5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox5.Location = new Point(135, 329);
            richTextBox5.MaxLength = 5;
            richTextBox5.Multiline = false;
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox5.Size = new Size(168, 73);
            richTextBox5.TabIndex = 5;
            richTextBox5.Text = "";
            richTextBox5.KeyPress += onGuess;
            // 
            // richTextBox6
            // 
            richTextBox6.DetectUrls = false;
            richTextBox6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox6.Location = new Point(135, 408);
            richTextBox6.MaxLength = 5;
            richTextBox6.Multiline = false;
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox6.Size = new Size(168, 73);
            richTextBox6.TabIndex = 6;
            richTextBox6.Text = "";
            richTextBox6.KeyPress += onGuess;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 521);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            Text = "Wordle";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
    }
}