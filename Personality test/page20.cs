﻿using System;
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
    public partial class page20 : Form
    {
        public page20()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page19 page = new page19();
            page.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page21 page = new page21();
            page.Show();
            this.Close();
        }
    }
}
