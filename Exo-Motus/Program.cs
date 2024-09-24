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
                if (tabValeur[i] == 2)
                {
                    result[i] = $"\u001b[31m{tabMot[i]}\u001b[0m"; // Attribution de la couleur rouge car bonne réponse
                }
                else if (tabValeur[i] == 1)
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
    }
}
