﻿namespace MonoGameHub.Controls
{
    partial class DownloadInstallButton
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Download and Install MonoGame";
            this.lblTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TriggerMouseCLick);
            this.lblTitle.MouseEnter += new System.EventHandler(this.TriggerMouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.TriggerMouseLeave);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(46, 31);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(319, 36);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Download the MonoGame SDK from the Official GitHub repository and run the install" +
    "er.";
            this.lblDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TriggerMouseCLick);
            this.lblDescription.MouseEnter += new System.EventHandler(this.TriggerMouseEnter);
            this.lblDescription.MouseLeave += new System.EventHandler(this.TriggerMouseLeave);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 68);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(457, 10);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TriggerMouseCLick);
            this.progressBar.MouseEnter += new System.EventHandler(this.TriggerMouseEnter);
            this.progressBar.MouseLeave += new System.EventHandler(this.TriggerMouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MonoGameHub.Properties.Resources.LogoOnly_32px;
            this.pictureBox.Location = new System.Drawing.Point(6, 6);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(32, 32);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TriggerMouseCLick);
            this.pictureBox.MouseEnter += new System.EventHandler(this.TriggerMouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.TriggerMouseLeave);
            // 
            // DownloadInstallButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(470, 81);
            this.MinimumSize = new System.Drawing.Size(470, 81);
            this.Name = "DownloadInstallButton";
            this.Size = new System.Drawing.Size(470, 81);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
