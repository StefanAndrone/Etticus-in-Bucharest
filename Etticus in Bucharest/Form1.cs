using System;
using System.Collections;
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
        ButonPictura CurrentPlace, BackToMap;
        ArrayList MapEntries, Slots;
        ArrayList OrbsPiataVictoriei;
        ArrayList OrbsPiataRomana;
        ArrayList OrbsPiataUnirii;
        ArrayList OrbsUniversitate;
        ArrayList OrbsDristor;
        ArrayList OrbsObor;
        ArrayList OrbsPantelimon;
        ArrayList OrbsGaraDeNord;
        ArrayList OrbsIuliuManiu;
        public static ButonPictura OrbMeter;

        private void Form1_Load(object sender, EventArgs e)
        {         
            this.AutoScaleMode = AutoScaleMode.Dpi;
            OrbsPiataVictoriei = new ArrayList();
            OrbsPiataRomana = new ArrayList();
            OrbsUniversitate = new ArrayList();
            OrbsDristor = new ArrayList();
            OrbsObor = new ArrayList();
            OrbsPantelimon = new ArrayList();
            OrbsPiataUnirii = new ArrayList();
            OrbsGaraDeNord = new ArrayList();
            OrbsIuliuManiu = new ArrayList();
            OrbsPiataVictoriei.Add(new Orb(750, 250, this));
            OrbsPiataVictoriei.Add(new Orb(0, 350, this));
            OrbsObor.Add(new Orb(200, 130, this));
            OrbsIuliuManiu.Add(new Orb(0, 0, this));
            OrbsIuliuManiu.Add(new Orb(700, 240, this));
            OrbsIuliuManiu.Add(new Orb(350, 270, this));
            OrbsIuliuManiu.Add(new Orb(80, 330, this));
            OrbsIuliuManiu.Add(new Orb(490, 190, this));
            OrbsGaraDeNord.Add(new Orb(115, 320, this));
            OrbsGaraDeNord.Add(new Orb(195, 110, this));
            OrbsGaraDeNord.Add(new Orb(244, 0, this));
            OrbsGaraDeNord.Add(new Orb(430, 390, this));
            OrbsGaraDeNord.Add(new Orb(780, 210, this));
            OrbsGaraDeNord.Add(new Orb(0, 400, this));
            OrbsPiataUnirii.Add(new Orb(30, 30, this));
            OrbsPiataUnirii.Add(new Orb(257, 242, this));
            OrbsPiataUnirii.Add(new Orb(600, 300, this));
            OrbsUniversitate.Add(new Orb(700, 30, this));
            OrbsUniversitate.Add(new Orb(70, 320, this));
            OrbsUniversitate.Add(new Orb(510, 290, this));
            OrbsPiataRomana.Add(new Orb(756, 17, this));
            OrbsPantelimon.Add(new Orb(200, 315, this));
            OrbsPantelimon.Add(new Orb(790, 400, this));
            OrbsDristor.Add(new Orb(320, 90, this));
            OrbsDristor.Add(new Orb(790, 0, this));
            this.Width = 815;
            this.Height = 520;
            OuterSpace = new ButonPictura("OuterSpace.jfif", 0, 0, 800, 500, this, do_nothing);
            Play = new ButonPictura("Play.png", 350, 350, 100, 50, this, Play_Click);
            Orb orb = new Orb(6, 6, this);
        }

        public void do_nothing(object sender, EventArgs e)
        {
            return;
        }
        public void Play_Click(object sender, EventArgs e)
        {
            Description = new ButonPictura("Description.png", 0, 0, 800, 500, this, do_nothing);
            Play.front();
            Play.setClick(Play_Click_2);
        }

        public void Play_Click_2(object sender, EventArgs e)
        {
            Description.disappear();
            OuterSpace.disappear();
            Play.disappear();
            CurrentPlace = new ButonPictura("-", 0, 0, 800, 430, this, do_nothing);
            BackToMap = new ButonPictura("BackToMap.png", 10, 420, 50, 50, this, BackToMap_Click);
            MapEntries = new ArrayList();
            Slots = new ArrayList();
            PiataVictorieiMapEntry = new ButonPictura("PiataVictorieiMapEntry.png", 0, 0, 275, 160, this, PiataVictorieiMapEntry_Click);
            MapEntries.Add(PiataVictorieiMapEntry);
            PiataRomanaMapEntry = new ButonPictura("PiataRomanaMapEntry.png", 275, 0, 275, 160, this, PiataRomanaMapEntry_Click);
            MapEntries.Add(PiataRomanaMapEntry);
            PiataUniriiMapEntry = new ButonPictura("PiataUniriiMapEntry.png", 0, 160, 275, 160, this, PiataUniriiMapEntry_Click);
            MapEntries.Add(PiataUniriiMapEntry);
            OborMapEntry = new ButonPictura("OborMapEntry.png", 0, 320, 275, 160, this, OborMapEntry_Click);
            MapEntries.Add(OborMapEntry);
            UniversitateMapEntry = new ButonPictura("UniversitateMapEntry.png", 275, 160, 275, 160, this, UniversitateMapEntry_Click);
            MapEntries.Add(UniversitateMapEntry);
            DristorMapEntry = new ButonPictura("DristorMapEntry.png", 550, 0, 275, 160, this, DristorMapEntry_Click);
            MapEntries.Add(DristorMapEntry);
            GaraDeNordMapEntry = new ButonPictura("GaraDeNordMapEntry.png", 550, 160, 275, 160, this, GaraDeNordMapEntry_Click);
            MapEntries.Add(GaraDeNordMapEntry);
            IuliuManiuMapEntry = new ButonPictura("IuliuManiuMapEntry.png", 275, 320, 275, 160, this, IuliuManiuMapEntry_Click);
            MapEntries.Add(IuliuManiuMapEntry);
            PantelimonMapEntry = new ButonPictura("PantelimonMapEntry.png", 550, 320, 275, 160, this, PantelimonMapEntry_Click);
            MapEntries.Add(PantelimonMapEntry);
            Slots.Add(new ButonPictura("Brown.png", 0, 410, 800, 70, this, do_nothing));
            Slots.Add(new ButonPictura("Black.png", 100, 420, 50, 50, this, do_nothing));
            for(int i = 200; i <= 550; i += 66)
            {
                Slots.Add(new ButonPictura("Black.png", i, 420, 50, 50, this, do_nothing));
            }
            Slots.Add(new ButonPictura("Black.png", 620, 430, 150, 10, this, do_nothing));
            Slots.Add(new ButonPictura("OrbMeter.png", 645, 445, 100, 20, this, do_nothing));
            OrbMeter = new ButonPictura("Pink.png", 620, 430, 0, 10, this, do_nothing);
            Slots.Add(OrbMeter);
            ButonPictura.disappearVector(Slots);
        }

        public void PiataVictorieiMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsPiataVictoriei, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("PiataVictoriei.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void PiataRomanaMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsPiataRomana, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("PiataRomana.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void PiataUniriiMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsPiataUnirii, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("PiataUnirii.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void UniversitateMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsUniversitate, true);        
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("Universitate.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void IuliuManiuMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsIuliuManiu, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("IuliuManiu.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void PantelimonMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsPantelimon, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("Pantelimon.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void DristorMapEntry_Click(object sender, EventArgs e)
        {    
            Orb.appearVector(OrbsDristor, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("Dristor.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void OborMapEntry_Click(object sender, EventArgs e)
        {
            Orb.appearVector(OrbsObor, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("Obor.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void GaraDeNordMapEntry_Click(object sender, EventArgs e)
        {   
            Orb.appearVector(OrbsGaraDeNord, true);
            ButonPictura.appearVector(Slots, true);
            BackToMap.appear(true);
            CurrentPlace.setImage("GaraDeNord.png");
            ButonPictura.disappearVector(MapEntries);
        }

        public void BackToMap_Click(object sender, EventArgs e)
        {
            ButonPictura.disappearVector(Slots);
            BackToMap.disappear();
            ButonPictura.appearVector(MapEntries, true);
            Orb.disappearVector(OrbsPiataVictoriei);
            Orb.disappearVector(OrbsDristor);
            Orb.disappearVector(OrbsPantelimon);
            Orb.disappearVector(OrbsPiataRomana);
            Orb.disappearVector(OrbsUniversitate);
            Orb.disappearVector(OrbsObor);
            Orb.disappearVector(OrbsPiataUnirii);
            Orb.disappearVector(OrbsGaraDeNord);
            Orb.disappearVector(OrbsIuliuManiu);
        }
    }
}
