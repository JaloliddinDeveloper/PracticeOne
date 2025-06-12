namespace PracticeOne.Classes
{
    internal class Country
    {
        private string name;
        private string capital;
        private int population;
        private string officialLanguage;

        public Country(string name, string capital, int population, string officialLanguage)
        {
            this.name = name;
            this.capital = capital;
            this.population = population;
            this.officialLanguage = officialLanguage;
        }


        public void SetCapital(string capital)
        {
            this.capital = capital;
        }

        public string GetCapital()
        {
            return capital;
        }

        public void SetPopulation(int population)
        {
            this.population = population;
        }

        public int GetPopulation()
        {
            return population;
        }

        public void SetOfficialLanguage(string language)
        {
            this.officialLanguage = language;
        }

        public string GetOfficialLanguage()
        {
            return officialLanguage;
        }
    }
}
