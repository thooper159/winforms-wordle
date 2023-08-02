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
            rtbUsedLetters = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            lblWins = new Label();
            lblLosses = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(150, 12);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.MaxLength = 5;
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(114, 56);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.KeyPress += onGuess;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top;
            richTextBox2.DetectUrls = false;
            richTextBox2.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(150, 74);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.MaxLength = 5;
            richTextBox2.Multiline = false;
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(114, 56);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            richTextBox2.KeyPress += onGuess;
            // 
            // richTextBox3
            // 
            richTextBox3.Anchor = AnchorStyles.Top;
            richTextBox3.DetectUrls = false;
            richTextBox3.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(150, 136);
            richTextBox3.Margin = new Padding(3, 4, 3, 4);
            richTextBox3.MaxLength = 5;
            richTextBox3.Multiline = false;
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(114, 56);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            richTextBox3.KeyPress += onGuess;
            // 
            // richTextBox4
            // 
            richTextBox4.Anchor = AnchorStyles.Top;
            richTextBox4.DetectUrls = false;
            richTextBox4.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(150, 198);
            richTextBox4.Margin = new Padding(3, 4, 3, 4);
            richTextBox4.MaxLength = 5;
            richTextBox4.Multiline = false;
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox4.Size = new Size(114, 56);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = "";
            richTextBox4.KeyPress += onGuess;
            // 
            // richTextBox5
            // 
            richTextBox5.Anchor = AnchorStyles.Top;
            richTextBox5.DetectUrls = false;
            richTextBox5.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox5.Location = new Point(150, 260);
            richTextBox5.Margin = new Padding(3, 4, 3, 4);
            richTextBox5.MaxLength = 5;
            richTextBox5.Multiline = false;
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox5.Size = new Size(114, 56);
            richTextBox5.TabIndex = 5;
            richTextBox5.Text = "";
            richTextBox5.KeyPress += onGuess;
            // 
            // richTextBox6
            // 
            richTextBox6.Anchor = AnchorStyles.Top;
            richTextBox6.DetectUrls = false;
            richTextBox6.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox6.Location = new Point(150, 322);
            richTextBox6.Margin = new Padding(3, 4, 3, 4);
            richTextBox6.MaxLength = 5;
            richTextBox6.Multiline = false;
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox6.Size = new Size(114, 56);
            richTextBox6.TabIndex = 6;
            richTextBox6.Text = "";
            richTextBox6.KeyPress += onGuess;
            // 
            // rtbUsedLetters
            // 
            rtbUsedLetters.Anchor = AnchorStyles.Top;
            rtbUsedLetters.Font = new Font("Courier New", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            rtbUsedLetters.Location = new Point(12, 386);
            rtbUsedLetters.Margin = new Padding(3, 4, 3, 4);
            rtbUsedLetters.Name = "rtbUsedLetters";
            rtbUsedLetters.ReadOnly = true;
            rtbUsedLetters.ScrollBars = RichTextBoxScrollBars.None;
            rtbUsedLetters.Size = new Size(390, 128);
            rtbUsedLetters.TabIndex = 7;
            rtbUsedLetters.Text = "Q W E R T Y U I O P\n A S D F G H J K L   \n  Z X C V B N M    ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 12);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 8;
            label1.Text = "W:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 12);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 9;
            label2.Text = "L:";
            // 
            // lblWins
            // 
            lblWins.AutoSize = true;
            lblWins.Location = new Point(323, 12);
            lblWins.Name = "lblWins";
            lblWins.Size = new Size(17, 20);
            lblWins.TabIndex = 10;
            lblWins.Text = "0";
            lblWins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLosses
            // 
            lblLosses.AutoSize = true;
            lblLosses.Location = new Point(380, 12);
            lblLosses.Name = "lblLosses";
            lblLosses.Size = new Size(17, 20);
            lblLosses.TabIndex = 11;
            lblLosses.Text = "0";
            lblLosses.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 564);
            Controls.Add(lblLosses);
            Controls.Add(lblWins);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbUsedLetters);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wordle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox rtbUsedLetters;
        private Label label1;
        private Label label2;
        private Label lblWins;
        private Label lblLosses;
    }
}