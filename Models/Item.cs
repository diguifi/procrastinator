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

        public Item() { }

        public Item(int id, string name, int price, int power)
        {
            Id = id;
            Name = name;
            Price = price;
            Power = power;
            Total = 0;
        }
        
        public decimal Buy(decimal totalProcrastination) 
        {
            if (totalProcrastination >= Price) 
            {
                totalProcrastination -= Price;
                Price += Price/2;
                Total++;
            }
            
            return totalProcrastination;
        }
    }
}