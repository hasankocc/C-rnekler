namespace Import_Excel
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
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.dgvPrmMaster = new System.Windows.Forms.DataGridView();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrmMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(378, 24);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(100, 38);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // dgvPrmMaster
            // 
            this.dgvPrmMaster.AllowUserToAddRows = false;
            this.dgvPrmMaster.AllowUserToDeleteRows = false;
            this.dgvPrmMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrmMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrmMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPrmMaster.Location = new System.Drawing.Point(0, 108);
            this.dgvPrmMaster.MultiSelect = false;
            this.dgvPrmMaster.Name = "dgvPrmMaster";
            this.dgvPrmMaster.ReadOnly = true;
            this.dgvPrmMaster.RowTemplate.Height = 24;
            this.dgvPrmMaster.Size = new System.Drawing.Size(600, 427);
            this.dgvPrmMaster.TabIndex = 1;
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Location = new System.Drawing.Point(12, 24);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(89, 38);
            this.btnFileUpload.TabIndex = 2;
            this.btnFileUpload.Text = "Dosya Seç";
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(484, 24);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(104, 38);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 535);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnFileUpload);
            this.Controls.Add(this.dgvPrmMaster);
            this.Controls.Add(this.btnImportExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrmMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.DataGridView dgvPrmMaster;
        private System.Windows.Forms.Button btnFileUpload;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label lblStatus;
    }
}

