using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Game() { }

        public Game(int ıd, string name, double price)
        {
            Id = ıd;
            Name = name;
            Price = price;
        }
    }
}
