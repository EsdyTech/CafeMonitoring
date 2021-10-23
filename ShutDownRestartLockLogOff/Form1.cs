using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ShutDownRestartLockLogOff
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public Form1()
        {
            InitializeComponent();
        }
        
        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown","/s /t 0");
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

        private void logOffBtn_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
  
        }

        private void lockBtn_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
