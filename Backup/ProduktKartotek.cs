using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    class ProduktKartotek
    {
        //Singleton. Kun én liste over produkter.
        private static ProduktKartotek produktKartotek = new ProduktKartotek();
        private VoresListe<Produkt> produktListe;
        private Produkt produkt;

        public Produkt Produkt
        {
            get { return produkt; }
            set { produkt = value; }
        }

        public VoresListe<Produkt> ProduktListe
        {
            get { return produktListe; }
            set { produktListe = value; }
        }

        private ProduktKartotek()
        {        
            this.produktListe = new VoresListe<Produkt>();
        }

        public static ProduktKartotek GetProduktKartotek()
        {
            return produktKartotek;
        }

        //mulighed for at fjerne produkter fra listen.
        public void fjerneProdukt(Produkt pt)
        {
            if (produktListe.Contains(pt))
            {
                produktListe.Remove(pt);
            }                     
        }

        //mulighed for at tilføje produkter til listen.
        public void TilføjeProdukt(Produkt pt)
        {
            if (!(produktListe.Contains(pt)))
            {
                produktListe.Add(pt);
            }
            
        }

        //metode til søgning på produktkode.
        public Produkt FindeProduktMedProduktKodeX(int a)
        {   
           foreach (Produkt pt in produktListe)
            {
                if (pt.ProduktKode == a)
                
                    produkt = pt;
            }
           return this.produkt;
           // else return Console.WriteLine("Intet produkt fundet");
        }

        //metode til søgning på pris interval.
        public VoresListe<Produkt> FindProduktMedPrisInterval(decimal a, decimal b)
        {
            VoresListe<Produkt> tempListe = new VoresListe<Produkt>();
            foreach (Produkt pt in produktListe)
            {
                if (pt.Pris >= a && pt.Pris <= b)
                {
                    tempListe.Add(pt);
                } 
            }
            return tempListe;
        }

        //Skriver resultatet af søgning på pris i konsol.
        public string UdprintProduktEfterPrisinterval(decimal a, decimal b)
        {
            string resultat;
            StringBuilder builder2 = new StringBuilder();
            foreach (Produkt pt in ProduktKartotek.GetProduktKartotek().FindProduktMedPrisInterval(a,b))
            {
                builder2.Append(pt).Append(" ");
            }

            resultat = builder2.ToString();
            return ("\n\n\nResultat af søgning efter prisinterval imellem "
                + a.ToString() + " og " + b.ToString() + " kroner" +
                "\n------------------------------------------------------------------------------------\n" 
                +resultat
                + "\n------------------------------------------------------------------------------------");
        }

        //Søgning på kapacitet.
        public VoresListe<Lagringsenhed> FindLagringsenhederMedMinimumKapacitet(int p)
        {
            VoresListe<Lagringsenhed> tempListe = new VoresListe<Lagringsenhed>();
            foreach (Lagringsenhed tp in produktListe)
            {
                if (tp.Kapacitet >= p)
                {
                    tempListe.Add(tp);
                }
            }
            return tempListe;  
        }
        //Udskriver søgning på kapacitet til konsol.
        public string UdprintProduktEfterAngivetMinimumKapcitet(int a)
        {
            string resultat;
            StringBuilder builder = new StringBuilder();
            foreach (Lagringsenhed pt in ProduktKartotek.GetProduktKartotek().FindLagringsenhederMedMinimumKapacitet(a))
            {
                builder.Append(pt).Append(" ");
            }

            resultat = builder.ToString();
            return ("\n\n\nResultat af søgning  med en angivet minimum-Kapacitet "
                + a.ToString() + " " +
                "\n------------------------------------------------------------------------------------\n" 
                + resultat
                + "\n------------------------------------------------------------------------------------");
        }

        //Søgning på string a chars.
        public VoresListe<Produkt> FindProduktSkriftligSøg(string b)
        {
            VoresListe<Produkt> tempListe = new VoresListe<Produkt>();
            foreach (Produkt pt2 in produktListe)
            {
                if ( pt2.ProduktNavn.Contains(b)||pt2.Producent.ProducentNavn.Contains(b))
                {
                    tempListe.Add(pt2);
                }
            }
            return tempListe;
        }
        //Udskriver søgningen på string af chars.
        public string UdprintProduktEfterSøgning(string b)
        {
            string resultat2;
            StringBuilder builder4 = new StringBuilder();
            foreach (Produkt pt2 in ProduktKartotek.GetProduktKartotek().FindProduktSkriftligSøg(b))
            {
                builder4.Append(pt2).Append(" ");
            }

            resultat2 = builder4.ToString();
            return ("\n\n\nResultat af søgning efter "
                + b.ToString() +
                "\n------------------------------------------------------------------------------------\n" 
                + resultat2
                + "\n------------------------------------------------------------------------------------");

        }
    
        //Brugtes i tidlig fase til at printe det komplette Produktkartotek.
        //Kunne hurtigt implementeres igen, hvis det blev nyttigt fremefter.
        //public override string ToString()
        //{
        //    string resultat;
        //    StringBuilder builder = new StringBuilder();
        //    foreach (Produkt kt in this.produktListe)
        //    {
        //        builder.Append(kt).Append(" ");
        //    }
        //    resultat = builder.ToString();
        //    return "\n                              ProduktKartotek:" +
        //        "\n----------------------------------------------------------------------------------" + resultat
        //        + "\n-----------------------------------------------------------------------------------";
        //}
    }
}
