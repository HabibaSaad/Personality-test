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
    public partial class page2 : Form
    {
        public page2()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            variable.name = txt.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt.Text == "" || txt.Text == "Full Name")
            {
                MessageBox.Show("Please Write your name");
            }
            else
            {
                page3 page3 = new page3();
                page3.Show();
                this.Hide();
            }
          
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if(txt.Text=="Full Name")
            {
                txt.Text="";
                txt.ForeColor = Color.Black;
            }

        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (txt.Text == "")
            {
                txt.Text = "Full Name";
                txt.ForeColor = Color.Gray;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page1 page = new page1();
            page.Show();
            this.Hide();    
        }

        private void page2_Load(object sender, EventArgs e)
        {

        }
    }
}
