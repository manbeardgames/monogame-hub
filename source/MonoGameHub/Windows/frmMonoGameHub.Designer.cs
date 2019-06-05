namespace MonoGameHub.Windows
{
    partial class frmMonoGameHub
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
            this.lblInstallMessage = new System.Windows.Forms.Label();
            this.btnInstallBegin = new System.Windows.Forms.Button();
            this.progressBarDownloading = new System.Windows.Forms.ProgressBar();
            this.pnlWindowTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContentRegion = new System.Windows.Forms.Panel();
            this.pnlWindowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstallMessage
            // 
            this.lblInstallMessage.Location = new System.Drawing.Point(68, 320);
            this.lblInstallMessage.Name = "lblInstallMessage";
            this.lblInstallMessage.Size = new System.Drawing.Size(662, 90);
            this.lblInstallMessage.TabIndex = 0;
            this.lblInstallMessage.Text = "To install the MonoGame SDK, click the Download and Install button below";
            this.lblInstallMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInstallBegin
            // 
            this.btnInstallBegin.Location = new System.Drawing.Point(253, 292);
            this.btnInstallBegin.Name = "btnInstallBegin";
            this.btnInstallBegin.Size = new System.Drawing.Size(256, 46);
            this.btnInstallBegin.TabIndex = 1;
            this.btnInstallBegin.Text = "Download and Install";
            this.btnInstallBegin.UseVisualStyleBackColor = true;
            // 
            // progressBarDownloading
            // 
            this.progressBarDownloading.Location = new System.Drawing.Point(253, 263);
            this.progressBarDownloading.Name = "progressBarDownloading";
            this.progressBarDownloading.Size = new System.Drawing.Size(256, 23);
            this.progressBarDownloading.TabIndex = 2;
            // 
            // pnlWindowTitle
            // 
            this.pnlWindowTitle.Controls.Add(this.btnClose);
            this.pnlWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowTitle.Name = "pnlWindowTitle";
            this.pnlWindowTitle.Size = new System.Drawing.Size(1024, 27);
            this.pnlWindowTitle.TabIndex = 1;
            this.pnlWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.pnlWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            this.pnlWindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(47)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::MonoGameHub.Properties.Resources.close_white;
            this.btnClose.Location = new System.Drawing.Point(987, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlContentRegion
            // 
            this.pnlContentRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentRegion.Location = new System.Drawing.Point(0, 27);
            this.pnlContentRegion.Name = "pnlContentRegion";
            this.pnlContentRegion.Size = new System.Drawing.Size(1024, 683);
            this.pnlContentRegion.TabIndex = 2;
            // 
            // frmMonoGameHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1024, 710);
            this.Controls.Add(this.pnlContentRegion);
            this.Controls.Add(this.pnlWindowTitle);
            this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1024, 710);
            this.MinimumSize = new System.Drawing.Size(1024, 710);
            this.Name = "frmMonoGameHub";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonoGame Hub";
            this.Load += new System.EventHandler(this.frmMonoGameHub_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseUp);
            this.pnlWindowTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInstallBegin;
        private System.Windows.Forms.Label lblInstallMessage;
        private System.Windows.Forms.ProgressBar progressBarDownloading;
        private System.Windows.Forms.Panel pnlWindowTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContentRegion;
    }
}

