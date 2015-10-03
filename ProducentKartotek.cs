using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
  public  class ProducentKartotek
    {
        //Er også lavet som singleton for kun at have ét kartotek
        private static ProducentKartotek producentKartotek = new ProducentKartotek();
        private VoresListe<Producent> producentListe;
      

        public VoresListe<Producent> ProducentListe
        {
            get { return producentListe; }
            set { producentListe = value; }
        }
       /* This is the private constructor meaning that it is not possible to instantiate
          the class outside the class */
        private ProducentKartotek()
        {
            this.producentListe = new VoresListe<Producent>();
        }
        
        //Get hele kartoteket
        public static ProducentKartotek GetProducentKartotek()
        {
            return producentKartotek;
        }
        
        //mulighed for at fjerne en producent.
        public void FjerneProducentFraListe(Producent pc)
        {
            if (producentListe.Contains(pc))
            {
                producentListe.Remove(pc);
            }
        }
        public void MoveProductFromList(Producent mp)
        {
            foreach (Producent item in producentListe)
            {
                if (item == mp)
                {
                    producentListe.Remove(item);
                }
            }
        }

        //mulighed for at tilføje en ny producent.
        public void TilføjeProducentTilListe(Producent pc)
        {
            if (!(producentListe.Contains(pc)))
            {
                this.producentListe.Add(pc);
            }
        }
        
        //Mulighed for udvidelse af program med en liste af producenter og deres Navn, samt Url.
        //Brugt til at teste kravet om Url.
        public override string ToString()
        {
            string resultat;
            StringBuilder builder = new StringBuilder();
            foreach (Producent pc in this.producentListe)
            {
                builder.Append(pc).Append(" ");
            }
            resultat = builder.ToString();

            return "\n                              ProducentKartotek:" +
                "\n----------------------------------------------------------------------------------" + resultat
                + "\n-----------------------------------------------------------------------------------";
        }

       // Another print method 
        public void PrintProduct()
        {
            string stResult = " Producent kartotek " + "\n-----------------------------------------------------";

            foreach (Producent item in producentListe)
            {
                Console.WriteLine(stResult+ "\n" + item);
            }
        }
    }
}
