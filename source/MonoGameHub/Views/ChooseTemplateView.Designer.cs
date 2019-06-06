namespace MonoGameHub.Views
{
    partial class ChooseTemplateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTemplateView));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlTemplateList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWindowsProject = new MonoGameHub.Controls.ButtonWithContent();
            this.btnAndroid = new MonoGameHub.Controls.ButtonWithContent();
            this.btnCrossPlatform = new MonoGameHub.Controls.ButtonWithContent();
            this.btnIos = new MonoGameHub.Controls.ButtonWithContent();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlTemplateList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 53);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(343, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Choose MonoGame Template";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(750, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.pnlSpacer);
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(30, 618);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(964, 35);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpacer.Location = new System.Drawing.Point(850, 0);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(14, 35);
            this.pnlSpacer.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(864, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // pnlTemplateList
            // 
            this.pnlTemplateList.Controls.Add(this.btnWindowsProject);
            this.pnlTemplateList.Controls.Add(this.btnAndroid);
            this.pnlTemplateList.Controls.Add(this.btnCrossPlatform);
            this.pnlTemplateList.Controls.Add(this.btnIos);
            this.pnlTemplateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTemplateList.Location = new System.Drawing.Point(30, 53);
            this.pnlTemplateList.Name = "pnlTemplateList";
            this.pnlTemplateList.Size = new System.Drawing.Size(964, 565);
            this.pnlTemplateList.TabIndex = 0;
            // 
            // btnWindowsProject
            // 
            this.btnWindowsProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnWindowsProject.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowsProject.DescriptionForecolor = System.Drawing.Color.White;
            this.btnWindowsProject.DescriptionText = "A Monogame project for the Windows dekstop using DirectX";
            this.btnWindowsProject.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowsProject.ForeColor = System.Drawing.Color.White;
            this.btnWindowsProject.IsSelected = false;
            this.btnWindowsProject.Location = new System.Drawing.Point(6, 6);
            this.btnWindowsProject.Logo = ((System.Drawing.Image)(resources.GetObject("btnWindowsProject.Logo")));
            this.btnWindowsProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnWindowsProject.Name = "btnWindowsProject";
            this.btnWindowsProject.Size = new System.Drawing.Size(468, 92);
            this.btnWindowsProject.TabIndex = 0;
            this.btnWindowsProject.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowsProject.TitleForecolor = System.Drawing.Color.White;
            this.btnWindowsProject.TitleText = "MonoGame Windows Project";
            this.btnWindowsProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnWindowsProject_MouseClick);
            this.btnWindowsProject.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnWindowsProject_MouseDoubleClick);
            this.btnWindowsProject.MouseEnter += new System.EventHandler(this.TemplateButton_MouseEnter);
            this.btnWindowsProject.MouseLeave += new System.EventHandler(this.TemplateButton_MouseLeave);
            // 
            // btnAndroid
            // 
            this.btnAndroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnAndroid.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndroid.DescriptionForecolor = System.Drawing.Color.White;
            this.btnAndroid.DescriptionText = "A MonoGame game project  for Android  which requires \"Mono for Android\"  Xamarin";
            this.btnAndroid.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndroid.ForeColor = System.Drawing.Color.White;
            this.btnAndroid.IsSelected = false;
            this.btnAndroid.Location = new System.Drawing.Point(486, 6);
            this.btnAndroid.Logo = ((System.Drawing.Image)(resources.GetObject("btnAndroid.Logo")));
            this.btnAndroid.Margin = new System.Windows.Forms.Padding(6);
            this.btnAndroid.Name = "btnAndroid";
            this.btnAndroid.Size = new System.Drawing.Size(468, 92);
            this.btnAndroid.TabIndex = 1;
            this.btnAndroid.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndroid.TitleForecolor = System.Drawing.Color.White;
            this.btnAndroid.TitleText = "MonoGame Android Project";
            this.btnAndroid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAndroid_MouseClick);
            this.btnAndroid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnAndroid_MouseDoubleClick);
            this.btnAndroid.MouseEnter += new System.EventHandler(this.TemplateButton_MouseEnter);
            this.btnAndroid.MouseLeave += new System.EventHandler(this.TemplateButton_MouseLeave);
            // 
            // btnCrossPlatform
            // 
            this.btnCrossPlatform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnCrossPlatform.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrossPlatform.DescriptionForecolor = System.Drawing.Color.White;
            this.btnCrossPlatform.DescriptionText = "A MonoGame game project for Windows, Mac, and Linux using OpenGL";
            this.btnCrossPlatform.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrossPlatform.ForeColor = System.Drawing.Color.White;
            this.btnCrossPlatform.IsSelected = false;
            this.btnCrossPlatform.Location = new System.Drawing.Point(6, 110);
            this.btnCrossPlatform.Logo = ((System.Drawing.Image)(resources.GetObject("btnCrossPlatform.Logo")));
            this.btnCrossPlatform.Margin = new System.Windows.Forms.Padding(6);
            this.btnCrossPlatform.Name = "btnCrossPlatform";
            this.btnCrossPlatform.Size = new System.Drawing.Size(468, 92);
            this.btnCrossPlatform.TabIndex = 2;
            this.btnCrossPlatform.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrossPlatform.TitleForecolor = System.Drawing.Color.White;
            this.btnCrossPlatform.TitleText = "MonoGame Cross Platform Desktop Project";
            this.btnCrossPlatform.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnCrossPlatform_MouseClick);
            this.btnCrossPlatform.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnCrossPlatform_MouseDoubleClick);
            this.btnCrossPlatform.MouseEnter += new System.EventHandler(this.TemplateButton_MouseEnter);
            this.btnCrossPlatform.MouseLeave += new System.EventHandler(this.TemplateButton_MouseLeave);
            // 
            // btnIos
            // 
            this.btnIos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btnIos.DescriptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIos.DescriptionForecolor = System.Drawing.Color.White;
            this.btnIos.DescriptionText = "A MonoGame game project for iOS which requires Xamarin.iOS";
            this.btnIos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIos.ForeColor = System.Drawing.Color.White;
            this.btnIos.IsSelected = false;
            this.btnIos.Location = new System.Drawing.Point(486, 110);
            this.btnIos.Logo = ((System.Drawing.Image)(resources.GetObject("btnIos.Logo")));
            this.btnIos.Margin = new System.Windows.Forms.Padding(6);
            this.btnIos.Name = "btnIos";
            this.btnIos.Size = new System.Drawing.Size(468, 92);
            this.btnIos.TabIndex = 3;
            this.btnIos.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIos.TitleForecolor = System.Drawing.Color.White;
            this.btnIos.TitleText = "MonoGame iOS Project";
            this.btnIos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnIos_MouseClick);
            this.btnIos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnIos_MouseDoubleClick);
            this.btnIos.MouseEnter += new System.EventHandler(this.TemplateButton_MouseEnter);
            this.btnIos.MouseLeave += new System.EventHandler(this.TemplateButton_MouseLeave);
            // 
            // ChooseTemplateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnlTemplateList);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1024, 683);
            this.MinimumSize = new System.Drawing.Size(1024, 683);
            this.Name = "ChooseTemplateView";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.Size = new System.Drawing.Size(1024, 683);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlTemplateList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel pnlTemplateList;
        private Controls.ButtonWithContent btnWindowsProject;
        private Controls.ButtonWithContent btnAndroid;
        private Controls.ButtonWithContent btnCrossPlatform;
        private Controls.ButtonWithContent btnIos;
    }
}
