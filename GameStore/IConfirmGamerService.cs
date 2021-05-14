using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IConfirmGamerService
    {
        bool Confirm(Gamer gamer);
    }
}
