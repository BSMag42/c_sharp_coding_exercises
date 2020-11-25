namespace TechReturners
{
    public class Person
    {
        public Person(string forename, string surname, string location, int age)
        {
            Forename = forename;
            Surname = surname;
            Location = location;
            Age = age;
        }

        public string Forename
        { get; set; }

        public string Surname
        { get; set; }

        public string Location
        { get; set; }

        public int Age
        { get; set; }
    }
}