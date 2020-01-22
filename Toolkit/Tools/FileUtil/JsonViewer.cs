using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Toolkit.Tools.FileUtil
{
    public partial class JsonViewer : Form
    {
        public JsonViewer()
        {
            InitializeComponent();
        }

        public JsonViewer(string json)
        {
            InitializeComponent();

            rtbox_json.Text = json;

            rbtn_file.Checked = false;
            rbtn_area.Checked = true;

            btn_proc_Click(null, null);
        }

        private void btn_proc_Click(object sender, EventArgs e)
        {
            jsonView.Nodes.Clear();

            string json = string.Empty;
            if (rbtn_file.Checked)
            {
                if (!File.Exists(tbox_jsonpath.Text))
                {
                    MessageBox.Show("No File");
                    return;
                }
                json = File.ReadAllText(tbox_jsonpath.Text);
            }
            else if (rbtn_area.Checked)
            {
                json = rtbox_json.Text;
            }

            dynamic data;
            try
            {
                data = JsonConvert.DeserializeObject<dynamic>(json);
            }
            catch
            {
                MessageBox.Show("No Json");
                return;
            }

            rtbox_dynamic_str.Text = data.ToString();

            var node = jsonView.Nodes.Add("Root");
            foreach (var d in data)
            {
                ProcessJson(node, d);
            }
        }

        private void ProcessJson(TreeNode node, dynamic data)
        {
            TreeNode nd = node;

            switch (data)
            {
                case JProperty v:
                    //nd = node.Nodes.Add($"{v.Path}");
                    ProcessJson(node, data.Value);
                    break;

                case JValue v:
                    node.Nodes.Add($"{data.Parent.Name}: {data.Value ?? "null"}");
                    break;

                case JArray v1:
                    for (int i = 0; i < data.Count; i++)
                    {
                        nd = node.Nodes.Add($"[{i}]");
                        ProcessJson(nd, data[i]);
                    }
                    break;

                case JObject v2:
                    foreach (var d in data)
                    {
                        if (d.Value.GetType() != typeof(JValue))
                            nd = node.Nodes.Add(d.Name);
                        ProcessJson(nd, d.Value);
                    }
                    break;

                default:
                    node.Nodes.Add(data);
                    break;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void rbtn_file_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_file.Checked) rbtn_area.Checked = false;
        }

        private void rbtn_area_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_area.Checked) rbtn_file.Checked = false;
        }

        private void btn_json_browse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK) return;

            tbox_jsonpath.Text = ofd.FileName;
        }
    }
}