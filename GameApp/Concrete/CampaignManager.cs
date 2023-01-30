using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class CampaignManager
    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine("Added"+ campaing.CampaignName);
        }
        
    }
}
