using System.Windows.Forms;

namespace TabStrip.Test
{
    public partial class ComplicatedUserControl : UserControl
    {
        public ComplicatedUserControl()
        {
            InitializeComponent();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node != null)
            {
                lblNodeName.Text = e.Node.Text;
            }
        }
    }
}
