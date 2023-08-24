using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoarding
{
    public class WordCount
    {
        public static void wordCount(string S)
        {
            char[] splittedWord = S.ToCharArray();

            Dictionary<char, int> myWord = new Dictionary<char, int>();


            for (int i = 0; i < splittedWord.Length; i++)
            {

                char character = splittedWord[i];

                if (myWord.ContainsKey(character))
                {
                    myWord[character]++;//If character already exists it will increment it
                }
                else
                {
                    myWord[character] = 1;//else equate it to 1
                }
            }

            foreach(var letter in myWord)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value}");
            }

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter your input: ");
            string? input = Console.ReadLine();
          
            wordCount(input);
            


            
        }
        
    }
}
