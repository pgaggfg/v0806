using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx = -20;
        int vy = -10;
        int zettai = Math.Abs(-10);
        String kao = "┏(廿_廿 )┛";
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx)* 11/10;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 11/10;
            }
            if (label1.Left > ClientSize.Width)
            {
                vx = - Math.Abs(vx)* 11/10;
            }
            if (label1.Top > ClientSize.Height)
            {
                vy = -Math.Abs(vy)*11/10;
            }
            string t = label1.Text;
            label1.Text = kao;
            kao = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
        }
    }
}
