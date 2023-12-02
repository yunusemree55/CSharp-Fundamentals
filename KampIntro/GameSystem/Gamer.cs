using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Gamer()
        {
            
        }

        public Gamer(int ıd, string name, string surname, string username, string password)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
    }
}
