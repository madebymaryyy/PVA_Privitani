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
            Console.WriteLine("POZOR: Nepište desetinné číslo a písmena, to ukončí program!\n");
            int time;
            time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNapište svoje jméno: ");
            string name;
            name = Console.ReadLine( );

            string timeString;

            if (time < 12 && time >= 1)
            {
                timeString = "ráno";
            }

            else if (time >= 12 && time < 18)
            {
                timeString = "odpoledne";
            }

            else if (time >= 18 && time < 25)
            {
                timeString = "večer";
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Chyba! " + name + " , zkontrolujte prosím, zda jste zadali číslo od 0 do 24!");
                Console.WriteLine("Také prosím zkontrolujte zda jste zadali !JENOM! číslo a nenapsali jste omylem slovo hodin nebo tečku.");
                return;
            }

            Console.WriteLine("\nDobrý " + timeString +  ", ti přeji, " + name);
            Console.WriteLine("Nyní je: " + time + "hodin.");
        }
    }
}
