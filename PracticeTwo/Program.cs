//Task 1
using PracticeTwo.Classes;

//var myBook = new Book("The Standatd", "Hassan Habib", 2022);
//Console.WriteLine(myBook.GetInfo()); 
//Console.WriteLine(myBook.IsPublishedRecently()); 

//Task 2

//Console.Write("Enter the radius of the circle: ");
//string input = Console.ReadLine();

//if (double.TryParse(input, out double userRadius) && userRadius >= 0)
//{
//    Circle circle = new Circle(userRadius);

//    Console.WriteLine("\nCircle Details:");
//    Console.WriteLine($"Radius: {circle.GetRadius()}");
//    Console.WriteLine($"Area: {circle.GetArea():F2}");
//    Console.WriteLine($"Diameter: {circle.GetDiameter():F2}");
//    Console.WriteLine($"Circumference: {circle.GetCircumference():F2}");
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid non-negative number for radius.");
//}

//Task 3    
//Console.WriteLine("Enter day: ");
//int day = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter month: ");
//int month = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter year: ");
//int year = int.Parse(Console.ReadLine());

//Date today = new Date(day, month, year);
//Console.WriteLine("Today: " + today.ToString());

//today.SetDate(20, 6, 2025);
//Console.WriteLine("Updated Date: " + today.ToString());

//Console.WriteLine($"Day: {today.GetDay()}");
//Console.WriteLine($"Month: {today.GetMonth()}");
//Console.WriteLine($"Year: {today.GetYear()}");

//Task 4

var user = new BankAccount(initialBalance: 1000, userName: "Jaloliddin Mahkamov");

Console.WriteLine(user.Deposit(500));

user.GetBalance();

user.Withdraw(200);

user.GetBalance();

Console.WriteLine(user.FreezeAccount());

user.Deposit(500); 

Console.WriteLine(user.Withdraw(100)); 

Console.WriteLine(user.UnfreezeAccount());

user.Deposit(1000);

Console.WriteLine(user.UnfreezeAccount());

user.Deposit(1000);

user.GetBalance();
