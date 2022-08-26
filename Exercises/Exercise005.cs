using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (input == "") return false;

            for (var i = 0; i < 26; i++)
            {
                if (input.IndexOf((char)(65 + i)) == -1 && input.IndexOf((char)(97 + i)) == -1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
