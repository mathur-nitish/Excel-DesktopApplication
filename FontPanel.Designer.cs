namespace ExcelClone
{
    partial class FontPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BOLDButton = new System.Windows.Forms.Button();
            this.ItalicsButton = new System.Windows.Forms.Button();
            this.UnderlineTEXT = new System.Windows.Forms.Button();
            this.IncSizeFont = new System.Windows.Forms.Button();
            this.DecFontSize = new System.Windows.Forms.Button();
            this.FontColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontSelectBox = new System.Windows.Forms.ComboBox();
            this.fontSizeBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BOLDButton
            // 
            this.BOLDButton.Location = new System.Drawing.Point(84, 79);
            this.BOLDButton.Name = "BOLDButton";
            this.BOLDButton.Size = new System.Drawing.Size(27, 26);
            this.BOLDButton.TabIndex = 0;
            this.BOLDButton.Text = "B";
            this.BOLDButton.UseVisualStyleBackColor = true;
            this.BOLDButton.Click += new System.EventHandler(this.BOLDButton_Click);
            // 
            // ItalicsButton
            // 
            this.ItalicsButton.Location = new System.Drawing.Point(117, 79);
            this.ItalicsButton.Name = "ItalicsButton";
            this.ItalicsButton.Size = new System.Drawing.Size(27, 26);
            this.ItalicsButton.TabIndex = 1;
            this.ItalicsButton.Text = "I";
            this.ItalicsButton.UseVisualStyleBackColor = true;
            this.ItalicsButton.Click += new System.EventHandler(this.ItalicsButton_Click);
            // 
            // UnderlineTEXT
            // 
            this.UnderlineTEXT.Location = new System.Drawing.Point(150, 79);
            this.UnderlineTEXT.Name = "UnderlineTEXT";
            this.UnderlineTEXT.Size = new System.Drawing.Size(27, 26);
            this.UnderlineTEXT.TabIndex = 2;
            this.UnderlineTEXT.Text = "U";
            this.UnderlineTEXT.UseVisualStyleBackColor = true;
            this.UnderlineTEXT.Click += new System.EventHandler(this.UnderlineTEXT_Click);
            // 
            // IncSizeFont
            // 
            this.IncSizeFont.AutoSize = true;
            this.IncSizeFont.Location = new System.Drawing.Point(314, 79);
            this.IncSizeFont.Name = "IncSizeFont";
            this.IncSizeFont.Size = new System.Drawing.Size(60, 26);
            this.IncSizeFont.TabIndex = 3;
            this.IncSizeFont.Text = "IncText";
            this.IncSizeFont.UseVisualStyleBackColor = true;
            this.IncSizeFont.Click += new System.EventHandler(this.IncSizeFont_Click);
            // 
            // DecFontSize
            // 
            this.DecFontSize.AutoSize = true;
            this.DecFontSize.Location = new System.Drawing.Point(380, 79);
            this.DecFontSize.Name = "DecFontSize";
            this.DecFontSize.Size = new System.Drawing.Size(68, 26);
            this.DecFontSize.TabIndex = 4;
            this.DecFontSize.Text = "DecText";
            this.DecFontSize.UseVisualStyleBackColor = true;
            this.DecFontSize.Click += new System.EventHandler(this.DecFontSize_Click);
            // 
            // FontColorButton
            // 
            this.FontColorButton.AutoSize = true;
            this.FontColorButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.FontColorButton.Location = new System.Drawing.Point(411, 47);
            this.FontColorButton.Name = "FontColorButton";
            this.FontColorButton.Size = new System.Drawing.Size(27, 26);
            this.FontColorButton.TabIndex = 5;
            this.FontColorButton.UseVisualStyleBackColor = false;
            this.FontColorButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Basic Font";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Font Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Font Color";
            // 
            // fontSelectBox
            // 
            this.fontSelectBox.FormattingEnabled = true;
            this.fontSelectBox.Location = new System.Drawing.Point(45, 49);
            this.fontSelectBox.Name = "fontSelectBox";
            this.fontSelectBox.Size = new System.Drawing.Size(121, 24);
            this.fontSelectBox.TabIndex = 13;
            this.fontSelectBox.SelectedIndexChanged += new System.EventHandler(this.fontSelectBox_SelectedIndexChanged);
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.FormattingEnabled = true;
            this.fontSizeBox.Location = new System.Drawing.Point(173, 49);
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.Size = new System.Drawing.Size(51, 24);
            this.fontSizeBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 41);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FontPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.fontSizeBox);
            this.Controls.Add(this.fontSelectBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontColorButton);
            this.Controls.Add(this.DecFontSize);
            this.Controls.Add(this.IncSizeFont);
            this.Controls.Add(this.UnderlineTEXT);
            this.Controls.Add(this.ItalicsButton);
            this.Controls.Add(this.BOLDButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FontPanel";
            this.Size = new System.Drawing.Size(572, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOLDButton;
        private System.Windows.Forms.Button ItalicsButton;
        private System.Windows.Forms.Button UnderlineTEXT;
        private System.Windows.Forms.Button IncSizeFont;
        private System.Windows.Forms.Button DecFontSize;
        private System.Windows.Forms.Button FontColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fontSelectBox;
        private System.Windows.Forms.ComboBox fontSizeBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
