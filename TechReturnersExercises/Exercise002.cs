using System;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester( Person person ) 
        {
            return person.Location == "Manchester";
        }

        public static bool CanWatchFilm(Person person, int ageLimit) 
        {
            return person.Age >= ageLimit;
        }
    }
}
