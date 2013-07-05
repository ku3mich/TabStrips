using System;
using System.Windows.Forms;

namespace TabStrip.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            
            lblMessage.Text = "TabStrip version 2." + Environment.NewLine + Environment.NewLine +
                              "This control is a subset of FarsiLibrary project which is also available at CodeProject website for free.";
        }

        private void btnDemo1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            ShowForm(f);
        }
        
        private void btnDemo2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            ShowForm(f);
        }

        private void btnDemo3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            ShowForm(f);
        }

        private void ShowForm(Form f)
        {
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
        }
    }
}