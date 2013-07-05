using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabStrip.Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            testUserControl1.AddNewTabPage();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            testUserControl1.RemoveLastTab();
        }
    }
}