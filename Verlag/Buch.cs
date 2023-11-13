using System;

namespace Verlag
{
    public class Buch
    {
        private string titel;
        private string autor;
        private int auflage;

        public Buch(string autor, string titel, int auflage)
        {
            this.titel = titel;
            this.autor = autor;
            this.auflage = auflage;

        }

        public Buch(string autor, string titel)
        {
            this.titel = titel;
            this.autor = autor;
            this.auflage = 1;
        }

        public string Titel
        {
            set { titel = value; }
            get { return titel; }
        }

        public string Autor
        {
            set { autor = value; }
            get { return autor; }
        }

        public int Auflage
        {
            set {  auflage = value; }
            get { return auflage; }

        }


    }

}





	
