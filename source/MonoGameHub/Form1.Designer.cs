namespace MonoGameHub
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHub = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpNew = new System.Windows.Forms.TabPage();
            this.btnNewCancel = new System.Windows.Forms.Button();
            this.btnNewCreate = new System.Windows.Forms.Button();
            this.pnlNewInfo2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNewMonoGameTemplate = new System.Windows.Forms.Label();
            this.pnlNewInfo1 = new System.Windows.Forms.Panel();
            this.lblNewSolutionName = new System.Windows.Forms.Label();
            this.chkNewSolutionSameName = new System.Windows.Forms.CheckBox();
            this.txtNewSolutionName = new System.Windows.Forms.TextBox();
            this.lblNewProjectName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbpInstall = new System.Windows.Forms.TabPage();
            this.installVisualStudioControl2 = new MonoGameHub.Controls.InstallVisualStudioControl();
            this.lblInstallHeader = new System.Windows.Forms.Label();
            this.tbpProjects = new System.Windows.Forms.TabPage();
            this.lblInstallMessage = new System.Windows.Forms.Label();
            this.btnInstallBegin = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripDivider = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMonoGameDetected = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarDownloading = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnNavigation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpNew.SuspendLayout();
            this.pnlNewInfo2.SuspendLayout();
            this.pnlNewInfo1.SuspendLayout();
            this.tbpInstall.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblHub);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(980, 84);
            this.pnlTop.TabIndex = 0;
            // 
            // lblHub
            // 
            this.lblHub.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHub.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHub.Location = new System.Drawing.Point(318, 0);
            this.lblHub.Name = "lblHub";
            this.lblHub.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblHub.Size = new System.Drawing.Size(136, 82);
            this.lblHub.TabIndex = 1;
            this.lblHub.Text = "Hub";
            this.lblHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MonoGameHub.Properties.Resources.monogame_logo_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnNavigation
            // 
            this.pnNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNavigation.Controls.Add(this.btnInstall);
            this.pnNavigation.Controls.Add(this.btnNew);
            this.pnNavigation.Controls.Add(this.btnProjects);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavigation.Location = new System.Drawing.Point(0, 84);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(200, 454);
            this.pnNavigation.TabIndex = 1;
            // 
            // btnInstall
            // 
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Location = new System.Drawing.Point(0, 110);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(198, 55);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "Install MonoGame";
            this.btnInstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(0, 55);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(198, 55);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Project";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Location = new System.Drawing.Point(0, 0);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(198, 55);
            this.btnProjects.TabIndex = 0;
            this.btnProjects.Text = "Projects";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbpNew);
            this.tabControl1.Controls.Add(this.tbpInstall);
            this.tabControl1.Controls.Add(this.tbpProjects);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 452);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tbpNew
            // 
            this.tbpNew.Controls.Add(this.btnNewCancel);
            this.tbpNew.Controls.Add(this.btnNewCreate);
            this.tbpNew.Controls.Add(this.pnlNewInfo2);
            this.tbpNew.Controls.Add(this.pnlNewInfo1);
            this.tbpNew.Location = new System.Drawing.Point(4, 5);
            this.tbpNew.Name = "tbpNew";
            this.tbpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNew.Size = new System.Drawing.Size(770, 443);
            this.tbpNew.TabIndex = 0;
            this.tbpNew.Text = "New";
            this.tbpNew.UseVisualStyleBackColor = true;
            // 
            // btnNewCancel
            // 
            this.btnNewCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCancel.Location = new System.Drawing.Point(6, 387);
            this.btnNewCancel.Name = "btnNewCancel";
            this.btnNewCancel.Size = new System.Drawing.Size(155, 43);
            this.btnNewCancel.TabIndex = 3;
            this.btnNewCancel.Text = "Cancel";
            this.btnNewCancel.UseVisualStyleBackColor = true;
            // 
            // btnNewCreate
            // 
            this.btnNewCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCreate.Location = new System.Drawing.Point(609, 387);
            this.btnNewCreate.Name = "btnNewCreate";
            this.btnNewCreate.Size = new System.Drawing.Size(155, 43);
            this.btnNewCreate.TabIndex = 2;
            this.btnNewCreate.Text = "Create";
            this.btnNewCreate.UseVisualStyleBackColor = true;
            // 
            // pnlNewInfo2
            // 
            this.pnlNewInfo2.Controls.Add(this.comboBox1);
            this.pnlNewInfo2.Controls.Add(this.lblNewMonoGameTemplate);
            this.pnlNewInfo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewInfo2.Location = new System.Drawing.Point(3, 120);
            this.pnlNewInfo2.Name = "pnlNewInfo2";
            this.pnlNewInfo2.Size = new System.Drawing.Size(764, 100);
            this.pnlNewInfo2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // lblNewMonoGameTemplate
            // 
            this.lblNewMonoGameTemplate.AutoSize = true;
            this.lblNewMonoGameTemplate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMonoGameTemplate.Location = new System.Drawing.Point(33, 14);
            this.lblNewMonoGameTemplate.Name = "lblNewMonoGameTemplate";
            this.lblNewMonoGameTemplate.Size = new System.Drawing.Size(235, 17);
            this.lblNewMonoGameTemplate.TabIndex = 2;
            this.lblNewMonoGameTemplate.Text = "Choose MonoGame Project Template";
            // 
            // pnlNewInfo1
            // 
            this.pnlNewInfo1.Controls.Add(this.lblNewSolutionName);
            this.pnlNewInfo1.Controls.Add(this.chkNewSolutionSameName);
            this.pnlNewInfo1.Controls.Add(this.txtNewSolutionName);
            this.pnlNewInfo1.Controls.Add(this.lblNewProjectName);
            this.pnlNewInfo1.Controls.Add(this.textBox1);
            this.pnlNewInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewInfo1.Location = new System.Drawing.Point(3, 3);
            this.pnlNewInfo1.Name = "pnlNewInfo1";
            this.pnlNewInfo1.Size = new System.Drawing.Size(764, 117);
            this.pnlNewInfo1.TabIndex = 0;
            // 
            // lblNewSolutionName
            // 
            this.lblNewSolutionName.AutoSize = true;
            this.lblNewSolutionName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSolutionName.Location = new System.Drawing.Point(363, 19);
            this.lblNewSolutionName.Name = "lblNewSolutionName";
            this.lblNewSolutionName.Size = new System.Drawing.Size(96, 17);
            this.lblNewSolutionName.TabIndex = 3;
            this.lblNewSolutionName.Text = "Solution Name";
            // 
            // chkNewSolutionSameName
            // 
            this.chkNewSolutionSameName.AutoSize = true;
            this.chkNewSolutionSameName.Checked = true;
            this.chkNewSolutionSameName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewSolutionSameName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewSolutionSameName.Location = new System.Drawing.Point(366, 78);
            this.chkNewSolutionSameName.Name = "chkNewSolutionSameName";
            this.chkNewSolutionSameName.Size = new System.Drawing.Size(210, 21);
            this.chkNewSolutionSameName.TabIndex = 2;
            this.chkNewSolutionSameName.Text = "Use Same Name For Solution?";
            this.chkNewSolutionSameName.UseVisualStyleBackColor = true;
            // 
            // txtNewSolutionName
            // 
            this.txtNewSolutionName.Enabled = false;
            this.txtNewSolutionName.Location = new System.Drawing.Point(366, 39);
            this.txtNewSolutionName.Name = "txtNewSolutionName";
            this.txtNewSolutionName.Size = new System.Drawing.Size(329, 33);
            this.txtNewSolutionName.TabIndex = 2;
            // 
            // lblNewProjectName
            // 
            this.lblNewProjectName.AutoSize = true;
            this.lblNewProjectName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProjectName.Location = new System.Drawing.Point(33, 19);
            this.lblNewProjectName.Name = "lblNewProjectName";
            this.lblNewProjectName.Size = new System.Drawing.Size(91, 17);
            this.lblNewProjectName.TabIndex = 1;
            this.lblNewProjectName.Text = "Project Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 33);
            this.textBox1.TabIndex = 0;
            // 
            // tbpInstall
            // 
            this.tbpInstall.Controls.Add(this.installVisualStudioControl2);
            this.tbpInstall.Controls.Add(this.lblInstallHeader);
            this.tbpInstall.Location = new System.Drawing.Point(4, 5);
            this.tbpInstall.Name = "tbpInstall";
            this.tbpInstall.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInstall.Size = new System.Drawing.Size(770, 443);
            this.tbpInstall.TabIndex = 1;
            this.tbpInstall.Text = "Install";
            this.tbpInstall.UseVisualStyleBackColor = true;
            // 
            // installVisualStudioControl2
            // 
            this.installVisualStudioControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.installVisualStudioControl2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installVisualStudioControl2.Location = new System.Drawing.Point(3, 51);
            this.installVisualStudioControl2.MinimumSize = new System.Drawing.Size(2, 80);
            this.installVisualStudioControl2.Name = "installVisualStudioControl2";
            this.installVisualStudioControl2.Size = new System.Drawing.Size(764, 80);
            this.installVisualStudioControl2.TabIndex = 0;
            this.installVisualStudioControl2.OnVerified += new System.EventHandler(this.installVisualStudioControl2_OnVerified);
            // 
            // lblInstallHeader
            // 
            this.lblInstallHeader.AutoSize = true;
            this.lblInstallHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstallHeader.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallHeader.Location = new System.Drawing.Point(3, 3);
            this.lblInstallHeader.Name = "lblInstallHeader";
            this.lblInstallHeader.Size = new System.Drawing.Size(393, 48);
            this.lblInstallHeader.TabIndex = 3;
            this.lblInstallHeader.Text = "Installing MonoGame";
            // 
            // tbpProjects
            // 
            this.tbpProjects.Location = new System.Drawing.Point(4, 5);
            this.tbpProjects.Name = "tbpProjects";
            this.tbpProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProjects.Size = new System.Drawing.Size(770, 443);
            this.tbpProjects.TabIndex = 2;
            this.tbpProjects.Text = "Projects";
            this.tbpProjects.UseVisualStyleBackColor = true;
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
            this.btnInstallBegin.Click += new System.EventHandler(this.btnInstallBegin_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusStripDivider,
            this.lblMonoGameDetected});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(980, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(200, 17);
            this.statusLabel.Text = " ";
            // 
            // statusStripDivider
            // 
            this.statusStripDivider.Name = "statusStripDivider";
            this.statusStripDivider.Size = new System.Drawing.Size(580, 17);
            this.statusStripDivider.Spring = true;
            // 
            // lblMonoGameDetected
            // 
            this.lblMonoGameDetected.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonoGameDetected.Name = "lblMonoGameDetected";
            this.lblMonoGameDetected.Size = new System.Drawing.Size(185, 17);
            this.lblMonoGameDetected.Text = "MonoGame Version Detected";
            // 
            // progressBarDownloading
            // 
            this.progressBarDownloading.Location = new System.Drawing.Point(253, 263);
            this.progressBarDownloading.Name = "progressBarDownloading";
            this.progressBarDownloading.Size = new System.Drawing.Size(256, 23);
            this.progressBarDownloading.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 454);
            this.panel1.TabIndex = 4;
            // 
            // frmMonoGameHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMonoGameHub";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMonoGameHub_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnNavigation.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpNew.ResumeLayout(false);
            this.pnlNewInfo2.ResumeLayout(false);
            this.pnlNewInfo2.PerformLayout();
            this.pnlNewInfo1.ResumeLayout(false);
            this.pnlNewInfo1.PerformLayout();
            this.tbpInstall.ResumeLayout(false);
            this.tbpInstall.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpNew;
        private System.Windows.Forms.TabPage tbpInstall;
        private System.Windows.Forms.TabPage tbpProjects;
        private System.Windows.Forms.Button btnNewCancel;
        private System.Windows.Forms.Button btnNewCreate;
        private System.Windows.Forms.Panel pnlNewInfo2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNewMonoGameTemplate;
        private System.Windows.Forms.Panel pnlNewInfo1;
        private System.Windows.Forms.Label lblNewSolutionName;
        private System.Windows.Forms.CheckBox chkNewSolutionSameName;
        private System.Windows.Forms.TextBox txtNewSolutionName;
        private System.Windows.Forms.Label lblNewProjectName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInstallBegin;
        private System.Windows.Forms.Label lblInstallMessage;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusStripDivider;
        private System.Windows.Forms.ToolStripStatusLabel lblMonoGameDetected;
        private System.Windows.Forms.ProgressBar progressBarDownloading;
        private Controls.InstallVisualStudioControl installVisualStudioControl1;
        private Controls.InstallVisualStudioControl installVisualStudioControl2;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Label lblInstallHeader;
        private System.Windows.Forms.Panel panel1;
    }
}

