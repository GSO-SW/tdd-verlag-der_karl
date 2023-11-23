using System;
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
        private string iSBN;
        private string iSBN13;
        private string iSBN10;

        public Buch(string autor, string titel, int auflage) : this(autor, titel)
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
        }

        public int Auflage
        {
            get { return auflage; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht zu klein sein.");
                }
                else
                {
                    auflage = value;
                }
            }
        }
        public string autoNeu
        {
            get { return autoNeu; }
        }
        public string ISBN
        {
            get { return iSBN; }
            set {
                iSBN = value;
            }
        }
        public string ISBN10
        {
            get {
                
                    iSBN10 = iSBN.Substring(4,11).Replace("-", "");
                    int x = 10;
                    int count = 0;                   
                    for (int i = 0; i < iSBN10.Length; i++)
                    {
                        count += Convert.ToInt32(iSBN10[i]) * x;
                        
                        x += -1;
                    }
                    count = 11 - (count % 11);
                    iSBN10 += count;
                    return iSBN10;
                
            }
        }
        public string ISBN13 
        {
            get 
            {
                if (iSBN.Length == 17)
                {                   
                    iSBN13 = iSBN.Replace("-", "");
                }
                else if (iSBN.Length == 16)
                {
                    int x = 1;
                    int count = 0;
                    iSBN13 = iSBN.Replace("-", "");
                    for (int i = 0; i < 16; i++)
                    {
                        if (x == 1) count += Convert.ToInt32(iSBN13[i]) * 3;
                        else count += Convert.ToInt32(iSBN13[i]);
                        x = x * -1;
                    }
                    iSBN13 += 10 - (count % 10 );
                }
                return iSBN13;
            }
        }
    }
}
