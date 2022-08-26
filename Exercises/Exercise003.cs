using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours
        {
            get { 
                return new string[] { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" }; 
            }
        }

        public int IceCreamCode(string iceCreamFlavour)
        {
            int code = 0;
            switch (iceCreamFlavour)
            {
                case "Raspberry Ripple":
                    code = 1;
                    break;
                case "Mint Chocolate Chip":
                    code = 3;
                    break;
                case "Mango Sorbet":
                    code = 5;
                    break;
            }
            return code;
        }
    }
}
