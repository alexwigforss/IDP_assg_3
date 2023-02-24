using System;
using System.Diagnostics;
using static System.Console;

namespace IDP_assg_3
{
    public class Grundämne // Upg 1
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
        public void Print() // Upg 3
        {
            Write($"Grundämne: {namn}\n  ");
            Write($"typ: {typ}\n  ");
            Write($"smältpunkt: {smältpunkt} K\n  ");
            Write($"kokpunkt: {kokpunkt} K\n\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Upg 2
            Grundämne syre = new Grundämne("syre", 8, "ickemetall", 54.36, 90.188);
            Grundämne järn = new Grundämne("järn", 26, "metall", 1811, 3134);
            Grundämne guld = new Grundämne("guld", 79, "metall", 1337.33, 3243);

            Grundämne[] grundämnen = new Grundämne[] // upg 4
            {
                syre,järn,guld,
                new Grundämne("väte", 1, "ickemetall", 13.99, 20.271),
                new Grundämne("brom", 35, "ickemetall", 265.8, 332.0),
                new Grundämne("kvicksilver", 80, "metall", 234.3210, 629.88)
            };

            foreach (Grundämne grund in grundämnen) // Upg 5
            {
                grund.Print();
            }

            foreach (Grundämne grund in grundämnen) // Upg 6
            {
                if (grund.typ == "metall") Write($"{grund.namn} ");
            }
            WriteLine($"\när alla metaller.\n");

            double tröskel = 273.16;
            foreach (Grundämne grund in grundämnen) // Upg 7
            {
                if (grund.smältpunkt < tröskel && grund.kokpunkt > tröskel) Write($"{grund.namn} ");
            }
            WriteLine($"\nhar en smältpunkt lägre än & en kokpunkt högre än {tröskel} K.\n");

            Write($"\nTryck på valfri tangent för att avsluta: ");
            ReadKey();
        }
    }
}