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
    public partial class page3 : Form
    {
        public static int x = 40;
        public static int y = 60;
        public static int height = 100;
        public static int width = 100;
        public page3()
        {
            InitializeComponent();
        }
      
        private void page3_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown5.Value == 0 || numericUpDown6.Value == 0)
            {
                MessageBox.Show("Oops, seems like you forgot to write your answer :)");
            }
            else if (numericUpDown1.Value == numericUpDown2.Value || numericUpDown1.Value == numericUpDown5.Value || numericUpDown1.Value == numericUpDown6.Value || numericUpDown2.Value == numericUpDown5.Value || numericUpDown2.Value == numericUpDown6.Value || numericUpDown5.Value == numericUpDown6.Value)
            {
                MessageBox.Show("Every Sentence have to have diffrent Numbers \n Please try again!");
            }
            else {
            page4 page4 = new page4();
                page4.Show();
                this.Hide();
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        System.Drawing.Color GetCircleColor()
        {
          
            Color circlecolor = Color.White; 
            return circlecolor;
        }

        void drawcircle()
        {

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Rectangle circle = new Rectangle(x, y, width, height);
            System.Drawing.SolidBrush filldefult = new System.Drawing.SolidBrush(GetCircleColor());
            g.DrawEllipse(pen, circle);
            g.FillEllipse(filldefult, circle);

        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawcircle();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page2 page = new page2();
            page.Show();
            this.Hide();
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
                variable.orange = numericUpDown2.Value;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 4)
            {
                MessageBox.Show("Numbers have to be smaller than 4");
                numericUpDown5.Value = 4;
            }
            else
            {
                variable.green = numericUpDown5.Value;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value > 4)
            {
                MessageBox.Show("Numbers have to be smaller than 4");
                numericUpDown6.Value = 4;
            }
            else
            {
                variable.blue = numericUpDown6.Value;
            }
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
                variable.gold = numericUpDown1.Value;
            }
        }
    }
}
