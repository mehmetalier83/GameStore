using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game()
            { GameName = "Counter Strike", GamePrice = "30", Limit = 1996 };
            Game game2 = new Game
            { GameName = "Call of Duty", GamePrice = "20", Limit = 1999 };
            Game game3 = new Game()
            { GameName = "BattleField", GamePrice = "35", Limit = 1996 };
            Game game4 = new Game()
            { GameName = "Deceit /SELECTED GAME", GamePrice = "20", Limit = 1998 };
            Game game5 = new Game()
            { GameName = "Football Manager /SELECTED GAME", GamePrice = "25", Limit = 2010 };

            Game[] games ={game1, game2, game3, game4, game5};

            foreach ( var game in games)
            {
                Console.WriteLine(game.GameName + ": $" + game.GamePrice);
            }
            Console.WriteLine("************");

            Console.WriteLine("----SIGN UP / SIGN IN----");
            Gamer gamer1 = new Gamer()
            { FirstName = "Aysu", LastName = "Gökcen", UserName = "gokcenaysu", IdentityNumber = "53650186464", YearOfBirth = 1999, Password = "123456" };
            Gamer gamer2 = new Gamer()
            { FirstName = "Engin", LastName = "DEMİROĞ", UserName = "engindemirog", YearOfBirth = 1991, Password = "123456" };
            GamerManager gamerManager = new GamerManager(new ConfirmGamerManager());
            gamerManager.SignUp(gamer1);
            gamerManager.SignIn(gamer2);
            Console.WriteLine("\n ----CAMPAIGN----");

            Campaign campaign1 = new Campaign()
            { CampaignName = "New member bonus", CampaignPrice = 200 };
            Campaign campaign2 = new Campaign()
            { CampaignName = "Buy one for free in selected games", CampaignPrice = 0 };

            Campaign[] campaigns = { campaign1, campaign2 };
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName + ": $" + campaign.CampaignPrice);
            }
            Console.WriteLine("\n----PURCHASE----");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1, game1, gamer1);
            campaignManager.Add(campaign2, game4, gamer2);



        }
    }
}
