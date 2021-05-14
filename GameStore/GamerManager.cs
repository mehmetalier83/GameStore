using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class GamerManager : IGamerService
    {
        private IConfirmGamerService _confirmGamerService;

        public GamerManager(IConfirmGamerService confirmGamerService)
        {
            _confirmGamerService = confirmGamerService;
        }

        public void Delete(Gamer gamer)
        {
            if (gamer.UserName.Equals("gokcenaysu") && gamer.Password.Equals("123456"))
            {
                Console.WriteLine("Account Deletion Successful");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }

        public void SignIn(Gamer gamer)
        {
            if (gamer.UserName.Equals("engindemirog") && gamer.Password.Equals("123456"))
            {
                Console.WriteLine("Login Successful- " + gamer.UserName);
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
            }
        }

        public void SignUp(Gamer gamer)
        {
            if (_confirmGamerService.Confirm(gamer))
            {
                Console.WriteLine("Successful Registration- " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Unsuccessful Registration- " + gamer.FirstName);
            }
        }
    }
}
