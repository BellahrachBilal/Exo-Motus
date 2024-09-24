namespace Exo_Motus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liste des mots pour le jeu
            string[] mots = { "Blanc", "Pluie", "Ecran", "pomme", "Force", "Fleur", "Livre", "Monde", "prune", "poire" };

            // Choix d'un mot aléatoire
            Random rand = new Random();
            string motADeviner = mots[rand.Next(mots.Length)].ToLower();

        }
    }
}
