﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string autorNeu;

        public Buch(string autor, string titel, int auflage):this(autor, titel)
        {
            this.auflage = auflage;
        }
        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
            auflage = 1;
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Titel
        {
            get { return titel; } 
            set { titel = value; }
        }
        
        public int Auflage
        {
            get { return auflage; }
            set { auflage = value; }
        } 
        public string autoNeu
        {
            get { return autoNeu; }
            set { autoNeu = value; }
        }

    }
}
