using System.Windows.Forms;
using FarsiLibrary.Win;

namespace TabStrip.Test
{
    public partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
        }
        
        public void AddNewTabPage()
        {
            faTabStrip1.AddTab(new FATabStripItem(string.Format("New Document {0}", faTabStrip1.Items.Count + 1), null));
        }
        
        public void RemoveLastTab()
        {
            if (faTabStrip1.Items.Count > 0)
            {
                FATabStripItem item = faTabStrip1.Items[faTabStrip1.Items.Count - 1];
                faTabStrip1.RemoveTab(item);
            }
        }
    }
}
