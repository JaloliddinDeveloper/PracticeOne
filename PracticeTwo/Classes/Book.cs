namespace PracticeTwo.Classes
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string GetInfo()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}";
        }

        public bool IsPublishedRecently()
        {
            return Year > 2010;
        }
    }
}
