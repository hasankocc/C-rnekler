namespace SurvivalSimulation
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.rtxtSimulationDisplay = new System.Windows.Forms.RichTextBox();
            this.lblHeroStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Add a New Simulation File";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(148, 50);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(119, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(295, 50);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(128, 23);
            this.btnSimulate.TabIndex = 2;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // rtxtSimulationDisplay
            // 
            this.rtxtSimulationDisplay.Location = new System.Drawing.Point(15, 104);
            this.rtxtSimulationDisplay.Name = "rtxtSimulationDisplay";
            this.rtxtSimulationDisplay.ReadOnly = true;
            this.rtxtSimulationDisplay.Size = new System.Drawing.Size(408, 438);
            this.rtxtSimulationDisplay.TabIndex = 3;
            this.rtxtSimulationDisplay.Text = "";
            // 
            // lblHeroStatus
            // 
            this.lblHeroStatus.AutoSize = true;
            this.lblHeroStatus.Location = new System.Drawing.Point(12, 88);
            this.lblHeroStatus.Name = "lblHeroStatus";
            this.lblHeroStatus.Size = new System.Drawing.Size(30, 13);
            this.lblHeroStatus.TabIndex = 4;
            this.lblHeroStatus.Text = "Hero";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 554);
            this.Controls.Add(this.lblHeroStatus);
            this.Controls.Add(this.rtxtSimulationDisplay);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Survival Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.RichTextBox rtxtSimulationDisplay;
        private System.Windows.Forms.Label lblHeroStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

