using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    //Indkøbskurven som singleton for at sikre der kun findes én.
    class Indkøbskurv
    {
        private static Indkøbskurv indkøb = new Indkøbskurv();
        private VoresListe<Ordre> ordreliste;
        private Ordre ordre;
        
        public Ordre Ordre
        {
            get { return ordre; }
            set { ordre = value; }
        }
        
        public VoresListe<Ordre> Ordreliste
        {
            get { return ordreliste; }
            set { ordreliste = value; }
        }
        private Indkøbskurv()
        {
            this.Ordreliste = new VoresListe<Ordre>();
        }
        public static Indkøbskurv GetIndkøbskurv()
        {
            return indkøb;
        }
        //metode til tilføjelse af nye ordrer til indkøbskurven.
        public void TilføjOrdre(Ordre pt)
        {
            this.ordreliste.Add(pt);
        }
        //Udregning af levering og Totalpris.
        public decimal Levering{get;set;}
        public decimal TotalPris()
        {
            decimal levering =0;
            decimal TotalPris = 0;
            foreach (Ordre ord in ordreliste)
            {
                
                if (ord.Subtotal() <= 250)
                { 
                    levering = levering+50; 
                }
                else if (ord.Subtotal() > 250 && ord.Subtotal() <= 500)
                {
                    levering = levering+25;
                }
                else
                {
                    levering += 0;
                }
                TotalPris += ord.Subtotal();
            }
            this.Levering = levering;
            return TotalPris + Levering;
        }

        //printer indkøbskurven til konsollen
        public override string ToString()
        {
            string resultat;
            StringBuilder builder = new StringBuilder();
            foreach (Ordre pt in this.ordreliste)
            {
                builder.Append(pt).Append(" ");
            }
            resultat = builder.ToString();
            return "\n                             Indkøbskurv:" +
                "\n--------------------------------------------------------------------------------" 
                + resultat
                +"\nLevering".PadRight(35,'_') + this.Levering+" kr."
                +"\nTotalpris".PadRight(35,'_') +TotalPris()+" kr."
                + 
                "\n---------------------------------------------------------------------------------";

        }
      
    }
}
    