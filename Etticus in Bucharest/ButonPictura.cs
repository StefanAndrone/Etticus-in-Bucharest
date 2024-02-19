using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etticus_in_Bucharest
{
    public class ButonPictura
    {
        private PictureBox p;

        public PictureBox getP()
        {
            return p;
        }

        public ButonPictura(String filename, int x, int y, int width, int height, Form1 f, Action<object, EventArgs> func)
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
            p.Click += (s, e) => func(s, e);
        }
    }
}
