using System.Reflection.Metadata.Ecma335;

namespace Exo_Motus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mots = { "Blanc", "Pluie", "Ecran", "pomme", "Force", "Fleur", "Livre", "Monde", "prune", "poire" };
            Random rand = new Random();
            string motADeviner = mots[rand.Next(mots.Length)].ToLower();
            int[] status = new int[motADeviner.Length];

            int maxAttempts = 6;
            int attempt = 0;

            // Game Loop
            while (attempt < maxAttempts)
            {
                Console.WriteLine("Entrez votre tentative : ");
                string tentative = Console.ReadLine()?.ToLower();

                if (tentative.Length != motADeviner.Length)
                {
                    Console.WriteLine($"Votre tentative doit être de {motADeviner.Length} lettres.");
                    continue;
                }

                // Check correct positions and wrong positions
                status = RightCaracInWordRightPlace(tentative, new int[tentative.Length], motADeviner);
                status = RightCaractInWordWrongPlace(tentative, status, motADeviner);

                // Show results
                string[] formatted = Show(tentative.ToCharArray().Select(c => c.ToString()).ToArray(), status);
                ShowResult(formatted);

                // Check if the player won
                if (tentative == motADeviner)
                {
                    Console.WriteLine("Félicitations, vous avez trouvé le mot !");
                    break;
                }

                attempt++;
            }

            if (attempt == maxAttempts)
            {
                Console.WriteLine($"Dommage, le mot était : {motADeviner}");
            }
        }
        
        public static string[] Show(string[] tabMot, int[] tabValeur) // Verification + attribution de couleur en fonction des valeurs reprisent du tableau de int
        {
            string[] result = new string[tabMot.Length]; 

            for (int i = 0; i < tabMot.Length; i++)
            {
                if (tabValeur[i] == 1)
                {
                    result[i] = $"\u001b[31m{tabMot[i]}\u001b[0m"; // Attribution de la couleur rouge car bonne réponse
                }
                else if (tabValeur[i] == 2)
                {
                    result[i] = $"\u001b[33m{tabMot[i]}\u001b[0m"; // Attribution de la couleur jaune car bonne lettre mais mal placée
                }
                else
                {
                    result[i] = $"{tabMot[i]}"; // rien ne se passe car tout faux
                }
            }

                return result;
        }

        public static void ShowResult(string[] tabMot) // Méthode d'affichage reprennant le tableau résult de la méthode Show.
        {

            Console.WriteLine(" _____________________________ ");
            Console.WriteLine("|     |     |     |     |     |");
            Console.WriteLine($"|  {tabMot[0]}  |  {tabMot[1]}  |  {tabMot[2]}  |  {tabMot[3]}  |  {tabMot[4]}  |");
            Console.WriteLine("|     |     |     |     |     |");
            Console.WriteLine(" ----------------------------- ");
        }

        public static void ShowTenta(string mot) // Méthode d'affichage reprennant le tableau de tentative de l'utilisateur.
        {
            string[] tenta = new string[mot.Length];
            int i = 0;

            foreach(char c in mot)
            {
                tenta[i] = c.ToString();
                i++;
            }

            Console.WriteLine(" _____________________________ ");
            Console.WriteLine("|     |     |     |     |     |");
            Console.WriteLine($"|  {tenta[0]}  |  {tenta[1]}  |  {tenta[2]}  |  {tenta[3]}  |  {tenta[4]}  |");
            Console.WriteLine("|     |     |     |     |     |");
            Console.WriteLine(" ----------------------------- ");

            // Liste des mots pour le jeu
            string[] mots = { "Blanc", "Pluie", "Ecran", "pomme", "Force", "Fleur", "Livre", "Monde", "prune", "poire" };

            // Choix d'un mot aléatoire
            Random rand = new Random();
            string motADeviner = mots[rand.Next(mots.Length)].ToLower();
           
        }

        public static Dictionary<char, int> NumberLetterOccurence(string Word, int[] RightPlace)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            for(int i=0;i<Word.Length;i++){
                if(RightPlace[i] != 1)
                {
                    if (letterCounts.ContainsKey(Word[i]))
                    {
                        letterCounts[Word[i]]++;
                    }
                    else
                    {
                        letterCounts[Word[i]] = 1;
                    }
                }                    
            }
            return letterCounts;
        }

        public static int[] RightCaractInWordWrongPlace(string Word, int[] RightPlace, string RightWord)
        {
            Dictionary<char, int> letterCounts = NumberLetterOccurence(RightWord, RightPlace);

            for(int i = 0; i<Word.Length; i++){
                for(int y =0; y<Word.Length; y++)
                {
                    if(Word[i] == RightWord[y] && RightPlace[i] != 1){
                        if(letterCounts[RightWord[y]]>0)
                        {
                            RightPlace[i] = 2;
                            letterCounts[RightWord[y]]--;
                        }                            
                    }
                }
            }
            return RightPlace;
        }

        public static int[] RightCaracInWordRightPlace(string Word, int[] RightPlace, string RightWord)
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == RightWord[i])
                {                   
                    RightPlace[i] = 1;                       
                } 
            }
            return RightPlace;
        }
    }
}