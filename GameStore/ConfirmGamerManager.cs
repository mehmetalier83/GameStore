using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class ConfirmGamerManager:IConfirmGamerService
    {
        public bool Confirm(Gamer gamer)
        {
            if (gamer.IdentityNumber.Equals("53650186464") && gamer.FirstName.Equals("Aysu") && gamer.LastName.Equals("Gökcen") && gamer.YearOfBirth.Equals(1999))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
