using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    //Superklasse til Harddiske og flashukommelse. 
    //Sub-klasse til produkt som også skærme og printere ville være.
    public class Lagringsenhed : Produkt
    {
        protected int kapacitet;

        public int Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

    }
}
