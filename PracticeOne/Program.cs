//HomeTask 1
//using PracticeOne.Classes;

//var rect = new Rectangle(10, 5, "Blue");
//Console.WriteLine($"Area: {rect.GetArea()}");         
//Console.WriteLine($"Perimeter: {rect.GetPerimeter()}"); 
//Console.WriteLine($"Color: {rect.Color}");          

//HomeTask 2

using PracticeOne.Classes;

var user = new User("Jaloliddin", "Mahkamov", "jaloliddin1115", "mypassword");

user.Login("jaloliddin1115", "mypassword");

Console.WriteLine(user.GetFullInfo());

user.Logout();

Console.WriteLine(user.GetFullInfo());
