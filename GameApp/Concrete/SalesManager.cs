using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAPP.Concrete
{
    public class SalesManager : ISalesManager
    {
        int wallet = 100;
        public void AddSale(IUser user, Product product, Campaign campaign)
        {
            if (campaign == null)
            {
                if (wallet > product.Price)
                {
                    Console.WriteLine("You have Purchased the product");
                    wallet = wallet - product.Price;
                    Console.WriteLine("New balance=" + wallet);
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
            else
            {
                if (wallet > product.Price - campaign.Discount)
                {
                    Console.WriteLine("You have Purchased the product");
                    wallet = wallet - product.Price - campaign.Discount;
                    Console.WriteLine("New balance=" + wallet);
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }

           
        }

        public void RemoveSale(IUser user, Product product, Campaign campaign)
        {
            Console.WriteLine("you product has beeen salved");
            wallet= wallet + product.Price- campaign.Discount;
            Console.WriteLine("New balance=" + wallet);
        }
    } 
}
