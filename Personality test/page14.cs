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
    public partial class page14 : Form
    {
        public page14()
        {
            InitializeComponent();
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
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = " : " + variable.orange.ToString();
            label4.Text = " : " + variable.green.ToString();
            label6.Text = " : " + variable.blue.ToString();
            label10.Text = " : " + variable.gold.ToString();
            label15.Text = variable.name;
            if(variable._orange>variable._gold && variable._orange>variable._green&& variable._orange > variable._blue)
            {
                label13.Text = "Orange";
                if (variable._gold > variable._green && variable._gold > variable._blue)
                {
                    label14.Text = "Gold";
                }else if(variable._green>variable._blue&& variable._green > variable._gold)
                {
                    label14.Text = "Green";
                }
                else
                {
                    label14.Text = "Blue";
                }
            }else if (variable._gold > variable._green && variable._gold > variable._blue&& variable._gold>variable._orange)
            {
                label13.Text = "Gold";
                if(variable._green > variable._blue && variable._green > variable._orange)
                {
                    label14.Text = "Green";
                }else if(variable._blue > variable._green  && variable._blue > variable._orange)
                {
                    label14.Text = "Blue";
                }
                else
                {
                    label14.Text = "Orange";
                }
            }else if (variable._green > variable._blue && variable._green > variable._gold && variable._green>variable._orange)
            {
                label13.Text = "Green";
                if( variable._gold > variable._blue && variable._gold > variable._orange)
                {
                    label14.Text = "Gold";
                }else if (variable._blue > variable._gold && variable._blue > variable._orange)
                {
                    label14.Text = "Blue";
                }
                else
                {
                    label14.Text = "Orange";
                }
            }else if(variable._blue > variable._green && variable._blue > variable._gold && variable._blue> variable._orange)
            {
                label13.Text = "Blue";
                if(variable._gold > variable._green && variable._gold > variable._orange)
                {
                    label14.Text = "Gold";
                }else if (variable._green > variable._gold && variable._green > variable._orange)
                {
                    label14.Text = "Green";
                }else
                {
                    label14.Text = "Orange";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawcircle();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            page15 page = new page15();
            page.Show(); 
            this.Hide();
        }

        private void page14_Load(object sender, EventArgs e)
        {

        }
    }
}
