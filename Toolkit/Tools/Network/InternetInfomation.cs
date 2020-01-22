using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Toolkit.Tools.Network
{
    public partial class InternetInfomation : Form
    {
        public InternetInfomation()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string data = wc.DownloadString("https://ifconfig.io/all.json");

            FileUtil.JsonViewer viewer = new FileUtil.JsonViewer(data);
            viewer.ShowDialog();
        }
    }
}
