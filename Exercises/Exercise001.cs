using Exercises.Models;
using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (word == null || word == string.Empty) return word;

            int firstASCII = (int) word[0];
            if (firstASCII > 96 && firstASCII < 123){
                //not really necessary for the tests, but just in case, i'll check if it's an actual lower case letter
                word = (char)(firstASCII - 32) + word.Substring(1);
            }
            
            return word;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0) throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate < 0) throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");

            return Math.Round(originalPrice * (vatRate / 100 + 1), 2);
        }

        public string Reverse(string sentence)
        {
            if (sentence == null) return null;

            char[] sentenceArray = sentence.ToCharArray();
            Array.Reverse(sentenceArray);
            return new string(sentenceArray);
        }

        public int CountLinuxUsers(List<User> users)
        {
            if (users == null) return 0;
            int linuxUsers = 0;
            foreach (User user in users)
            {
                if (user.Type == "Linux") linuxUsers++;
            }
            return linuxUsers;
        }
    }
}
