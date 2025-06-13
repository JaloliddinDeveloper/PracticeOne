namespace PracticeTwo.Classes
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int GetDay() =>
             day;

        public void SetDay(int day) =>
            this.day = day;

        public int GetMonth() =>
            month;

        public void SetMonth(int month) =>
            this.month = month;

        public int GetYear() =>
             year;

        public void SetYear(int year) =>
            this.year = year;

        public void SetDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString() =>
             $"{day:D2}/{month:D2}/{year}";
    }
}
