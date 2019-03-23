using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SchoolManagement
{
    static class Picture
    {
        public static byte[] PictureBoxToByte(PictureBox pictureBox)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imgByte = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgByte, 0, imgByte.Length);

            return imgByte;
        }

        public static void ByteToPictureBox(PictureBox picturBox, byte[] photoByte)
        {
            System.IO.MemoryStream mem = new System.IO.MemoryStream(photoByte);
            picturBox.Image = Image.FromStream(mem);
        }
    }
}
