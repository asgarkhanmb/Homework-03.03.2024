using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Models
{
    internal  class User
    {
        public string name;
        public string surname;
        public int age;
        private string password;

        public User()
        {

        }
        public User(string name, string surname, int age, string password)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.password = password;
        }
        public string Get()
        {
            return password;
        }
        public void Set(string pass)
        {
            password = pass;
        }
    }
}
