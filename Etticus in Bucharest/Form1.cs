using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etticus_in_Bucharest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ButonPictura b = new ButonPictura("PiataVictorieiMapEntry.png", 0, 0, 100, 100, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vezi ca nu e bine");
            }
        }

    }
}
