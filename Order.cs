﻿using System;
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
