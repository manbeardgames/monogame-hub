namespace MonoGameHub.Views
{
    partial class VisualStudioInstallView
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblSecondMessage = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(367, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Visual Studio 2017 Prerequsite";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1024, 53);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1024, 50);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Unable to locate installation of Visual Studio 2017 or higher.  The MonoGame Hub " +
    "requires that Visual Studio 2017 Community edition or higher be installed before" +
    " installing the MonoGame SDK.  ";
            // 
            // lblLink
            // 
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLink.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.LinkColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(0, 103);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(1024, 50);
            this.lblLink.TabIndex = 3;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Click here to be taken to the downloads page for Visual Studio where you can down" +
    "load an install it. ";
            this.lblLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // lblSecondMessage
            // 
            this.lblSecondMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondMessage.Location = new System.Drawing.Point(0, 258);
            this.lblSecondMessage.Name = "lblSecondMessage";
            this.lblSecondMessage.Size = new System.Drawing.Size(1024, 31);
            this.lblSecondMessage.TabIndex = 4;
            this.lblSecondMessage.Text = "Once you have installed Visual Studio, click the Veify button below";
            this.lblSecondMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Location = new System.Drawing.Point(432, 292);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(152, 60);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // VisualStudioInstallView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblSecondMessage);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1024, 610);
            this.MinimumSize = new System.Drawing.Size(1024, 610);
            this.Name = "VisualStudioInstallView";
            this.Size = new System.Drawing.Size(1024, 610);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label lblSecondMessage;
        private System.Windows.Forms.Button btnVerify;
    }
}
