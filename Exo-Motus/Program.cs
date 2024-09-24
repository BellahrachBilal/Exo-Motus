namespace Exo_Motus
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
    }
}
