using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public class GamerManager : IGamerService
    {

        private readonly List<Gamer> gamers = new List<Gamer>() {new Gamer(1,"Yunus Emre","Çiçek","scharfschütze55","123"),new Gamer(1,"Enes Emir","Çiçek","knight55","123") }; 

        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
            Console.WriteLine($"{gamer.Username} kaydınız gerçekleşti.");
        }

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine($"{gamer.Username} sistemden kaldırıldı.");
        }

        public List<Gamer> GetAll()
        {
            return gamers;
        }
    }
}
