////using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мины
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.мина;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, this.Width - pictureBox2.Width);
            int y = random.Next(0, this.Height - pictureBox2.Height);
            pictureBox2.Height = pictureBox2.Height - 10;
            pictureBox2.Width = pictureBox2.Width - 10;
            pictureBox2.Location = new Point(x, y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, this.Width - pictureBox2.Width-20);
            int y = random.Next(0, this.Height - pictureBox2.Height-20);
            pictureBox2.Height = pictureBox2.Height - 5;
            pictureBox2.Width = pictureBox2.Width - 5;
            pictureBox2.Location = new Point(x, y);
        }
    }
    }
