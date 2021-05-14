using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IGamerService
    {
        void SignIn(Gamer gamer);
        void SignUp(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
