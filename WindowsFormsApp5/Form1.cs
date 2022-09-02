using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        DateTime dt;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1;
            dt = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = ((uint)((DateTime.Now - dt).TotalMilliseconds)).ToString();
        }
    }
}
