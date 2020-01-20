using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit.View.Picture
{
    public partial class PictureViewer : Form
    {
        public PictureViewer(string WindowTitle, string FilePath)
        {
            InitializeComponent();
            Text = WindowTitle;
            pictureBox.ImageLocation = FilePath;
        }

        public PictureViewer(string WindowTitle, Bitmap bitmap)
        { 
            InitializeComponent();
            Text = WindowTitle;
            pictureBox.Image = bitmap;
        }

        public PictureViewer(string WindowTitle, Image image)
        {
            InitializeComponent();
            Text = WindowTitle;
            pictureBox.Image = image;
        }

        private void PictureViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
