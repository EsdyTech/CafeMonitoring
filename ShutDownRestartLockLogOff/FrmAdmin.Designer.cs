
namespace ShutDownRestartLockLogOff
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credentialsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.adminUserToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.allCredentialsToolStripMenuItem});
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            this.credentialsToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.credentialsToolStripMenuItem.Text = "Credentials";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // allCredentialsToolStripMenuItem
            // 
            this.allCredentialsToolStripMenuItem.Name = "allCredentialsToolStripMenuItem";
            this.allCredentialsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allCredentialsToolStripMenuItem.Text = "All Credentials";
            this.allCredentialsToolStripMenuItem.Click += new System.EventHandler(this.allCredentialsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // allSalesToolStripMenuItem
            // 
            this.allSalesToolStripMenuItem.Name = "allSalesToolStripMenuItem";
            this.allSalesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allSalesToolStripMenuItem.Text = "New Sale";
            this.allSalesToolStripMenuItem.Click += new System.EventHandler(this.allSalesToolStripMenuItem_Click);
            // 
            // adminUserToolStripMenuItem
            // 
            this.adminUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem});
            this.adminUserToolStripMenuItem.Name = "adminUserToolStripMenuItem";
            this.adminUserToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.adminUserToolStripMenuItem.Text = "Admin User";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO TEEPEE TECH CAFE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 343);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
    }
}