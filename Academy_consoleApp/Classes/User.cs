using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int password { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; } 
        public Dictionary<string,int> Subjects { get; set; }

        public User()
        { 

        }

        public void LoggedIn()
        {
            Console.WriteLine($"Hello {FirstName}, you are logged as {Role} under {UserName}");
        }
    }



}


