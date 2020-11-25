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
            // Add your code here!
            throw new NotImplementedException();
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            // Add your code here!
            throw new NotImplementedException();
        }

        public static String Reverse(String sentence) 
        {
            // Add your code here!
            throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            // Add your code here!
            throw new NotImplementedException();
        }
    }
}
