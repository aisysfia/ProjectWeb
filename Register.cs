using System.Collections.Generic;

namespace ProjectPackage
{
    public class Register
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        public Register()
        {
            // Prepopulate with sample users
            userDatabase.Add("user1", "password1");
            userDatabase.Add("user2", "password2");
        }

        // Method to register a new user
        public (bool isSuccess, string message) RegisterUser(string username, string password)
        {
            // Check if the username is already taken
            if (userDatabase.ContainsKey(username))
            {
                return (false, "Username already exists. Please try a different username.");
            }

            // Basic password validation
            if (password.Length < 6)
            {
                return (false, "Password must be at least 6 characters long.");
            }

            // Add the user to the database
            userDatabase.Add(username, password);
            return (true, "User registered successfully!");
        }
    }
}
