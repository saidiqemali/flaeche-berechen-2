using System;

namespace FlaecheBerechnen
{
    class Programm
    {
        static void Main(string[] args)
        {
            int auswahl;
            double laenge;
            double breite;
            double R;
            double ergebnis;
            double pii = 3.1415;
            double ergebinsr;
            double hohe;
            double seiteA;
            double ergebnis3;

            Console.WriteLine("Was für eine Fläche willst du mit mir berechen ?");
            Console.WriteLine("kreis (1), rechteck (2) oder dreieck(3) ?");
            auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                case 1:
                    Console.WriteLine("Bitte den Radius angeben:");
                    R = Convert.ToDouble(Console.ReadLine());
                    ergebnis = pii * (R * R);
                    Console.WriteLine($"Die Fläche beträgt: {ergebnis}");
                    break;

                case 2:
                    Console.WriteLine("Bitte die laenge angeben:");
                    laenge = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte die breite angeben:");
                    breite = Convert.ToDouble(Console.ReadLine());
                    ergebinsr = laenge * breite;
                    Console.WriteLine($"Die Fläche beträgt: {ergebinsr}");
                    break;
                case 3:
                    Console.WriteLine("Bitte die Höhe angeben:");
                    hohe = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte die Seite A angeben:");
                    seiteA = Convert.ToDouble(Console.ReadLine());
                    ergebnis3 = (hohe * seiteA) / 2;
                    Console.WriteLine($"Die Fläche beträgt:{ergebnis3}");
                    break;


            }




        }
    }
}
