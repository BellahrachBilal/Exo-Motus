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

        public int[] RightCaractInWordWrongPlace(string Word, int[] RightPlace, string RightWord)
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
    }
}