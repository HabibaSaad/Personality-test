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
    public partial class page19 : Form
    {
        public page19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page18 page = new page18();
            page.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page20 page = new page20();
            page.Show();
            this.Close();
        }
    }
}
