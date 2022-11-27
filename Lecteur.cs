using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecteurMp3
{
    class Lecteur
    {
        public string cheminDeBase { get; set; }
        public bool change { get; set; }
        public Random alea { get; set; }
        public List<Mp3> listMP3 { get; set; }

        public Lecteur (List<Mp3> lesmusiques)
        {
            this.listMP3 = lesmusiques;
        }
        public Lecteur()
        {
            this.alea = new Random();
        }

        public Mp3 Joue(List<Mp3> listMp3)
        {
            Mp3 leson = new Mp3();
            int mIndex = alea.Next(listMp3.Count);
            leson = listMp3[mIndex];
            return leson;
        }
    }
}
