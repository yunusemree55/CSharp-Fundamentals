using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public class ShopManager : IShopService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine($"{game.Name} isimli oyun {gamer.Username} tarafından satın alındı");
        }
    }
}
