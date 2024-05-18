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
    public partial class page18 : Form
    {
        public page18()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page17 page = new page17();
            page.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page19 page = new page19();
            page.Show();
            this.Close();
        }
    }
}
