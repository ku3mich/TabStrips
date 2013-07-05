using System;
using System.Windows.Forms;
using FarsiLibrary.Win;

namespace TabStrip.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            RTLTabStrip.TabStripItemSelectionChanged += new TabStripItemChangedHandler(OnTabPageSelectionChanged);
        }

        private void OnTabPageSelectionChanged(TabStripItemChangedEventArgs e)
        {
            if(e.Item != null && e.ChangeType == FATabStripItemChangeTypes.SelectionChanged)
            {
                FATabStripItem item = e.Item;
                cbCloseable.Checked = item.CanClose;
            }
            else if(e.Item == null)
            {
                cbCloseable.CheckState = CheckState.Indeterminate;
            }
        }

        private void AddTab_Click(object sender, EventArgs e)
        {
            FATabStripItem item = new FATabStripItem(string.Format("New Document {0}", RTLTabStrip.Items.Count + 1), null);
            RTLTabStrip.AddTab(item);
        }

        private void RemoveTab_Click(object sender, EventArgs e)
        {
            int count = RTLTabStrip.Items.Count;
            
            if(count > 0)
                RTLTabStrip.Items.RemoveAt(count - 1);
        }

        private void ToggleDirection_Click(object sender, EventArgs e)
        {
            if (RTLTabStrip.RightToLeft == RightToLeft.Yes)
            {
                RTLTabStrip.RightToLeft = RightToLeft.No;
            }
            else
            {
                RTLTabStrip.RightToLeft = RightToLeft.Yes;
            }
        }

        private void btnForceClose_Click(object sender, EventArgs e)
        {
            if(RTLTabStrip.SelectedItem != null)
                RTLTabStrip.RemoveTab(RTLTabStrip.SelectedItem);
        }

        private void cbCloseable_CheckedChanged(object sender, EventArgs e)
        {
            if(RTLTabStrip.SelectedItem != null)
            {
                RTLTabStrip.SelectedItem.CanClose = cbCloseable.Checked;
            }
        }
    }
}