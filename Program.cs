using System;

namespace IDP_assg_3
{
    public class Grundämne
    {
        public string namn;
        public int atomnummer;
        public string typ;
        public double smältpunkt;
        public double kokpunkt;
        public Grundämne(string namn, int atomnummer, string typ, double smältpunkt, double kokpunkt)
        {
            this.namn = namn;
            this.atomnummer = atomnummer;
            this.typ = typ;
            this.smältpunkt = smältpunkt;
            this.kokpunkt = kokpunkt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Grundämne syre = new Grundämne("syre", 8, "ickemetall", 54.36, 90.188);
            Grundämne järn = new Grundämne("järn", 26, "metall", 1811, 3134);
            Grundämne guld = new Grundämne("guld", 79, "metall", 1337.33, 3243);
            Console.WriteLine(syre.namn + " " + syre.smältpunkt);
        }
    }
}