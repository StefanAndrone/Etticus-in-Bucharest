using System;
using System.Collections;
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
        private EventHandler handler;

        public PictureBox getP()
        {
            return p;
        }

        public ButonPictura(String filename, int x, int y, int width, int height, Form1 f, Action<object, EventArgs> func)
        {
            if(!filename.Equals("-"))
                filename = "../../img/" + filename;
            p = new PictureBox();
            if(!filename.Equals("-"))
                p.Image = Image.FromFile(filename);
            p.Visible = true;
            p.Location = new Point(x, y);
            p.Height = height;
            p.Width = width;
            f.Controls.Add(p);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            handler = (s, e) => func(s, e);
            p.Click += handler;
            p.BringToFront();
        }

        public void front()
        {
            p.BringToFront();
        }

        public void disappear()
        {
            p.Visible = false;
        }

        public void appear(bool front)
        {
            p.Visible = true;
            if (front)
                p.BringToFront();
        }

        public void setClick(Action<object, EventArgs> func)
        {       
            p.Click -= handler;
            handler = (s, e) => func(s, e);
            p.Click += handler;
        }

        public void setImage(string filename)
        {
            filename = "../../img/" + filename;           
            p.Image = Image.FromFile(filename);
        }

        public static void appearVector(ArrayList list, bool front)
        {
            foreach (ButonPictura iterator in list)
            {
                iterator.appear(front);
            }
        }

        public static void disappearVector(ArrayList list)
        {
            foreach (ButonPictura iterator in list)
            {
                iterator.disappear();
            }
        }
    }
}
