using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit.Tools.PictureTools
{
    public partial class RandomPictureGenerator : Form
    {
        public RandomPictureGenerator()
        {
            InitializeComponent();
        }

        private Color[] GenerateRandomColorSet(int Count = 30)
        {
            Color[] ColorSet = new Color[Count];
            Random rnd = new Random();
            
            for (int i = 0; i < Count; i++)
            {
                Color color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                ColorSet[i] = color;
            }

            return ColorSet;
        }

        private async void btn_make_Click(object sender, EventArgs e)
        {
            SwitchButtonEnabled(false);

            Bitmap bitmap = new Bitmap((int)nbox_x.Value, (int)nbox_y.Value);

            int cset_len = 30;
            Random rnd = new Random();
            Color[] cset = GenerateRandomColorSet(cset_len);

            await Task.Run(() => {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        int idx = rnd.Next(0, cset_len);
                        bitmap.SetPixel(x, y, cset[idx]);
                    }
                }
            });

            pictureBox.Image = bitmap;

            SwitchButtonEnabled(true);
        }

        private void SwitchButtonEnabled(bool Enabled)
        {
            nbox_x.Enabled = Enabled;
            nbox_y.Enabled = Enabled;
            btn_make.Enabled = Enabled;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() != DialogResult.OK) return;


            try
            {
                pictureBox.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
    }
}
