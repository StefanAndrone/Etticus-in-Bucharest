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
    public class Orb
    {
        private ArrayList list;
        public Orb(int x, int y, Form1 form)
        {
            list = new ArrayList();
            for(int i = 1; i <= 5; i++) {
                list.Add(new ButonPictura("Pink.png", x + i - 1, y + 5 - i, 1, i * 2 - 1, form, collectOrb));
            }
            for (int i = 6; i <= 9; i++)
            {
                list.Add(new ButonPictura("Pink.png", x + i - 1, y + i - 5, 1, (10 - i) * 2 - 1, form, collectOrb));
            }
            ButonPictura.disappearVector(list);
        }

        public void appear(bool front)
        {
            ButonPictura.appearVector(list, front);
        }

        public void disappear()
        {
            ButonPictura.disappearVector(list);
        }

        public void collectOrb(object sender, EventArgs e)
        {
            Form1.OrbMeter.increaseWidth(6);
            ButonPictura.disposeOfVector(list);
            return;
        }

        public static void appearVector(ArrayList list, bool front)
        {
            foreach (Orb iterator in list)
            {
                iterator.appear(front);
            }
        }

        public static void disappearVector(ArrayList list)
        {
            foreach (Orb iterator in list)
            {
                iterator.disappear();
            }
        }
    }
}