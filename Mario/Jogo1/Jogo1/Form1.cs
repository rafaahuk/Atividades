using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Jogo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "CAVALO")
            {
                for (int I = 0; I <= 100; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                    pictureBox4.Image = Properties.Resources.Panda;
                    textBox1.Clear();
                    textBox1.Focus();
                }

            }
            if (textBox1.Text == "PANDA")
            {
                for (int I = 0; I <= 100; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                    pictureBox4.Image = Properties.Resources.vaca;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            if (textBox1.Text == "VACA")
            {
                for (int I = 0; I <= 100; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                    pictureBox4.Image = Properties.Resources.elefante;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }

            if (textBox1.Text == "ELEFANTE")
            {
                for (int I = 0; I <= 100; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                    pictureBox4.Image = Properties.Resources.sapo;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            if (textBox1.Text == "SAPO")
            {
                for (int I = 0; I <= 100; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                    pictureBox4.Image = Properties.Resources.Leao;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            if (textBox1.Text == "LEAO")
            {
                for (int I = 0; I <= 55; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);
                    pictureBox4.Image = Properties.Resources.Gato;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }

            if (textBox1.Text == "GATO")
            {
                for (int I = 0; I <= 120; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                    pictureBox4.Image = Properties.Resources.cobra;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }

            if (textBox1.Text == "COBRA")
            {
                for (int I = 0; I <= 25; I++)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);

                    for (int J = 0; J <= 5; J++)

                        pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);


                    pictureBox4.Image = Properties.Resources.Coelho;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            if (textBox1.Text == "COELHO")
            {
                for (int I = 0; I <= 30; I++)
                {

                    pictureBox2.Location = new Point(pictureBox2.Location.X - 1, pictureBox2.Location.Y);

                    for (int J = 0; J <= 3; J++)
                    {
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);

                    }
                }
                pictureBox2.Image = Properties.Resources._400_694_Mario_e_Princesa_Peach;

                pictureBox3.Visible = false;
                textBox1.Clear();

                
                Form2 form = new Form2();
                form.Show();
                this.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("AJUDE O MARIO A CHEGAR NA PRINCESA , COLOQUE O NOME DO ANIMAL QUE APARECE NA FIGURA E DE OK");
            SoundPlayer fundo = new SoundPlayer(@"C:\\Mario.wav");
            fundo.Play();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        }
    }

