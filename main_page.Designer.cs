
namespace sign_up
{
    partial class main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEELOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINANCELOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIGNUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.sIGNUPToolStripMenuItem,
            this.cLOSEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLOYEELOGINToolStripMenuItem,
            this.fINANCELOGINToolStripMenuItem});
            this.lOGINToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // eMPLOYEELOGINToolStripMenuItem
            // 
            this.eMPLOYEELOGINToolStripMenuItem.Name = "eMPLOYEELOGINToolStripMenuItem";
            this.eMPLOYEELOGINToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.eMPLOYEELOGINToolStripMenuItem.Text = "EMPLOYEE LOGIN";
            this.eMPLOYEELOGINToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEELOGINToolStripMenuItem_Click);
            // 
            // fINANCELOGINToolStripMenuItem
            // 
            this.fINANCELOGINToolStripMenuItem.Name = "fINANCELOGINToolStripMenuItem";
            this.fINANCELOGINToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.fINANCELOGINToolStripMenuItem.Text = "FINANCE LOGIN";
            this.fINANCELOGINToolStripMenuItem.Click += new System.EventHandler(this.fINANCELOGINToolStripMenuItem_Click);
            // 
            // sIGNUPToolStripMenuItem
            // 
            this.sIGNUPToolStripMenuItem.Name = "sIGNUPToolStripMenuItem";
            this.sIGNUPToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.sIGNUPToolStripMenuItem.Text = "SIGN UP";
            this.sIGNUPToolStripMenuItem.Click += new System.EventHandler(this.sIGNUPToolStripMenuItem_Click);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.cLOSEToolStripMenuItem_Click);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 371);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_page";
            this.Text = "signup";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIGNUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEELOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINANCELOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
    }
}