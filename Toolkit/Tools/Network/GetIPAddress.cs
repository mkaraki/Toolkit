using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit.Tools.Network
{
    public partial class GetIPAddress : Form
    {
        public GetIPAddress()
        {
            InitializeComponent();
        }

        private void GetIPAddress_Load(object sender, EventArgs e)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var nic in nics)
            {
                var item = tview.Nodes[0].Nodes.Add($"{nic.Id}: {nic.Name}");
                IPInterfaceProperties ipi = nic.GetIPProperties();

                foreach (var ip in ipi.UnicastAddresses)
                {
                    item.Nodes.Add(ip.Address.ToString());
                }
            }

        }
    }
}
