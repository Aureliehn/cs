using password;
using System;

namespace Generateur_mot_de_passe
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            int longueurMotPasse = outil.DemanderNombrePositifNonNul("quelle longueur de mot de passe ?");
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string alphabet = minuscules;
            string motDePasse = "";
            int l =alphabet.Length;
            Random random = new Random();

            for(int i=0;i<longueurMotPasse; i++)
            {
                int index = random.Next(0, l);
                //Console.WriteLine(alphabet[index]);
                motDePasse += alphabet[index];
            }
            

            Console.WriteLine("mot de passe : " + motDePasse);
        }
    }
}