using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Registration
{
    public partial class WebCamCapture : Form
    {
        private WebCam w;
        private PictureBox img;


        public WebCamCapture(PictureBox img)
        {
            InitializeComponent();

            w = new WebCam(pictureBox_ProfileImage);
            w.StartWebCam();
            this.img = img;

        }

        private void btn_CaptureImagetoBox_Click(object sender, EventArgs e)
        {
            img.Image = pictureBox_ProfileImage.Image;
            this.Hide();
        }

        private void WebCamCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            w.StopWebCam();
        }
    }
}
