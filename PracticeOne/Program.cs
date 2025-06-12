//HomeTask 1
//using PracticeOne.Classes;

//var rect = new Rectangle(10, 5, "Blue");
//Console.WriteLine($"Area: {rect.GetArea()}");         
//Console.WriteLine($"Perimeter: {rect.GetPerimeter()}"); 
//Console.WriteLine($"Color: {rect.Color}");          

//HomeTask 2

//using PracticeOne.Classes;

//var user = new User("Jaloliddin", "Mahkamov", "jaloliddin1115", "mypassword");

//user.Login("jaloliddin1115", "mypassword");

//Console.WriteLine(user.GetFullInfo());

//user.Logout();

//Console.WriteLine(user.GetFullInfo());

// HomeTask 3
//using PracticeOne.Classes;

//var author1 = new Author();
//author1.Introduce();


//var author2 = new Author("Jaloliddin", 25);
//author2.Introduce();

//var author3 = new Author("Jaloliddin", 25, "Uzbekistan");
//author3.Introduce();

//author3.CelebrateBirthday();
//author3.Introduce();

// HomeTask 4

using PracticeOne.Classes;

var country = new Country("Uzbekistan", "Tashkent", 36000000, "Uzbek");

Console.WriteLine($"Capital: {country.GetCapital()}");

Console.WriteLine($"Population: {country.GetPopulation()}");

Console.WriteLine($"Official Language: {country.GetOfficialLanguage()}");

country.SetCapital("Samarkand");

country.SetPopulation(40000000);

country.SetOfficialLanguage("Uzbek, Russian");

Console.WriteLine($"Updated Capital: {country.GetCapital()}");

Console.WriteLine($"Updated Population: {country.GetPopulation()}");

Console.WriteLine($"Updated Language: {country.GetOfficialLanguage()}");




