using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public interface ISalesManager
    {
        public void AddSale(IUser user, Product product, Campaign campaign );
       public void RemoveSale(IUser user, Product product, Campaign campaign);
    }
}
