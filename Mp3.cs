using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecteurMp3
{
    class Mp3
    {
        public string Titre { get; set; }
        public string Artiste { get; set; }
        public string Album { get; set; }
        public string Annee { get; set; }

        public string Repertoire { get; set; }

        public Mp3(string title, string artist, string album, string annee, string repertory)
        {
            this.Titre = title;
            this.Artiste = artist;
            this.Album = album;
            this.Annee = annee;
            this.Repertoire = repertory;
        }

        public Mp3()
        {

        }

    }
}
