namespace MonoGameHub.Views
{
    partial class HomeView
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
            this.pnlLogoWrapper = new System.Windows.Forms.Panel();
            this.lblHub = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlProjectList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProjects = new System.Windows.Forms.Label();
            this.pnlGettingStartedList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewProject = new MonoGameHub.Controls.ButtonWithContent();
            this.btnOpenProject = new MonoGameHub.Controls.ButtonWithContent();
            this.btnLearn = new MonoGameHub.Controls.ButtonWithContent();
            this.lblGettingStarted = new System.Windows.Forms.Label();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlLogoWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlGettingStartedList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogoWrapper
            // 
            this.pnlLogoWrapper.Controls.Add(this.lblHub);
            this.pnlLogoWrapper.Controls.Add(this.pcbLogo);
            this.pnlLogoWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoWrapper.Location = new System.Drawing.Point(30, 0);
            this.pnlLogoWrapper.Name = "pnlLogoWrapper";
            this.pnlLogoWrapper.Size = new System.Drawing.Size(964, 53);
            this.pnlLogoWrapper.TabIndex = 1;
            // 
            // lblHub
            // 
            this.lblHub.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHub.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHub.ForeColor = System.Drawing.Color.White;
            this.lblHub.Location = new System.Drawing.Point(256, 0);
            this.lblHub.Name = "lblHub";
            this.lblHub.Size = new System.Drawing.Size(86, 53);
            this.lblHub.TabIndex = 1;
            this.lblHub.Text = "Hub";
            this.lblHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbLogo.Image = global::MonoGameHub.Properties.Resources.HorizontalLogo_512px;
            this.pcbLogo.Location = new System.Drawing.Point(0, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(256, 53);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(30, 73);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlProjectList);
            this.splitContainer1.Panel1.Controls.Add(this.lblProjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlGettingStartedList);
            this.splitContainer1.Panel2.Controls.Add(this.lblGettingStarted);
            this.splitContainer1.Size = new System.Drawing.Size(964, 580);
            this.splitContainer1.SplitterDistance = 482;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlProjectList
            // 
            this.pnlProjectList.AutoScroll = true;
            this.pnlProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlProjectList.Location = new System.Drawing.Point(0, 40);
            this.pnlProjectList.Name = "pnlProjectList";
            this.pnlProjectList.Size = new System.Drawing.Size(482, 540);
            this.pnlProjectList.TabIndex = 1;
            this.pnlProjectList.WrapContents = false;
            // 
            // lblProjects
            // 
            this.lblProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjects.ForeColor = System.Drawing.Color.White;
            this.lblProjects.Location = new System.Drawing.Point(0, 0);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(482, 40);
            this.lblProjects.TabIndex = 0;
            this.lblProjects.Text = "Projects";
            this.lblProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGettingStartedList
            // 
            this.pnlGettingStartedList.Controls.Add(this.btnNewProject);
            this.pnlGettingStartedList.Controls.Add(this.btnOpenProject);
            this.pnlGettingStartedList.Controls.Add(this.btnLearn);
            this.pnlGettingStartedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGettingStartedList.Location = new System.Drawing.Point(0, 40);
            this.pnlGettingStartedList.Name = "pnlGettingStartedList";
            this.pnlGettingStartedList.Size = new System.Drawing.Size(481, 540);
            this.pnlGettingStartedList.TabIndex = 2;
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnNewProject.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.DescriptionForecolor = System.Drawing.Color.White;
            this.btnNewProject.DescriptionText = "Create a new MonoGame project based on one of the MonoGame templates";
            this.btnNewProject.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.IsSelected = false;
            this.btnNewProject.Location = new System.Drawing.Point(6, 6);
            this.btnNewProject.Logo = global::MonoGameHub.Properties.Resources.file_document_box_plus_outline;
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(468, 75);
            this.btnNewProject.TabIndex = 3;
            this.btnNewProject.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.TitleForecolor = System.Drawing.Color.White;
            this.btnNewProject.TitleText = "New MonoGame Project";
            this.btnNewProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnNewProject_MouseClick);
            this.btnNewProject.MouseEnter += new System.EventHandler(this.GettingStartedButton_MouseEnter);
            this.btnNewProject.MouseLeave += new System.EventHandler(this.GettingStartedButton_MouseLeave);
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnOpenProject.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.DescriptionForecolor = System.Drawing.Color.White;
            this.btnOpenProject.DescriptionText = "Open a MonoGame project that\'s not listed in your projects list";
            this.btnOpenProject.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.ForeColor = System.Drawing.Color.White;
            this.btnOpenProject.IsSelected = false;
            this.btnOpenProject.Location = new System.Drawing.Point(6, 93);
            this.btnOpenProject.Logo = global::MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(468, 75);
            this.btnOpenProject.TabIndex = 4;
            this.btnOpenProject.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.TitleForecolor = System.Drawing.Color.White;
            this.btnOpenProject.TitleText = "Open MonoGame Project";
            this.btnOpenProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnOpenProject_MouseClick);
            this.btnOpenProject.MouseEnter += new System.EventHandler(this.GettingStartedButton_MouseEnter);
            this.btnOpenProject.MouseLeave += new System.EventHandler(this.GettingStartedButton_MouseLeave);
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnLearn.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.DescriptionForecolor = System.Drawing.Color.White;
            this.btnLearn.DescriptionText = "Learn to make games using the MonoGame framework.";
            this.btnLearn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.ForeColor = System.Drawing.Color.White;
            this.btnLearn.IsSelected = false;
            this.btnLearn.Location = new System.Drawing.Point(6, 180);
            this.btnLearn.Logo = global::MonoGameHub.Properties.Resources.lightbulb_on_outline;
            this.btnLearn.Margin = new System.Windows.Forms.Padding(6);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(468, 75);
            this.btnLearn.TabIndex = 5;
            this.btnLearn.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.TitleForecolor = System.Drawing.Color.White;
            this.btnLearn.TitleText = "Learn MonoGame";
            this.btnLearn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnLearn_MouseClick);
            this.btnLearn.MouseEnter += new System.EventHandler(this.GettingStartedButton_MouseEnter);
            this.btnLearn.MouseLeave += new System.EventHandler(this.GettingStartedButton_MouseLeave);
            // 
            // lblGettingStarted
            // 
            this.lblGettingStarted.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGettingStarted.ForeColor = System.Drawing.Color.White;
            this.lblGettingStarted.Location = new System.Drawing.Point(0, 0);
            this.lblGettingStarted.Name = "lblGettingStarted";
            this.lblGettingStarted.Size = new System.Drawing.Size(481, 40);
            this.lblGettingStarted.TabIndex = 1;
            this.lblGettingStarted.Text = "Getting Started";
            this.lblGettingStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(30, 53);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(964, 20);
            this.pnlSpacer.TabIndex = 0;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlLogoWrapper);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1024, 683);
            this.MinimumSize = new System.Drawing.Size(1024, 683);
            this.Name = "HomeView";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.Size = new System.Drawing.Size(1024, 683);
            this.pnlLogoWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlGettingStartedList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel pnlLogoWrapper;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Label lblGettingStarted;
        private Controls.ButtonWithContent btnLearn;
        private Controls.ButtonWithContent btnOpenProject;
        private Controls.ButtonWithContent btnNewProject;
        private System.Windows.Forms.FlowLayoutPanel pnlProjectList;
        private System.Windows.Forms.Label lblHub;
        private System.Windows.Forms.FlowLayoutPanel pnlGettingStartedList;
    }
}
