using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit
{
    public partial class Launcher : Form
    {
        private static readonly Dictionary<string, Type> FormNameDB = new Dictionary<string, Type>()
        {
            { "Picture Compare", typeof(Tools.PictureTools.PictureCompare) },
            { "Random Picture", typeof(Tools.PictureTools.RandomPictureGenerator) },
            { "Jump", typeof(Tools.Config.WindowsJump) },
            { "IP Addresses", typeof(Tools.Network.GetIPAddress) },
            { "Json Viewer", typeof(Tools.FileUtil.JsonViewer) },
            { "Separated File Viewer", typeof(Tools.FileUtil.CSVViewer) },
            { "Open Map by Lon/Lat", typeof(Tools.Geo.OpenMap) },
        };

        public Launcher()
        {
            InitializeComponent();

            foreach (var n in FormNameDB.Keys)
            {
                Button btn = new Button();
                btn.Text = n;
                btn.Click += Btn_Click;
                btn.Size = new Size(130, 23);

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string code = ((Button)sender).Text;

            if (!FormNameDB.ContainsKey(code)) return;

            Form form = (Form)Activator.CreateInstance(FormNameDB[code]);
            form.ShowDialog();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }
    }
}
