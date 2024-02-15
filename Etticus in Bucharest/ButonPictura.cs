using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etticus_in_Bucharest
{
    public class ButonPictura
    {
        private PictureBox p;

        public ButonPictura(String filename, int x, int y, int height, int width, Form1 f)
        {
            filename = "../../img/" + filename;
            p = new PictureBox();
            p.Image = Image.FromFile(filename);
            p.Visible = true;
            p.Location = new Point(x, y);
            p.Height = height;
            p.Width = width;
            f.Controls.Add(p);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
