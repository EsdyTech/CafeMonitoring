
namespace ShutDownRestartLockLogOff
{
    partial class FrmTimerCount
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lbluserFullName = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblTimeInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(197, 63);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 68);
            this.lblTimer.TabIndex = 0;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(12, 142);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 19);
            this.lblTimeLeft.TabIndex = 1;
            // 
            // lbluserFullName
            // 
            this.lbluserFullName.AutoSize = true;
            this.lbluserFullName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserFullName.Location = new System.Drawing.Point(12, 9);
            this.lbluserFullName.Name = "lbluserFullName";
            this.lbluserFullName.Size = new System.Drawing.Size(0, 19);
            this.lbluserFullName.TabIndex = 2;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Green;
            this.lblInformation.Location = new System.Drawing.Point(12, 32);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(256, 16);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "You can drag this anywhere on the screen!";
            // 
            // lblTimeInfo
            // 
            this.lblTimeInfo.AutoSize = true;
            this.lblTimeInfo.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInfo.ForeColor = System.Drawing.Color.Green;
            this.lblTimeInfo.Location = new System.Drawing.Point(39, 82);
            this.lblTimeInfo.Name = "lblTimeInfo";
            this.lblTimeInfo.Size = new System.Drawing.Size(137, 33);
            this.lblTimeInfo.TabIndex = 4;
            this.lblTimeInfo.Text = "Time Left:";
            // 
            // FrmTimerCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 170);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimeInfo);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lbluserFullName);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTimer);
            this.Name = "FrmTimerCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.FrmTimerCount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lbluserFullName;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblTimeInfo;
    }
}