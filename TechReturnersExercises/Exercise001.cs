using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {
            if (word.Length > 0)
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
            else
            {
                return "";
            }
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
            var initials = "";
            if(firstName.Length > 0)
            {
                char first = firstName[0];
                initials = first.ToString() + ".";
            }
            if (lastName.Length > 0)
            {
                char last = lastName[0];
                initials += last.ToString();
            }

            return initials.ToUpper();
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            double vat = (vatRate + 100) / 100;
            double totalprice = originalPrice * vat;
            return Math.Round(totalprice,2);
        }

        public static String Reverse(String sentence) 
        {
            char[] arrsentence = sentence.ToCharArray();
            Array.Reverse(arrsentence);
            return new string(arrsentence);
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            // Add your code here!
            throw new NotImplementedException();
        }
    }
}
