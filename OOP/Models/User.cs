using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class User
    {
        public static int currentId;
        public int id;
        private string username;
        private string password;
        public string UserName { 
            get
            {
                return username;
            }
            set
            {
                if(value.Length < 3)
                {
                    Console.WriteLine("Oops, username cannot be less than 3 characters");
                }
                else
                {
                    username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Oops, password cannot be less than 3 characters");
                }
                else
                {
                    password = value;
                }
            }
        }

        public User() {
            currentId++;
            id = currentId;
        }

        public User(string username, string password)
        {
            currentId++;
            id=currentId;
            this.username = username;
            this.password = password;
        }
    }
}


//if the set attribute is remove, means its readonly
//if the get attribute is remove, means its write only
//Static properties do not need new instances to be used, meaning you dont have to create an object for them. it is better for shared instances. They maintain value across class
//const vs readonly - readonly the value is set at run time and for constant, the value is hard coded;
//Constants and static by default;