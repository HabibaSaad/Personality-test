using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personality_test
{
    public partial class page8 : Form
    {
        public page8()
        {
            InitializeComponent();
        }

        private void page8_Load(object sender, EventArgs e)
        {

        }
        public static int x = 40;
        public static int y = 60;
        public static int height = 100;
        public static int width = 100;
        System.Drawing.Color GetCircleColor()
        {
            decimal or = variable._orange, gr = variable._green, go = variable._gold, bl = variable._blue;
            Color circlecolor = Color.White; // Default color in case no condition is met

            if (or > bl && or > gr && or > go)
            {
                circlecolor = Color.Orange;
            }
            else if (bl > or && bl > gr && bl > go)
            {
                circlecolor = Color.Blue;
            }
            else if (gr > go && gr > or && gr > bl)
            {
                circlecolor = Color.Green;
            }
            else if (go > gr && go > or && go > bl)
            {
                circlecolor = Color.Gold;
            }
            else if (or == bl && or == go && or == gr)
            {
                circlecolor = Color.FromArgb(0x80, 0x89, 0x40);

            }
            else if (or == go && or == gr && or > bl)
            {
                circlecolor = Color.FromArgb(0xaa, 0xb7, 0x00);

            }
            else if (or == go && or > bl && or > gr)
            {
                circlecolor = Color.FromArgb(0xff, 0xd2, 0x00);

            }
            else if (or == gr && or == bl && or > go)
            {
                circlecolor = Color.FromArgb(0x55, 0x62, 0x55);
            }
            else if (or == bl && or == go && or > gr)
            {
                circlecolor = Color.FromArgb(0xaa, 0x8c, 0x55);
            }
            else if (or == bl && or > gr && or > go)
            {
                circlecolor = Color.FromArgb(0x80, 0x53, 0x80);
            }
            else if (or == gr && or > go && or > bl)
            {
                circlecolor = Color.FromArgb(0x80, 0x93, 0x00);
            }
            else if (go == bl && go == gr && go > or)
            {
                circlecolor = Color.FromArgb(0x55, 0x80, 0x55);
            }
            else if (go == bl && go > gr && go > or)
            {
                circlecolor = Color.FromArgb(0x80, 0x80, 0x80);
            }
            else if (go == gr && go > or && go > bl)
            {
                circlecolor = Color.FromArgb(0x80, 0xc0, 0x00);
            }
            else if (gr == bl && gr > go && gr > or)
            {
                circlecolor = Color.FromArgb(0x00, 0x40, 0x80);
            }

            return circlecolor;
        }

        void drawcircle()
        {

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Rectangle circle = new Rectangle(x, y, width, height);
            System.Drawing.SolidBrush fillorange = new System.Drawing.SolidBrush(GetCircleColor());
            g.DrawEllipse(pen, circle);
            g.FillEllipse(fillorange, circle);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (numericUpDown1.Value > 4)
            {
                MessageBox.Show("Numbers have to be smaller than 4");
                numericUpDown1.Value = 4;
            }
            else
            {

                variable.orange = variable.orange + numericUpDown1.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            if (numericUpDown2.Value > 4)
            {
                MessageBox.Show("Numbers have to be smaller than 4");
                numericUpDown2.Value = 4;
            }
            else
            {
                variable.green = variable.green + numericUpDown2.Value;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 4)
            {
                MessageBox.Show("Numbers have to be smaller than 4");
                numericUpDown3.Value = 4;
            }
            else
            {
                variable.blue = variable.blue + numericUpDown3.Value;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 4)
            {
                MessageBox.Show("Numbers have to be smaller than 4");
                numericUpDown4.Value = 4;
            }
            else
            {
                variable.gold = variable.gold + numericUpDown4.Value;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawcircle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 || numericUpDown4.Value == 0)
            {
                MessageBox.Show("Oops, seems like you forgot to write your answer :)");
            }
            else if (numericUpDown1.Value == numericUpDown2.Value || numericUpDown1.Value == numericUpDown3.Value || numericUpDown1.Value == numericUpDown4.Value || numericUpDown2.Value == numericUpDown3.Value || numericUpDown2.Value == numericUpDown4.Value || numericUpDown3.Value == numericUpDown4.Value)
            {
                MessageBox.Show("Every Sentence have to have diffrent Numbers \n Please try again!");
            }
            else
            {
                page9 page = new page9();
                page.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page7 page = new page7();
            page.Show();
            this.Hide();
        }
    }
}
