namespace MonoGameHub.Views
{
    partial class ConfigureProjectView
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.pnlProjectName = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLocation = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.pnlSolutionName = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.txtSolutionName = new System.Windows.Forms.TextBox();
            this.chkSameName = new System.Windows.Forms.CheckBox();
            this.chkSameFolder = new System.Windows.Forms.CheckBox();
            this.pnlLocationInner = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlProjectName.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlSolutionName.SuspendLayout();
            this.pnlLocationInner.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(344, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Configure Your Project";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 53);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(3, 0);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(391, 16);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProjectName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.ForeColor = System.Drawing.Color.White;
            this.txtProjectName.Location = new System.Drawing.Point(3, 24);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(391, 27);
            this.txtProjectName.TabIndex = 1;
            // 
            // pnlProjectName
            // 
            this.pnlProjectName.Controls.Add(this.lblProjectName);
            this.pnlProjectName.Controls.Add(this.txtProjectName);
            this.pnlProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlProjectName.Location = new System.Drawing.Point(30, 53);
            this.pnlProjectName.Name = "pnlProjectName";
            this.pnlProjectName.Size = new System.Drawing.Size(964, 71);
            this.pnlProjectName.TabIndex = 2;
            // 
            // pnlLocation
            // 
            this.pnlLocation.Controls.Add(this.lblLocation);
            this.pnlLocation.Controls.Add(this.pnlLocationInner);
            this.pnlLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlLocation.Location = new System.Drawing.Point(30, 124);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(964, 71);
            this.pnlLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(3, 0);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(873, 16);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(3, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(391, 27);
            this.txtLocation.TabIndex = 1;
            // 
            // pnlSolutionName
            // 
            this.pnlSolutionName.Controls.Add(this.lblSolutionName);
            this.pnlSolutionName.Controls.Add(this.txtSolutionName);
            this.pnlSolutionName.Controls.Add(this.chkSameName);
            this.pnlSolutionName.Controls.Add(this.chkSameFolder);
            this.pnlSolutionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolutionName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlSolutionName.Location = new System.Drawing.Point(30, 195);
            this.pnlSolutionName.Name = "pnlSolutionName";
            this.pnlSolutionName.Size = new System.Drawing.Size(964, 124);
            this.pnlSolutionName.TabIndex = 4;
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolutionName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionName.Location = new System.Drawing.Point(3, 0);
            this.lblSolutionName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(391, 16);
            this.lblSolutionName.TabIndex = 0;
            this.lblSolutionName.Text = "SolutionName";
            // 
            // txtSolutionName
            // 
            this.txtSolutionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtSolutionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSolutionName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSolutionName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolutionName.ForeColor = System.Drawing.Color.White;
            this.txtSolutionName.Location = new System.Drawing.Point(3, 24);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.Size = new System.Drawing.Size(391, 27);
            this.txtSolutionName.TabIndex = 1;
            // 
            // chkSameName
            // 
            this.chkSameName.AutoSize = true;
            this.chkSameName.Checked = true;
            this.chkSameName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSameName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSameName.Location = new System.Drawing.Point(3, 57);
            this.chkSameName.Name = "chkSameName";
            this.chkSameName.Size = new System.Drawing.Size(271, 20);
            this.chkSameName.TabIndex = 2;
            this.chkSameName.Text = "Solution and project share the same name";
            this.chkSameName.UseVisualStyleBackColor = true;
            // 
            // chkSameFolder
            // 
            this.chkSameFolder.AutoSize = true;
            this.chkSameFolder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSameFolder.Location = new System.Drawing.Point(3, 83);
            this.chkSameFolder.Name = "chkSameFolder";
            this.chkSameFolder.Size = new System.Drawing.Size(299, 20);
            this.chkSameFolder.TabIndex = 3;
            this.chkSameFolder.Text = "Place solution and project in the same directory";
            this.chkSameFolder.UseVisualStyleBackColor = true;
            // 
            // pnlLocationInner
            // 
            this.pnlLocationInner.Controls.Add(this.txtLocation);
            this.pnlLocationInner.Controls.Add(this.btnBrowse);
            this.pnlLocationInner.Location = new System.Drawing.Point(3, 24);
            this.pnlLocationInner.Name = "pnlLocationInner";
            this.pnlLocationInner.Size = new System.Drawing.Size(873, 36);
            this.pnlLocationInner.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(400, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(37, 27);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnBack);
            this.pnlFooter.Controls.Add(this.pnlSpacer);
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(30, 618);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(964, 35);
            this.pnlFooter.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(750, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnBack_MouseClick);
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
            // 
            // ConfigureProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSolutionName);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlProjectName);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1024, 683);
            this.MinimumSize = new System.Drawing.Size(1024, 683);
            this.Name = "ConfigureProjectView";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.Size = new System.Drawing.Size(1024, 683);
            this.pnlHeader.ResumeLayout(false);
            this.pnlProjectName.ResumeLayout(false);
            this.pnlProjectName.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlSolutionName.ResumeLayout(false);
            this.pnlSolutionName.PerformLayout();
            this.pnlLocationInner.ResumeLayout(false);
            this.pnlLocationInner.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.FlowLayoutPanel pnlProjectName;
        private System.Windows.Forms.FlowLayoutPanel pnlLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.FlowLayoutPanel pnlSolutionName;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.TextBox txtSolutionName;
        private System.Windows.Forms.CheckBox chkSameName;
        private System.Windows.Forms.CheckBox chkSameFolder;
        private System.Windows.Forms.FlowLayoutPanel pnlLocationInner;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Button btnNext;
    }
}
