using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.Threading;
using System.Collections;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        private int animationTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCollapseInward;
        private int flags;
        private System.Windows.Forms.NumericUpDown nudAnimationTime;
        private System.Windows.Forms.Button btnFadeEffect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSlide;
        private System.Windows.Forms.Button btnBottomToTop;
        private System.Windows.Forms.Button btnTopToBottom;
        private System.Windows.Forms.Button btnRightToLeft;
        private System.Windows.Forms.Button btnLeftToRight;
        private System.Windows.Forms.Button btnExit;
        public Form3()
        {
            InitializeComponent();
            //MessageBox.Show("You cant get rid of me that easily!");
            //MessageBox.Show("The calculations are complete", "My Application",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            animationTime = 300;
            flags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_POSITIVE;
            flags |= WinAPI.AW_SLIDE;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(5000);
            //System.Timers.Timer aTimer = new System.Timers.Timer();
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            // Set the Interval to 5 seconds.
            //aTimer.Interval = 5000;
            //aTimer.Enabled = true;
            WinAPI.AnimateWindow(this.Handle, animationTime, flags);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
