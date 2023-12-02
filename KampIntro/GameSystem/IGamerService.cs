using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem
{
    public interface IGamerService
    {
        List<Gamer> GetAll();
        void Add(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
