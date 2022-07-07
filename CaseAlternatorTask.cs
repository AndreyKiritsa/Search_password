using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        //Тесты будут вызывать этот метод
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            if (startIndex == word.Length)
            {
                //Console.WriteLine(new string(word));
                result.Add(new string (word));
                return;
            }
			if (((int)word[startIndex]>64 && (int)word[startIndex] < 123) 
|| ((int)word[startIndex] > 1039 && (int)word[startIndex] < 1104))
            {
                word[startIndex] = char.ToLower(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
                word[startIndex] = char.ToUpper(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
            }
            else
                AlternateCharCases(word, startIndex + 1, result);
        }
    }
}
