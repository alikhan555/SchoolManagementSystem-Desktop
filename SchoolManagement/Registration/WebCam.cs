using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.Drawing;

namespace SchoolManagement.Registration
{
    public class WebCam
    {
        FilterInfoCollection Devices;
        VideoCaptureDevice Frame;

        PictureBox PictureBox;          //change

        public WebCam(PictureBox pictureBox)        //change
        {
            this.PictureBox = pictureBox;
        }

        void StartCam()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            Frame = new VideoCaptureDevice(Devices[0].MonikerString);
            Frame.NewFrame += new AForge.Video.NewFrameEventHandler(NewFrameEvent);
            Frame.Start();
        }

        void NewFrameEvent(object send, NewFrameEventArgs e)
        {
            try
            {
                Bitmap varBmp = new Bitmap((Image)e.Frame.Clone());
                PictureBox.Image = varBmp.Clone(new RectangleF(320, 0, 400, 400), varBmp.PixelFormat);

                //PictureBox.Image = varBmp.Clone(new RectangleF(320, 0, 270, 300), varBmp.PixelFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void StartWebCam()
        {
            StartCam();
        }

        public void StopWebCam()
        {
            Frame.Stop();
        }
    }
}
