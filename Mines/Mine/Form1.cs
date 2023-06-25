﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;
using System.Timers;

namespace Mine
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(@"E:\22\Mines\Mine\bin\Debug\vzriv.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var X1 = pictureBox1.Left + (pictureBox1.Width)/2;
            var X2 = MousePosition.X;
            var Y1 = pictureBox1.Top + pictureBox1.Height;
            var Y2 = MousePosition.Y;
            var D = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2));
            textBox3.Text = Convert.ToString(D);
            textBox1.Text = Convert.ToString(Y2);
            textBox2.Text = Convert.ToString(X2);
            var w = pictureBox1.Width;
            var h = pictureBox1.Height;
            var r = w + h;
            if (D <= r/2)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var a = textBox4.Text;
            int k = Convert.ToInt32(a);
            if (k > 1)
            {
                player.Play();
                Random rnd1 = new Random();
                Random rnd2 = new Random();
                pictureBox1.Top = rnd1.Next(0, 475);
                pictureBox1.Left = rnd2.Next(0, 617);
                pictureBox1.Width = pictureBox1.Width - 5;
                pictureBox1.Height = pictureBox1.Height - 5;
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) - 1);
            }
            if (k == 1)
            {
                player.Play();
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) - 1);
                string message = "все мины найдены! еще раз?";
                string caption = "Минер";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
            pictureBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            var k = textBox5.Text;
            label5.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = k;
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            pictureBox1.Top = rnd1.Next(0, 475);
            pictureBox1.Left = rnd2.Next(0, 617);
            button1.Enabled = false;
            textBox4.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
