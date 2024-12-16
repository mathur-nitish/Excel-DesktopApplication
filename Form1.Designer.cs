namespace ExcelClone
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicTabbutton = new System.Windows.Forms.Button();
            this.insertTabbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sheet1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formulasTabbutton = new System.Windows.Forms.Button();
            this.viewTabbutton = new System.Windows.Forms.Button();
            this.baseContextstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoFilloption = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.baseContextstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.extensionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Option 1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "Option 2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // extensionsToolStripMenuItem
            // 
            this.extensionsToolStripMenuItem.Name = "extensionsToolStripMenuItem";
            this.extensionsToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.extensionsToolStripMenuItem.Text = "Extensions";
            // 
            // basicTabbutton
            // 
            this.basicTabbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.basicTabbutton.FlatAppearance.BorderSize = 0;
            this.basicTabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicTabbutton.Location = new System.Drawing.Point(12, 29);
            this.basicTabbutton.Name = "basicTabbutton";
            this.basicTabbutton.Size = new System.Drawing.Size(84, 25);
            this.basicTabbutton.TabIndex = 4;
            this.basicTabbutton.Text = "Basic";
            this.basicTabbutton.UseVisualStyleBackColor = false;
            this.basicTabbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertTabbutton
            // 
            this.insertTabbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.insertTabbutton.FlatAppearance.BorderSize = 0;
            this.insertTabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertTabbutton.Location = new System.Drawing.Point(95, 29);
            this.insertTabbutton.Name = "insertTabbutton";
            this.insertTabbutton.Size = new System.Drawing.Size(97, 24);
            this.insertTabbutton.TabIndex = 6;
            this.insertTabbutton.Text = "Insert";
            this.insertTabbutton.UseVisualStyleBackColor = false;
            this.insertTabbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 163);
            this.panel1.TabIndex = 5;
            // 
            // sheet1
            // 
            this.sheet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sheet1.Location = new System.Drawing.Point(0, 223);
            this.sheet1.Name = "sheet1";
            this.sheet1.RowHeadersWidth = 51;
            this.sheet1.RowTemplate.DefaultCellStyle.Format = "N2";
            this.sheet1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.sheet1.RowTemplate.Height = 24;
            this.sheet1.Size = new System.Drawing.Size(1249, 490);
            this.sheet1.TabIndex = 0;
            this.sheet1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.sheet1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.sheet1_CellLeave);
            this.sheet1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sheet1_CellMouseDown);
            this.sheet1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sheet1_CellMouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1249, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // formulasTabbutton
            // 
            this.formulasTabbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.formulasTabbutton.FlatAppearance.BorderSize = 0;
            this.formulasTabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formulasTabbutton.Location = new System.Drawing.Point(198, 30);
            this.formulasTabbutton.Name = "formulasTabbutton";
            this.formulasTabbutton.Size = new System.Drawing.Size(97, 24);
            this.formulasTabbutton.TabIndex = 8;
            this.formulasTabbutton.Text = "Formulas";
            this.formulasTabbutton.UseVisualStyleBackColor = false;
            this.formulasTabbutton.Click += new System.EventHandler(this.formulasTabbutton_Click);
            // 
            // viewTabbutton
            // 
            this.viewTabbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.viewTabbutton.FlatAppearance.BorderSize = 0;
            this.viewTabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTabbutton.Location = new System.Drawing.Point(301, 29);
            this.viewTabbutton.Name = "viewTabbutton";
            this.viewTabbutton.Size = new System.Drawing.Size(97, 24);
            this.viewTabbutton.TabIndex = 9;
            this.viewTabbutton.Text = "View";
            this.viewTabbutton.UseVisualStyleBackColor = false;
            this.viewTabbutton.Click += new System.EventHandler(this.viewTabbutton_Click);
            // 
            // baseContextstrip
            // 
            this.baseContextstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseContextstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoFilloption,
            this.duplicateOption});
            this.baseContextstrip.Name = "baseContextstrip";
            this.baseContextstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.baseContextstrip.Size = new System.Drawing.Size(211, 80);
            // 
            // autoFilloption
            // 
            this.autoFilloption.Name = "autoFilloption";
            this.autoFilloption.Size = new System.Drawing.Size(210, 24);
            this.autoFilloption.Text = "AutoFill";
            this.autoFilloption.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // duplicateOption
            // 
            this.duplicateOption.Name = "duplicateOption";
            this.duplicateOption.Size = new System.Drawing.Size(210, 24);
            this.duplicateOption.Text = "Duplicate";
            this.duplicateOption.Click += new System.EventHandler(this.duplicateOption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1249, 714);
            this.Controls.Add(this.viewTabbutton);
            this.Controls.Add(this.formulasTabbutton);
            this.Controls.Add(this.basicTabbutton);
            this.Controls.Add(this.sheet1);
            this.Controls.Add(this.insertTabbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.baseContextstrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionsToolStripMenuItem;
        private System.Windows.Forms.Button basicTabbutton;
        private System.Windows.Forms.Button insertTabbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView sheet1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button formulasTabbutton;
        private System.Windows.Forms.Button viewTabbutton;
        private System.Windows.Forms.ContextMenuStrip baseContextstrip;
        private System.Windows.Forms.ToolStripMenuItem autoFilloption;
        private System.Windows.Forms.ToolStripMenuItem duplicateOption;
    }
}

