namespace ShutDownRestartLockLogOff
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
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.logOffBtn = new System.Windows.Forms.Button();
            this.lockBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Location = new System.Drawing.Point(159, 63);
            this.shutdownBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(151, 28);
            this.shutdownBtn.TabIndex = 0;
            this.shutdownBtn.Text = "Shut down";
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(159, 122);
            this.restartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(151, 28);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // logOffBtn
            // 
            this.logOffBtn.Location = new System.Drawing.Point(159, 186);
            this.logOffBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOffBtn.Name = "logOffBtn";
            this.logOffBtn.Size = new System.Drawing.Size(151, 28);
            this.logOffBtn.TabIndex = 2;
            this.logOffBtn.Text = "Log off";
            this.logOffBtn.UseVisualStyleBackColor = true;
            this.logOffBtn.Click += new System.EventHandler(this.logOffBtn_Click);
            // 
            // lockBtn
            // 
            this.lockBtn.Location = new System.Drawing.Point(159, 255);
            this.lockBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lockBtn.Name = "lockBtn";
            this.lockBtn.Size = new System.Drawing.Size(151, 28);
            this.lockBtn.TabIndex = 3;
            this.lockBtn.Text = "Lock";
            this.lockBtn.UseVisualStyleBackColor = true;
            this.lockBtn.Click += new System.EventHandler(this.lockBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 346);
            this.Controls.Add(this.lockBtn);
            this.Controls.Add(this.logOffBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.shutdownBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Shut Down, Restart, Log off or Lock your computer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button logOffBtn;
        private System.Windows.Forms.Button lockBtn;
    }
}

