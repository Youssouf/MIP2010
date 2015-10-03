using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mip2011
{
    class Program
    {
        static void Main(string[] args)
        {

            // MIP, Youssouf Souare og Christian Bundgaard Kjær, Januar 2011. 
            // De følgende er hardcodede eksempler.
            Producent pc = new Producent("LaCie", "http://www.lacie.com");
            Producent pc1 = new Producent("Samsung", "http://www.samsung.com");
            Producent pc2 = new Producent("WD", "http://www.westerndigital.com");
            Producent pc3 = new Producent("HTC", "http://www.htc.com");

            EksternHarddisk ex1 = new EksternHarddisk(29, 109, 59, 5400, 300, "Rugged", pc, 1, 869);
            EksternHarddisk ex2 = new EksternHarddisk(11, 109, 59, 7200, 160, "Stark Mobile Harddrive", pc, 2, 609);
            InternHarddisk ter1 = new InternHarddisk("2,5\"", 4200, 200, "Spinpoint MP4", pc1, 3, 200);
            InternHarddisk ter2 = new InternHarddisk("3,5\"", 7200, 350, "Spinpoint MP7", pc1, 4, 600);
            FlashHukommelse fl1 = new FlashHukommelse("yes", 16, "Smartcard", pc2, 5, 249);
            

            

            //Følgende ordrer og tilføjelser af disse til indkøbskurven kan udkommenteres,
            //hvis programmet ønskes startet med tom kurv

            Ordre ord = new Ordre(ex1, 3),
                  ord2 = new Ordre(ter1, 1),
                  ord3 = new Ordre(fl1, 2),
                  ord4 = new Ordre(ex1, 3),
                  ord5 = new Ordre(ex2, 3);


            List<Ordre> p_order = new List<Ordre>()
            {
                ord, ord2, ord3, ord4, ord5
            };
            foreach (Ordre item in  p_order)
            {
                Indkøbskurv.GetIndkøbskurv().TilføjOrdre(item);
            }

            List<Producent> producent = new List<Producent>()
            {
                pc, pc1, pc2
            };
            foreach (Producent p in producent)
            {
                ProducentKartotek.GetProducentKartotek().ToString();
            }
            // Menu til afvikling af programmet.
            bool end = false;
            while (end == false)
            {
                Console.WriteLine("Valgmuligheder:");
                Console.WriteLine("");
                Console.WriteLine("Tryk 1 for at søge på produktkode");
                Console.WriteLine("Tryk 2 for at søge på prisinterval");
                Console.WriteLine("Tryk 3 for at søge efter kapacitet");
                Console.WriteLine("Tryk 4 for at søge på fritekst");
                Console.WriteLine("Tryk 5 for at se indkøbskurven");
                Console.WriteLine("Tryk 6 for at tilføje et produkt til indkøbskurven");
                Console.WriteLine("Tryk 7 for at se producent list");
                //Console.WriteLine("Tryk 7 for at fjerne et produkt fra indkøbskurven");
                Console.WriteLine("Tryk andet tal for at afslutte");
                int i = int.Parse(Console.ReadLine());

                // De forskellige funktioner specificeret i opgaven
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Indtast produktkoden");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Følgende Produkt passer til søgningen");
                        Console.WriteLine(ProduktKartotek.GetProduktKartotek().FindeProduktMedProduktKodeX(a).ToString());
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Skriv en min pris");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv en max pris");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Følgende Produkter passer til søgningen:");
                        Console.WriteLine("");
                        Console.WriteLine(ProduktKartotek.GetProduktKartotek().UdprintProduktEfterPrisinterval(b, c));
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Skriv en minimums kapacitet i GB");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Følgende Produkter passer til søgningen:");
                        Console.WriteLine("");
                        Console.WriteLine(ProduktKartotek.GetProduktKartotek().UdprintProduktEfterAngivetMinimumKapcitet(d));
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("Skriv et Produktnavn, Producentnavn eller en del af et af disse");
                        string e = Console.ReadLine();
                        Console.WriteLine("Følgende Produkter passer til søgningen:");
                        Console.WriteLine("");
                        Console.WriteLine(ProduktKartotek.GetProduktKartotek().UdprintProduktEfterSøgning(e));
                        Console.WriteLine("");
                        break;
                    case 5:
                         Indkøbskurv.GetIndkøbskurv().ToString();
                        Console.WriteLine(Indkøbskurv.GetIndkøbskurv().ToString());
                        break;
                    case 6:
                        Console.WriteLine("Skriv ProduktKoden for et produkt du vil tilføje til indkøbskurven."
                        +"\n(hint: 1-5 findes i systemet)");
                        int f = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast antal du ønsker at tilføje til indkøbskurven");
                        int g = int.Parse(Console.ReadLine());
                        Ordre mmm = new Ordre(ProduktKartotek.GetProduktKartotek().FindeProduktMedProduktKodeX(f), g);
                        Indkøbskurv.GetIndkøbskurv().TilføjOrdre(mmm);
                        Indkøbskurv.GetIndkøbskurv().ToString();
                        Console.WriteLine(Indkøbskurv.GetIndkøbskurv().ToString());
                        break;
                    case 7:
                        Console.WriteLine(ProducentKartotek.GetProducentKartotek().ToString());
                        break;
                    
                    default:
                        Console.WriteLine("Bye bye");
                        end = true;
                        break;
                }
           
                Console.WriteLine("");
            }

        }
    }
}