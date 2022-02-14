using System;

namespace Nbr
{
    internal class Program
    {
        static int demanderNbr(int min, int max)
        {
            int reponse_nbr = min - 1;
            while ((reponse_nbr < min) || (reponse_nbr > max))
            {
                Console.WriteLine("entre un nbr entre : " + min + " et " + max);
                string reponse = Console.ReadLine();

                try
                {
                    reponse_nbr = int.Parse(reponse);
                    if ((reponse_nbr < min) || (reponse_nbr > max))
                    {
                        Console.WriteLine("ERREUR tu ne comprends rien c'est entre " + min + " et " + max);

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("pas bon");
                }
            }
            return reponse_nbr;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int NOMBRE_MIN = 0;
            const int NOMBRE_MAX = 10;
            int NOMBRE_A_TROUVER = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);
            int nombre = NOMBRE_MIN - 1;


            for (int nombreEssai = 5; nombreEssai > 0; nombreEssai--)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("tu as " + nombreEssai + " essai(s)");
                nombre = demanderNbr(NOMBRE_MIN, NOMBRE_MAX);

                if (NOMBRE_A_TROUVER > nombre)
                {
                    Console.WriteLine("le nbr a trouver est plus grand");
                }
                else if (NOMBRE_A_TROUVER < nombre)
                {
                    Console.WriteLine("le nbr a trouver est plus petit");
                }
                else
                {
                    Console.WriteLine("bravo tu as gagné le jackpot");
                    break;
                }
            }
            if (nombre != NOMBRE_A_TROUVER)
            {
                Console.WriteLine("perdu le nombre était : " + NOMBRE_A_TROUVER);
            }
        }

    }
}