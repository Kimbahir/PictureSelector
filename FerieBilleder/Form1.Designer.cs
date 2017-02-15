namespace FerieBilleder
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInput = new System.Windows.Forms.Button();
			this.btnOutput = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMask = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fORWARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sTATUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnPosition = new System.Windows.Forms.Button();
			this.txtPosition = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input directory";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Output directory";
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(105, 34);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(597, 23);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "Select directory";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// btnOutput
			// 
			this.btnOutput.Location = new System.Drawing.Point(105, 61);
			this.btnOutput.Name = "btnOutput";
			this.btnOutput.Size = new System.Drawing.Size(597, 23);
			this.btnOutput.TabIndex = 3;
			this.btnOutput.Text = "Select directory";
			this.btnOutput.UseVisualStyleBackColor = true;
			this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(12, 121);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(687, 425);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 4;
			this.pictureBox.TabStop = false;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Search mask";
			// 
			// txtMask
			// 
			this.txtMask.Location = new System.Drawing.Point(105, 91);
			this.txtMask.Name = "txtMask";
			this.txtMask.Size = new System.Drawing.Size(100, 20);
			this.txtMask.TabIndex = 6;
			this.txtMask.Text = "*.JPG";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.fORWARDToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.sTATUSToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(714, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// bACKToolStripMenuItem
			// 
			this.bACKToolStripMenuItem.Name = "bACKToolStripMenuItem";
			this.bACKToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.bACKToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.bACKToolStripMenuItem.Text = "BACK (F1)";
			this.bACKToolStripMenuItem.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
			// 
			// fORWARDToolStripMenuItem
			// 
			this.fORWARDToolStripMenuItem.Name = "fORWARDToolStripMenuItem";
			this.fORWARDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.fORWARDToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.fORWARDToolStripMenuItem.Text = "FORWARD (F2)";
			this.fORWARDToolStripMenuItem.Click += new System.EventHandler(this.fORWARDToolStripMenuItem_Click);
			// 
			// cOPYToolStripMenuItem
			// 
			this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
			this.cOPYToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.cOPYToolStripMenuItem.Text = "COPY (F3)";
			this.cOPYToolStripMenuItem.Click += new System.EventHandler(this.cOPYToolStripMenuItem_Click);
			// 
			// sTATUSToolStripMenuItem
			// 
			this.sTATUSToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.sTATUSToolStripMenuItem.Name = "sTATUSToolStripMenuItem";
			this.sTATUSToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.sTATUSToolStripMenuItem.Text = "INFORMATION";
			this.sTATUSToolStripMenuItem.Click += new System.EventHandler(this.sTATUSToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 550);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(714, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(212, 89);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "<< 10";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(293, 89);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "10 >>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(374, 89);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "20 >>";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(455, 89);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "50 >>";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnPosition
			// 
			this.btnPosition.Location = new System.Drawing.Point(627, 89);
			this.btnPosition.Name = "btnPosition";
			this.btnPosition.Size = new System.Drawing.Size(75, 23);
			this.btnPosition.TabIndex = 15;
			this.btnPosition.Text = "Go";
			this.btnPosition.UseVisualStyleBackColor = true;
			this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(537, 91);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(84, 20);
			this.txtPosition.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 572);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.btnPosition);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.txtMask);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnOutput);
			this.Controls.Add(this.btnInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Ferie Billeder v1";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMask;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fORWARDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ToolStripMenuItem sTATUSToolStripMenuItem;
		private System.Windows.Forms.Button btnPosition;
		private System.Windows.Forms.TextBox txtPosition;
    }
}

