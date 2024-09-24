using System.Reflection.Metadata.Ecma335;

namespace Exo_Motus
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public int[] RightCaracInWordRightPlace(string Word, int[] RightPlace, string RightWord)
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