using System;

namespace Firsttask_Marat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Napište kolik je teď hodin (například: 12): ");
            Console.WriteLine("POZOR: Nepište desetinné číslo, to ukončí program!\n");
            int time;
            time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNapiste svoje jmeno: ");
            string name;
            name = Console.ReadLine( );

            if (time < 12 && time >= 0)
            {
                Console.Clear();
                Console.WriteLine("\nDobré ráno, ti přeji " +  name);
                Console.WriteLine("\nNyní je: " + time + "   hodin.");
            }

            else if (time >= 12 && time < 18)
            {
                Console.Clear();
                Console.WriteLine("\nDobré odpoledne, ti přeji " + name);
                Console.WriteLine("\nNyní je: " + time + "hodin.");
            }

            else if (time >= 18 && time < 25)
            {
                Console.Clear();
                Console.WriteLine("\nDobrý večer, ti přeji " + name);
                Console.WriteLine("\nNyní je: " + time + "hodin.");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Chyba! " + name + " , zkontrolujte prosím, zda jste zadali číslo od 0 do 24!");
                Console.WriteLine("Také prosím zkontrolujte zda jste zadali !JENOM! číslo a nenapsali jste omylem slovo hodin nebo tečku.");
            }



        }
    }
}
