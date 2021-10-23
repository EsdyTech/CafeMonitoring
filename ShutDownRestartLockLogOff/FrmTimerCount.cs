using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;

namespace ShutDownRestartLockLogOff
{
    public partial class FrmTimerCount : Form
    {
        private System.Timers.Timer timer;
        //private int h = 0;
        //private int m = 1;
        //private int s = 60;
        private int h;
        private int m;
        private int s = 60;

        //user
        private string firstName;
        private string lastName;

        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public FrmTimerCount(int h, int m, string firstName, string lastName)
        {
            InitializeComponent();
            this.h = h;
            this.m = m;

            this.firstName = firstName;
            this.lastName = lastName;
        }

        private void FrmTimerCount_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;//1s
            timer.Elapsed += OnTimeEvent;

            timer.Start();

            //user
            lbluserFullName.Text = "Welcome " + firstName +" "+ lastName +"!";
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                if (h == -1)
                {
                    timer.Stop();
                    Visible = false;
                    //LockWorkStation();
                    new FrmMain().Show();                    
                }
                else
                {
                    lblTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                }

                s -= 1;
                if (s == 0)
                {
                    s = 60;
                    m -= 1;
                }
                if (m == 0)
                {
                    m = 60;
                    h -= 1;
                }
               
                
                if (m <= 5)
                {
                    Blink();
                }

              
                //s += 1;
                //if (s == 60)
                //{
                //    s = 0;
                //    m += 1;
                //}
                //if (m == 60)
                //{
                //    m = 0;
                //    h += 1;
                //}

                //Update label
            }));
        }

        private void FrmTimerCount_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop timer
            timer.Stop();
            Application.DoEvents();
        }

        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                lblTimeLeft.Text = "You have less than 5 Minutes!";
                lblTimeLeft.BackColor = lblTimeLeft.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }
    }
}
