using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit.Tools.PictureTools
{
    public partial class PictureCompare : Form
    {
        public PictureCompare()
        {
            InitializeComponent();
        }

        private async void btn_diff_Click(object sender, EventArgs e)
        {
            SwitchButtonEnable(false);

            tlbl_res.Text = "Working";

            Bitmap p1 = new Bitmap(tbox_pic1.Text);
            Bitmap p2 = new Bitmap(tbox_pic2.Text);

            if (p1.Width != p2.Width)
            {
                tlbl_res.Text = "Width not match.";
                MessageBox.Show("Picture width not match.");
                SwitchButtonEnable(true);
                return;
            }

            if (p1.Height != p2.Height)
            {
                tlbl_res.Text = "Height not match.";
                MessageBox.Show("Picture height not match.");
                SwitchButtonEnable(true);
                return;
            }

            List<(int, int)> DifferentPoints = new List<(int, int)>();
            List<string> DifferentPointsString = new List<string>();
            Bitmap res = new Bitmap(p1.Width, p2.Height);

            await Task.Run(() =>
            {
                for (int x = 0; x < p1.Width; x++)
                {
                    for (int y = 0; y < p1.Height; y++)
                    {
                        Color c1 = p1.GetPixel(x, y);
                        Color c2 = p2.GetPixel(x, y);
                        if (c1 != c2)
                        {
                            DifferentPoints.Add((x, y));
                            DifferentPointsString.Add($"({x}, {y})");
                        }
                    }
                }
            });

            Console.WriteLine(DifferentPoints.Count);

            if (DifferentPoints.Count > 0)
            {
                tlbl_res.Text = "Making Report";
                string report = $"{DifferentPoints.Count} different pixel found.{Environment.NewLine}";

                report += string.Join(Environment.NewLine, DifferentPointsString);

                await Task.Run(() =>
                {
                    for (int i = 0; i < DifferentPoints.Count; i++)
                    {
                        var p = DifferentPoints[i];
                        res.SetPixel(p.Item1, p.Item2, Color.Black);
                    }
                });

                rtbox_report.Text = report;
                pbox_diff.Image = res;

                tlbl_res.Text = "Not same picture.";
                MessageBox.Show("Not same picture.");
            }
            else
            {
                tlbl_res.Text = "Same picture.";
                MessageBox.Show("Same picture.");
            }
            SwitchButtonEnable(true);
        }

        private void SwitchButtonEnable(bool Enabled)
        {
            tbox_pic1.Enabled = Enabled;
            tbox_pic2.Enabled = Enabled;
            btn_select_pic1.Enabled = Enabled;
            btn_select_pic2.Enabled = Enabled;
            btn_diff.Enabled = Enabled;
            cbox_diffc.Enabled = Enabled;
        }

        private void tbox_pic1_Leave(object sender, EventArgs e)
        {
            if (!File.Exists(tbox_pic1.Text)) return;

            pbox_p1.ImageLocation = tbox_pic1.Text;
        }

        private void tbox_pic2_Leave(object sender, EventArgs e)
        {
            if (!File.Exists(tbox_pic2.Text)) return;

            pbox_p2.ImageLocation = tbox_pic2.Text;
        }

        private void btn_select_pic1_Click(object sender, EventArgs e)
        {
            if (ofd_p1.ShowDialog() != DialogResult.OK) return;

            tbox_pic1.Text = ofd_p1.FileName;
            tbox_pic1_Leave(null, null);
        }

        private void btn_select_pic2_Click(object sender, EventArgs e)
        {
            if (ofd_p2.ShowDialog() != DialogResult.OK) return;

            tbox_pic2.Text = ofd_p2.FileName;
            tbox_pic2_Leave(null, null);
        }

        private void lbl_savereport_Click(object sender, EventArgs e)
        {
            if (sfd_report.ShowDialog() != DialogResult.OK) return;

            try
            {
                File.WriteAllText(sfd_report.FileName, rtbox_report.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void pbox_p1_Click(object sender, EventArgs e)
        {
            var pview = new View.Picture.PictureViewer("Picture 1", pbox_p1.Image);
            pview.Show();
        }

        private void pbox_p2_Click(object sender, EventArgs e)
        {
            var pview = new View.Picture.PictureViewer("Picture 2", pbox_p2.Image);
            pview.Show();
        }

        private void pbox_diff_Click(object sender, EventArgs e)
        {
            var pview = new View.Picture.PictureViewer("Different", pbox_diff.Image);
            pview.Show();
        }
    }
}