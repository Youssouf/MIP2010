using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
 public class Producent
    {
        private string producentNavn;

        public string ProducentNavn
        {
            get { return producentNavn; }
            set { producentNavn = value; }
        }
        private string url;

        public string Url
        {
            get { return url; }
            set {
                //Kravet om http:// på urls.
                if (value.StartsWith("http://"))
                    url = value;
                //Den nederste, blidere, løsning var at foretrække, mens vi kørte tests.
                //else throw new ArgumentException(" Url skal starte med http://");
                else url = "Url skal startes med http://";
                }            
        }
        
        public Producent(string producentNavn, string url)
        {
            this.ProducentNavn = producentNavn;
            this.Url = url;
            ProducentKartotek.GetProducentKartotek().TilføjeProducentTilListe(this);

        }
        public override string ToString()
        {
            return "\nProducentNavn:" + ProducentNavn+ "\nURl: " +Url;
        }


    }
}
