﻿using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spel = true;
            Random generator = new Random();
            int rattSvar = generator.Next(1, 11); //Slumpmässigt nummer
            int forsok = 0;  //försök int
            string svar;  //svar string
            int nummerSvar = 0; // svar i nummer form
            Console.WriteLine("Gissa på en kordinat mellan 1 och 10");

            while (spel == true) //kör medans svaret inte är rätt
            {
                svar = Console.ReadLine();

                try
                {
                    nummerSvar = int.Parse(svar);
                }
                catch
                {
                    Console.WriteLine("Svara med nummer");
                }

                forsok++;

                if (nummerSvar <= 0 || nummerSvar >= 11)// om svaret är mindre än 1 eller större än 10 måste man gissa igen
                {
                    Console.WriteLine("Jag sa mellan 1 och 10!");
                }
                else if (nummerSvar == rattSvar)
                {
                    if (ratt() == 1)
                    {
                        Console.WriteLine("Hit!");
                        Console.WriteLine("Det tog dig " + forsok + " försök!");
                    }
                    Console.WriteLine("Vill du spela igen? \"JA\" eller \"NEJ\""); // kollar om spelaren vill spela igen
                    string startaOm = Console.ReadLine();
                    if (startaOm == "JA")
                    {
                        rattSvar = generator.Next(1, 11);
                        Console.WriteLine("Gissa på en kordinat mellan 1 och 10");
                        forsok = 0;
                    }
                    if (startaOm == "NEJ")
                    {
                        spel = false;
                    }
                    if (startaOm != "JA" && startaOm != "NEJ")
                    {
                        Console.WriteLine("Svara med \"JA\" eller \"NEJ\"");
                    }
                }
                else if (nummerSvar >= rattSvar + 3 || nummerSvar <= rattSvar - 3)
                {
                    Console.WriteLine("Miss!");
                    Console.WriteLine("Gissa på en ny kordinat");

                }
                else if (nummerSvar >= rattSvar || nummerSvar <= rattSvar)
                {
                    Console.WriteLine("Near MIss!");
                    Console.WriteLine("Gissa på en ny kordinat");
                }



            }
        }
        static int ratt()
        {
            int ratt = 1;
            if (ratt == 1)
            {
                return 1;
            }

            return 0;
        }

    }
}
