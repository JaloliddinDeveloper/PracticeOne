namespace PracticeOne.Classes
{
    internal class Author
    {
        private string name;
        private int age;
        private string nationality;

        public Author()
        {
            name = "Unknown";
            age = 0;
            nationality = "Unknown";
        }

        public Author(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.nationality = "Unknown";
        }

        public Author(string name, int age, string nationality)
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetNationality()
        {
            return nationality;
        }

        public void Introduce()
        {
            Console.WriteLine($"My name is {name}. I am {age} years old. I am from {nationality}.");
        }

        public void CelebrateBirthday()
        {
            age += 1;
        }
    }
}
