using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public class GameManager : IGameService
    {
        private readonly List<Game> games = new List<Game>() { new Game(1,"Hell Let Loose",23)};
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine($"{game.Name} isimli oyun sisteme eklendi!");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine($"{game.Name} isimli oyun sistemden silindi!");
        }

        public List<Game> GetAll()
        {
            return games;
        }
    }
}
