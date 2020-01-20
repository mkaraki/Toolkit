using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Toolkit.Tools.Config
{
    public partial class WindowsJump : Form
    {
        public WindowsJump()
        {
            InitializeComponent();

            var json = System.IO.File.ReadAllText(Program.GetExternalFilePath("WindowsJumpList.json"));
            var WJItems = JsonConvert.DeserializeObject<WindowsJumpItem[]>(json);
            foreach (var i in WJItems)
            {
                lview.Items.Add(i.GetListViewItem());
            }
        }

        private void lview_DoubleClick(object sender, EventArgs e)
        {
            if (lview.SelectedItems.Count < 1) return;

            string exe = lview.SelectedItems[0].SubItems[1].Text;
            try
            {
                System.Diagnostics.Process.Start(exe);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private class WindowsJumpItem 
        {
            public ListViewItem GetListViewItem()
            {
                var lvi = new ListViewItem();
                lvi.Text = Name;
                ListViewItem.ListViewSubItemCollection itemCollection = new ListViewItem.ListViewSubItemCollection(lvi);
                itemCollection.Add(Exe);
                itemCollection.Add(Description);

                return lvi;
            }

            public string Name { get; set; } = "Unknown";

            public string Exe { get; set; } = "";

            public string Description { get; set; } = "";
        }
    }
}
