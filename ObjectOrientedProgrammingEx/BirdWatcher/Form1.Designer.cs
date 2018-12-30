namespace BirdWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllBirdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tsbNavForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtBirdName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.RichTextBox();
            this.txtBehavior = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllBirdsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listAllBirdsToolStripMenuItem
            // 
            this.listAllBirdsToolStripMenuItem.Name = "listAllBirdsToolStripMenuItem";
            this.listAllBirdsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.listAllBirdsToolStripMenuItem.Text = "List All Birds";
            this.listAllBirdsToolStripMenuItem.Click += new System.EventHandler(this.listAllBirdsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbRemove,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.tsbSave,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.tsbNavForward,
            this.toolStripSeparator4,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "tsbAdd";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbRemove.Text = "toolStripButton2";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "tsbFindBird";
            this.toolStripButton3.Click += new System.EventHandler(this.tsbFindBird_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "tsbSave";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "tsbNavBack";
            this.toolStripButton5.Click += new System.EventHandler(this.tsbNavBack_Click);
            // 
            // tsbNavForward
            // 
            this.tsbNavForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavForward.Image")));
            this.tsbNavForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavForward.Name = "tsbNavForward";
            this.tsbNavForward.Size = new System.Drawing.Size(23, 22);
            this.tsbNavForward.Text = "toolStripButton6";
            this.tsbNavForward.Click += new System.EventHandler(this.tsbNavForward_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "tsbExit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BirdName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Behavior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(62, 101);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(180, 21);
            this.cboGender.TabIndex = 7;
            // 
            // txtBirdName
            // 
            this.txtBirdName.Location = new System.Drawing.Point(62, 67);
            this.txtBirdName.Name = "txtBirdName";
            this.txtBirdName.Size = new System.Drawing.Size(355, 20);
            this.txtBirdName.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(62, 135);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(355, 77);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.Text = "";
            // 
            // txtBehavior
            // 
            this.txtBehavior.Location = new System.Drawing.Point(62, 221);
            this.txtBehavior.Name = "txtBehavior";
            this.txtBehavior.Size = new System.Drawing.Size(355, 77);
            this.txtBehavior.TabIndex = 10;
            this.txtBehavior.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBird);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(423, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // picBird
            // 
            this.picBird.Location = new System.Drawing.Point(6, 19);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(241, 214);
            this.picBird.TabIndex = 0;
            this.picBird.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(62, 314);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // dtpTime
            // 
            this.dtpTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(291, 314);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(81, 20);
            this.dtpTime.TabIndex = 13;
            this.dtpTime.Value = new System.DateTime(2018, 1, 20, 8, 35, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time";
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(517, 315);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(75, 23);
            this.btnSetImage.TabIndex = 0;
            this.btnSetImage.Text = "Set Image";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 355);
            this.Controls.Add(this.btnSetImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBehavior);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtBirdName);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllBirdsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton tsbNavForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtBirdName;
        private System.Windows.Forms.RichTextBox txtLocation;
        private System.Windows.Forms.RichTextBox txtBehavior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}

