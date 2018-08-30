using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicFondo.Image = Image.FromFile(Application.StartupPath + "\\giphy.gif");
            /*BackgroundImageLayout = ImageLayout.Center;
            this.BackgroundImage=Image.FromFile(Application.StartupPath + "\\giphy.gif");
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);*/
            PicNave.Image = Image.FromFile(Application.StartupPath + "\\2.gif");
            timer1.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Left = PicNave.Left + 5;
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Left = PicNave.Left - 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Top = PicNave.Top - 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Top = PicNave.Top + 5;
            }
            if (e.KeyCode == Keys.A)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Top = PicNave.Top + 5;
                PicNave.Left = PicNave.Left - 5;
            }
            if (e.KeyCode == Keys.Q)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Top = PicNave.Top - 5;
                PicNave.Left = PicNave.Left - 5;
            }
            if (e.KeyCode == Keys.W)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Top = PicNave.Top - 5;
                PicNave.Left = PicNave.Left + 5;
            }
            if (e.KeyCode == Keys.S)
            {
                for (int i = 1; i <= 50; i++)
                {
                }
                PicNave.Top = PicNave.Top + 5;
                PicNave.Left = PicNave.Left + 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
