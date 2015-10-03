using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    //Ordre klasse til indkøbskurven.
    public class Ordre
    {
        public Produkt Produkt { get; set; }
        public int Antal { get; set; }
        
        public Ordre(Produkt p, int a)
        {
            this.Antal = a;
            this.Produkt = p;   
        }
        //beregning af subtotal.
        public decimal Subtotal()
        {
            return this.Produkt.Pris * this.Antal;
        }

        //Yderligere start på Implementation af TB/GB krav.
        //den er dog aldrig sat i forbindelse med andet.
        //private VoresListe<Lagringsenhed> lagring;
        //public double KapacitetKrav()
        //{
        //    string gb = "GB";
        //    string tb = "TB";
        //    double kapacitet = 0;
        //    foreach (Lagringsenhed pt in lagring)
        //    {
        //        //double kapacitet = pt.Kapacitet;
        //        if (kapacitet < 1024)
        //        {
        //            string.Concat(kapacitet, gb);
        //        }
        //        else if (kapacitet > 1024)
        //        {
        //            string.Concat(Math.Floor(kapacitet / 1000), tb);
        //        }
        //    }
        //    return kapacitet;
        //}
        
       
        public override string ToString()
        {
            return "\n" + Antal + " stk. " + Produkt.Producent.ProducentNavn + " " + Produkt.ProduktNavn +" " 
                + this.Subtotal() + " kr.\n";
            
            //tidlige forsøg på at få padding til at lege med.
            //inden sandheden om strings'ne gik op for os.
           
            //return "\n"+ Antal + " stk. " + Produkt.Producent.ProducentNavn + " " 
            //+ Produkt.ProduktNavn+ Lager.Kapacitet+ " " + this.Subtotal() +" kr.\n";
            
            //return string.Format("{0,-1}|{1,-6}|{2&&3,-28}","\n" + Antal + " stk. " 
            //+ Produkt.Producent.ProducentNavn + " " + Produkt.ProduktNavn.PadRight(30) + " " 
            //+ this.Subtotal(). + " kr.\n");
        }

    } 
}
