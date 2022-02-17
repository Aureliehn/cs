using System;

namespace GenerateurPhrase
{
    internal class Program
    {
        static string ObtenirElementAleatoire(string[]t)
        {
            Random r = new Random();
            int i = r.Next(t.Length);  
            return t[i];
        }
        static void Main(string[] args)
        {
            var sujets = new string[] { "Un oeuf",
                "une poupée", 
                "un lutin", 
                "un escargot", 
                "une saucisse",
                "une voiture",
                "un enfant",
                "un doudou"
            };
            var verbes = new string[] { 
                "mange",
                "dort",
                "pleure",
                "nettoie",
                "saute",
                "mord",
                "rigole",
                "boude",
                "observe"
            };
            var complements = new string[] { 
                "la pluie",
                "un crabe",
                "une crêpe",
                "un oiseau",
                "une tarte",
                "un oreiller",
                "une piscine",
                "le soleil"
            };
            const int NB_PHRASES = 100;
            var phraseUnique = new List<string>();
            int doublons = 0;
            while(phraseUnique.Count < NB_PHRASES)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);

                var phrase = sujet + " " + verbe + " " + complement;
                if (!phraseUnique.Contains(phrase))
                {
                    phraseUnique.Add(phrase);
                }
                else
                {
                    doublons++;
                }
          
           
            }
            foreach (var phrase in phraseUnique)
            {
                Console.WriteLine(phrase);   
            }
            Console.WriteLine();
            Console.WriteLine("Nombre de phrases uniques : " + phraseUnique.Count);
            Console.WriteLine("Nombre de doublons évités : " + doublons);
        }
        
    }
}