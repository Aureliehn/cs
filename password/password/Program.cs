using password;
using System;

namespace Generateur_mot_de_passe
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            const int NBR_MDP = 10;
            int longueurMotPasse = outil.DemanderNombrePositifNonNul("quelle longueur de mot de passe ?");
            Console.WriteLine();
            int choixAlphabet = outil.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1 : uniquement des minuscules\n" +
                "2 : des minuscules et des majuscules\n" +
                "3 : des lettres et des chiffres\n"+
                "4 : des lettres des chiffres et des caractères spéciaux\n"+
                "Votre choix : "
                , 1, 4);
            
            
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "1234567890";
            string caracteresSpeciaux = "#%-/";
            string alphabet;
            string motDePasse = "";
            
            Random random = new Random();

            if(choixAlphabet == 1)
            {
                alphabet = minuscules;
            }
            else if (choixAlphabet == 2)
            {
                alphabet=minuscules + majuscules;
            }
            else if (choixAlphabet == 3)
            {
                alphabet = minuscules+chiffres+majuscules;
            }
            else
            {
                alphabet = minuscules+chiffres+majuscules+caracteresSpeciaux;
            }
            int l = alphabet.Length;

            for(int j = 0; j < NBR_MDP; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotPasse; i++)
                {
                    int index = random.Next(0, l);
                    motDePasse += alphabet[index];
                }
                Console.WriteLine("mot de passe : " + motDePasse);
            }
         
        }
    }
}