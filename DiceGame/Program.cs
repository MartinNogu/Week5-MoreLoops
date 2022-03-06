using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib kumb mängija viskas rohkem
            //mängija kes viskab rohekm on mängu võitja
            //*täringuid visatakse 3 korda
            //programm kuulutab võitja.

            int userRandom;
            int cpuRandom;

            int userScore = 0;
            int cpuScore = 0;

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {

                userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Kasutaja viskas {userRandom}.");

                cpuRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpuRandom}.");

                if (userRandom > cpuRandom)
                {
                    userScore++;
                    Console.WriteLine("Kasutaja võitis selle roundi!");
                }
                else if (userRandom < cpuRandom)
                {
                    cpuScore++;
                    Console.WriteLine("Arvuti võitis selle roundi!");
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            if (userScore > cpuScore)
            {
                Console.WriteLine($"Kasutaja võitis {userScore} punktiga. Palju õnne!");
            }
            else if (userScore < cpuScore)
            {
                Console.WriteLine($"Arvuti võitis {cpuScore} punktiga!");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
        }
    }
}
        
