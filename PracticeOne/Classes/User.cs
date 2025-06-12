namespace PracticeOne.Classes
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; private set; }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            IsLoggedIn = false;
        }

        public void Login(string username, string password)
        {
            if (Username == username && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("User logged in successfully");
            }
            else
            {
                Console.WriteLine("Your password or username is incorrect");
            }
        }

        public void Logout()
        {
            IsLoggedIn = false;
        }

        public string GetFullInfo()
        {
            return $"{FirstName} {LastName} - {IsLoggedIn.ToString().ToLower()}";
        }
    }
}
