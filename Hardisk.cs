using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    
   
    /// <summary>
    /// Abstract superklasse til de to harddisktyper.
    /// </summary>
   public abstract class Hardisk : Lagringsenhed
    {
        protected int spindelHastighed;

        public int SpindelHastighed
        {
            get { return spindelHastighed; }
            set
            {
                if (value == 4200 || value == 5400 || value == 7200 || value == 10000 || value == 15000)

                    spindelHastighed = value;
                else throw new ArgumentException("Det nummer er ikke gyldigt");
            }
        }
       
    }
   public class InternHarddisk : Hardisk
   {
       private string formFaktor;

       public string FormFaktor
       {
           get { return formFaktor; }
           set
           {
               if (value == "2.5\"" || value == " 3.5\" " || value == "5.25\"")
                   formFaktor = value;
           }

       }
       //Konstruktor for InterneHarddiske
       public InternHarddisk(string formFaktor, int spindelHastighed, int kapacitet, string produktNavn,
                                Producent producent, int produktKode, decimal pris)           
       {
           this.FormFaktor = formFaktor;
           this.SpindelHastighed = spindelHastighed;
           this.Kapacitet = kapacitet;
           this.Pris = pris;
           this.ProduktNavn = produktNavn;
           this.Producent = producent;
           this.ProduktKode = produktKode;
           ProduktKartotek.GetProduktKartotek().TilføjeProdukt(this);
         
       }
       public override string ToString()
       {
           return "\n\nProducent-navn: " + Producent.ProducentNavn + "\nProduktNavn: " + ProduktNavn 
                    + "\nFormFaktor: " + FormFaktor + "\nSpindelHastighed  " + SpindelHastighed +
                    "\nKapacitet: " + Kapacitet + "\nProduktKode: " +ProduktKode + "\nPris: " + Pris;
       }
   }
   public class EksternHarddisk : Hardisk
   {
       private int højde;

       public int Højde
       {
           get { return højde; }
           set { højde = value; }
       }
       private int dybde;

       public int Dybde
       {
           get { return dybde; }
           set { dybde = value; }
       }
       private int brede;

       public int Brede
       {
           get { return brede; }
           set { brede = value; }
       }
       //Konstruktor for Eksterne harddiske
       public EksternHarddisk(int højde, int dybde, int brede, int spindelhastighed, int kapacitet,
                                string produktNavn,Producent procent, int produktKode, decimal pris)
       {
           this.Højde = højde;
           this.Dybde = dybde;
           this.Brede = brede;
           this.SpindelHastighed = spindelhastighed;
           this.Kapacitet = kapacitet;
           this.ProduktNavn = produktNavn;
           this.Pris = pris;
           this.Producent = procent;
           this.ProduktKode = produktKode;
           ProduktKartotek.GetProduktKartotek().TilføjeProdukt(this);
           //Indkøbskurv2.GetIndkøbskurv().TilføjOrdre(this);
       }
       public override string ToString()
       {
           return "\n\nProducent-navn: " + Producent.ProducentNavn + "\nProduktNavn: " + ProduktNavn + "\nHøjde: " 
               + Højde + "\nDybbe: " +dybde+"\nBredde: "+ Brede + "\nSpindelHastighed:  " + SpindelHastighed 
               + "\nKapacitet: " + Kapacitet + "\nProduktKode: " +ProduktKode + "\nPris: " + Pris; 
       }

   }
    
   public class FlashHukommelse : Lagringsenhed
   {
       private string scureUSB;

       public string ScureUSB
       {
           get { return scureUSB; }
           set { scureUSB = value; }
       }
       //Konstruktor for Flashhukommelse
       public FlashHukommelse(string secureUSB, int kapacitet, string produktNavn, Producent producent,
                                int produktKode, decimal pris)
       {
           this.ScureUSB = secureUSB;          
           this.Kapacitet = kapacitet;          
           this.ProduktNavn = produktNavn;
           this.Pris = pris;
           this.Producent = producent;
           this.produktKode = produktKode;
           ProduktKartotek.GetProduktKartotek().TilføjeProdukt(this);
           ////Indkøbskurv2.GetIndkøbskurv().TilføjOrdre(this);
       }
       public override string ToString()
       {
           return "\n\nProducent-navn: " + Producent.ProducentNavn + "\nProduktNavn: " + ProduktNavn 
                    + "\nSecureUSB: " + ScureUSB + "\nKapacitet: " + Kapacitet + "\nProduktKode: " +ProduktKode
                    + "\nPris: " + Pris; 
       }

   }
  
    
}
