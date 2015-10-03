using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    //Superklassen. Toppen af hierakiet.
    public abstract class Produkt
    {
        protected Producent producent;

        public Producent Producent
        {
            get { return producent; }
            set { producent = value; }
        }
        protected string produktNavn;

        public string ProduktNavn
        {
            get { return produktNavn; }
            set { produktNavn = value; }
        }
        protected decimal pris;

        public decimal Pris
        {
            get { return pris; }
            set {
                if (pris < 0)
                   throw new ArgumentException(" Prisen må ikke være negatif");

                else { pris = value; }
            }
        }

        protected internal int produktKode;

        public int ProduktKode
        {
            get { return produktKode; }
            set { produktKode = value; }
        }

        //Tidligt forgæves forsøg på at trække kapacitet op i produkt,
        //for at override det i Lagringsenhed.
        //private int kapacitet = null;
        //public int Kapacitet 
        //{
        //    get { return kapacitet; }
        //    set { kapacitet = value;}
        //}

        public override string ToString()
        {
            return "\n Produkt navn: " + ProduktNavn+ "\nPris: " + Pris;
        }
    }
}
