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

        ButonPictura OuterSpace, Play, Description;
        ButonPictura PiataVictorieiMapEntry;
        ButonPictura PiataRomanaMapEntry;
        ButonPictura PiataUniriiMapEntry;
        ButonPictura OborMapEntry;
        ButonPictura UniversitateMapEntry;
        ButonPictura DristorMapEntry;
        ButonPictura GaraDeNordMapEntry;
        ButonPictura IuliuManiuMapEntry;
        ButonPictura PantelimonMapEntry;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 801;
            this.Height = 505;
            OuterSpace = new ButonPictura("OuterSpace.jfif", 0, 0, 801, 505, this, do_nothing);
            Play = new ButonPictura("Play.png", 350, 350, 100, 50, this, Play_Click);     
        }

        public void do_nothing(object sender, EventArgs e)
        {
            return;
        }

        public void Play_Click(object sender, EventArgs e)
        {
            Description = new ButonPictura("Description.png", 0, 0, 801, 505, this, do_nothing);
            Play.front();
            Play.setClick(Play_Click_2);
        }

        public void Play_Click_2(object sender, EventArgs e)
        {
            Description.disappear();
            OuterSpace.disappear();
            Play.disappear();
            PiataVictorieiMapEntry = new ButonPictura("PiataVictorieiMapEntry.png", 0, 0, 267, 155, this, do_nothing);
            PiataRomanaMapEntry = new ButonPictura("PiataRomanaMapEntry.png", 267, 0, 267, 155, this, do_nothing);
            PiataUniriiMapEntry = new ButonPictura("PiataUniriiMapEntry.png", 0, 155, 267, 155, this, do_nothing);
            OborMapEntry = new ButonPictura("OborMapEntry.png", 0, 310, 267, 155, this, do_nothing);
            UniversitateMapEntry = new ButonPictura("UniversitateMapEntry.png", 267, 155, 267, 155, this, do_nothing);
            DristorMapEntry = new ButonPictura("DristorMapEntry.png", 534, 0, 267, 155, this, do_nothing);
            GaraDeNordMapEntry = new ButonPictura("GaraDeNordMapEntry.png", 534, 155, 267, 155, this, do_nothing);
            IuliuManiuMapEntry = new ButonPictura("IuliuManiuMapEntry.png", 267, 310, 267, 155, this, do_nothing);
            PantelimonMapEntry = new ButonPictura("PantelimonMapEntry.png", 534, 310, 267, 155, this, do_nothing);
        }
    }
}
