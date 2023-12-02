using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public interface IGameService
    {
        List<Game> GetAll();
        void Add(Game game);
        void Delete(Game game);


    }
}
