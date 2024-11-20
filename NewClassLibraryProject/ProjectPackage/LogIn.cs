using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPackage
{
    public class Login
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        public Login()
        {
            // Sample users for testing (email, password)
            userDatabase.Add("user1", "password1");
            userDatabase.Add("user2", "password2");
        }

        public bool Authenticate(string email, string password)
        {
            // Check if the user exists and if the password is correct
            if (userDatabase.ContainsKey(email) && userDatabase[email] == password)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
                return false;
            }
        }

        public bool Register(string email, string password)
        {
            // Check if the email already exists
            if (userDatabase.ContainsKey(email))
            {
                Console.WriteLine("Email already exists.");
                return false;
            }

            // Register a new user
            userDatabase.Add(email, password);
            Console.WriteLine("User registered successfully!");
            return true;
        }
    }

    
}