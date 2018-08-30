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
        
        int enemyMove = 5;
        Random rnd = new Random();
        int bulletSpeed = 8;
        bool shooting = false;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            Misil.Top = -100;
            Misil.Left = -100;
        }

        int Distancia = 5;

        //Funcion Timer
        private void playTimer(object sender, EventArgs e)
        {
            //player.Left += moveLeft;
            Misil.Top -= bulletSpeed;
            PicEne1.Top += enemyMove;
            PicEne2.Top += enemyMove;
            PicEne3.Top += enemyMove;
            PicEne4.Top += enemyMove;
            PicEne5.Top += enemyMove;
            LblPuntos.Text = "" + score;

            if (PicEne1.Top == 660 || PicEne2.Top == 660 || PicEne3.Top == 660 || PicEne4.Top == 660 || PicEne5.Top == 660)
            {
                gameOver();

            }

            if (shooting && Misil.Top < 0)
            {
                shooting = false;
                bulletSpeed = 0;
                Misil.Top = -100;
                Misil   .Left = -100;
            }
            enemyHit();
        }


        //Funcion Enemigos
        private void enemyHit()
        {
            if (Misil.Bounds.IntersectsWith(PicEne1.Bounds))
            {
                score += 1;
                PicEne1.Top = -500;
                int ranP = rnd.Next(1, 300);
                PicEne1.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                Misil.Top = -100;
                Misil.Left = -100;
            }
            else if (Misil.Bounds.IntersectsWith(PicEne2.Bounds))
            {
                score += 1;
                PicEne2.Top = -900;
                int ranP = rnd.Next(1, 400);
                PicEne2.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                Misil.Top = -100;
                Misil.Left = -100;

            }
            else if (Misil.Bounds.IntersectsWith(PicEne3.Bounds))
            {
                score += 1;
                PicEne3.Top = -1300;
                int ranP = rnd.Next(1, 500);
                PicEne3.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                Misil.Top = -100;
                Misil.Left = -100;

            }
            else if (Misil.Bounds.IntersectsWith(PicEne4.Bounds))
            {
                score += 1;
                PicEne3.Top = -1300;
                int ranP = rnd.Next(1, 500);
                PicEne4.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                Misil.Top = -100;
                Misil.Left = -100;
            }
            else if (Misil.Bounds.IntersectsWith(PicEne5.Bounds))
            {
                score += 1;
                PicEne5.Top = -1300;
                int ranP = rnd.Next(1, 500);
                PicEne5.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                Misil.Top = -100;
                Misil.Left = -100;
            }
        }

        //Funcion Juego Terminado
        private void gameOver()
        {
            tmr.Enabled = false;
            MessageBox.Show("Su puntuacion es = " + score + " clic en Ok para continuar");
            score = 0;
            LblPuntos.Text = "0";
            PicEne1.Top = -500;
            PicEne2.Top = -900;
            PicEne3.Top = -1300;
            Misil.Top = -100;
            Misil.Left = -100;
            tmr.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            PicFondo.Image = Image.FromFile(Application.StartupPath + "\\BackGround.gif");
            PicNave.Image = Image.FromFile(Application.StartupPath + "\\Nave.gif");
            Misil.Image = Image.FromFile(Application.StartupPath + "\\Misil.gif");
            PicEne1.Image = Image.FromFile(Application.StartupPath + "\\Enemigo.jpg");
            PicEne2.Image = Image.FromFile(Application.StartupPath + "\\Enemigo.jpg");
            PicEne3.Image = Image.FromFile(Application.StartupPath + "\\Enemigo.jpg");
            PicEne4.Image = Image.FromFile(Application.StartupPath + "\\Enemigo.jpg");
            PicEne5.Image = Image.FromFile(Application.StartupPath + "\\Enemigo.jpg");
            tmr.Enabled = true;      
            /*BackgroundImageLayout = ImageLayout.Center;
            this.BackgroundImage=Image.FromFile(Application.StartupPath + "\\giphy.gif");
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);*/
        }

       private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        if ((PicNave.Location.Y - Distancia) >= 0)
                            PicNave.Location = new Point(PicNave.Location.X, PicNave.Location.Y - Distancia);
                        break;
                    }

                case Keys.Down:
                    {
                        if ((PicNave.Height + (PicNave.Location.Y + Distancia)) <= ClientSize.Height)
                            PicNave.Location = new Point(PicNave.Location.X, PicNave.Location.Y + Distancia);
                        break;
                    }

                case Keys.Left:
                    {
                        if ((PicNave.Location.X - Distancia) >= 0)
                            PicNave.Location = new Point(PicNave.Location.X - Distancia, PicNave.Location.Y); break;

                    }

                case Keys.Right:
                    {
                        if ((PicNave.Width + (PicNave.Location.X + Distancia)) <= ClientSize.Width)
                            PicNave.Location = new Point(PicNave.Location.X + Distancia, PicNave.Location.Y); break;
                    }

                case Keys.Space:
                    {
                        if (shooting == false)
                        {
                            bulletSpeed = 30;
                            Misil.Left = PicNave.Left + 50;
                            Misil.Top = PicNave.Top;
                            shooting = true;
                            
                        }
                        break;
                    }
                    

            }
        }
    }
    }





