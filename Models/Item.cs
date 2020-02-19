using System;

namespace procrastinator.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Power { get; set; }
        public int Total { get; set; }
        private int BaseCost { get; set; }

        public Item() { }

        public Item(int id, string name, int price, int power)
        {
            Id = id;
            Name = name;
            Price = price;
            BaseCost = price;
            Power = power;
            Total = 0;
        }
        
        public decimal Buy(decimal totalProcrastination) 
        {
            if (totalProcrastination >= Price) 
            {
                totalProcrastination -= Price;
                UpdatePrice();
                Total++;
            }
            
            return totalProcrastination;
        }

        public void UpdatePrice()
        {
            Price = (int)Math.Round((BaseCost * Math.Pow(1.15f, (Total + 1))));
        }
    }
}