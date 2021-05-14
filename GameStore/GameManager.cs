using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added with campaign 1");
        }

        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
