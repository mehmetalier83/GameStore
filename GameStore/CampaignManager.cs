using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class CampaignManager
    {
        public void Add(Campaign campaign,Game game,Gamer gamer)
        {
            if (game.Limit >= gamer.YearOfBirth)
            {
                Console.WriteLine("The game '" + game.GameName + "' was purchased with '" + campaign.CampaignName + "'- " + gamer.UserName);
            }
            else
            {
                Console.WriteLine("You must be 18 years or older to play this game- " + gamer.UserName);
            }
        
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign updated");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted");
        }
    }
}
