using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Toolkit.Tools.Geo
{
    public partial class OpenMap : Form
    {
        public OpenMap()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            double lon;
            double lat;

            if (!double.TryParse(tbox_lon.Text, out lon))
            {
                MessageBox.Show("Invalid Value: Lon");
                return;
            }

            if (!double.TryParse(tbox_lat.Text, out lat))
            {
                MessageBox.Show("Invalid Value: Lat");
                return;
            }

            Process.Start($"https://www.openstreetmap.org/#map={num_zoom.Value}/{lon}/{lat}");
        }
    }
}
