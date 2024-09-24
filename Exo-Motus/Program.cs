using System.Reflection.Metadata.Ecma335;

namespace Exo_Motus
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public Dictionary<char, int> NumberLetterOccurence(string Word, int[] RightPlace)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            for (int i = 0; i < Word.Length; i++)
            {
                if (RightPlace[i] != 1)
                {
                    if (letterCounts.ContainsKey(Word[i]))
                    {
                        letterCounts[Word[i]]++;
                    }
                }
            }
            return letterCounts;
        }
        public int[] RightCaracInWordRightPlace(string Word, int[] RightPlace, string RightWord)
        {
            Dictionary<char, int> lettersCounts = NumberLetterOccurence(RightWord, RightPlace);

            for (int i = 0; i < Word.Length; i++)
            {
                for (int y = 0; y < RightWord.Length; y++)
                {
                    if (Word[i] == RightWord[y] && RightPlace[i] == 1)
                    {
                        if (lettersCounts[RightWord[y]] > 0)
                        {
                            lettersCounts[RightWord[y]]--;
                        }
                    }
                }
            }
            return RightPlace;
        }
    }
}