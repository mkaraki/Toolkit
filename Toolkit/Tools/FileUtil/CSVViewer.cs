using System;
using System.Windows.Forms;
using System.IO;

namespace Toolkit.Tools.FileUtil
{
    public partial class CSVViewer : Form
    {
        public CSVViewer()
        {
            InitializeComponent();
        }

        private void btn_parse_Click(object sender, EventArgs e)
        {
            btn_parse.Enabled = false;
            listView.Clear();

            char separator = GetSeparator();

            int columnCount = 0;

            if (!File.Exists(tbox_file.Text))
            { 
                MessageBox.Show("No File");
                btn_parse.Enabled = true;
                return;
            }

            string[] data = File.ReadAllLines(tbox_file.Text);
            if (data.Length < 1)
            {
                MessageBox.Show("File is empty");
                btn_parse.Enabled = true;
                return;
            }

            listView.Columns.Add("Row", 40, HorizontalAlignment.Right);

            if (cbox_header.Checked)
            {
                string[] header = data[0].Split(separator);
                foreach (string head in header)
                {
                    listView.Columns.Add(head);
                }
            }

            for (int r = cbox_header.Checked ? 1 : 0; r < data.Length; r++)
            {
                string[] d = data[r].Split(separator);

                if (d.Length > columnCount)
                    columnCount = d.Length;

                ListViewItem item = new ListViewItem();
                item.Text = (r + 1).ToString();

                for (int c = 0; c < d.Length; c++)
                {
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                    subitem.Text = d[c];
                    item.SubItems.Add(subitem);
                }

                listView.Items.Add(item);
            }

            if (!cbox_header.Checked)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    listView.Columns.Add((x + 1).ToString());
                }
            }

            btn_parse.Enabled = true;
        }

        private char GetSeparator()
        {
            switch (cbox_sep.Text)
            {
                default:
                case "Comma (csv)":
                    return ',';

                case "Tab (tsv)":
                    return '\t';

                case "Custom":
                    return UserSeparator;
            }
        }

        private void cbox_sep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_sep.Text == "Custom")
                btn_sep_custom.Enabled = true;
            else
                btn_sep_custom.Enabled = false;
        }

        private void rbtn_file_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK) return;

            tbox_file.Text = ofd.FileName;
        }

        private char UserSeparator { get; set; }

        private void btn_sep_custom_Click(object sender, EventArgs e)
        {
            View.AskLineWithOK askform = new View.AskLineWithOK("CSV Viewer", "Input Custom Delimita", "");
            askform.ShowDialog();

            if (askform.UserAnswer.Length != 1)
            {
                MessageBox.Show("Separator length is not 1");
                cbox_sep.Text = "Comma (csv)";
                return;
            }

            UserSeparator = askform.UserAnswer[0];
        }
    }
}