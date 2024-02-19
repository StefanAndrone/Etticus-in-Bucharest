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
            this.Width = 801;
            this.Height = 505;
            ButonPictura OuterSpace = new ButonPictura("OuterSpace.jfif", 0, 0, 801, 505, this, OuterSpace_click);
            /*ButonPictura PiataVictorieiMapEntry = new ButonPictura("PiataVictorieiMapEntry.png", 0, 0, 267, 155, this);
            ButonPictura PiataRomanaMapEntry = new ButonPictura("PiataRomanaMapEntry.png", 267, 0, 267, 155, this);
            ButonPictura PiataUniriiMapEntry = new ButonPictura("PiataUniriiMapEntry.png", 0, 155, 267, 155, this);
            ButonPictura OborMapEntry = new ButonPictura("OborMapEntry.png", 0, 310, 267, 155, this);
            ButonPictura UniversitateMapEntry = new ButonPictura("UniversitateMapEntry.png", 267, 155, 267, 155, this);
            ButonPictura DristorMapEntry = new ButonPictura("DristorMapEntry.png", 534, 0, 267, 155, this);
            ButonPictura GaraDeNordMapEntry = new ButonPictura("GaraDeNordMapEntry.png", 534, 155, 267, 155, this);
            ButonPictura IuliuManiuMapEntry = new ButonPictura("IuliuManiuMapEntry.png", 267, 310, 267, 155, this);
            ButonPictura PantelimonMapEntry = new ButonPictura("PantelimonMapEntry.png", 534, 310, 267, 155, this);*/
        }

        public void OuterSpace_click(object sender, EventArgs e)
        {
            
        }
    }
}
