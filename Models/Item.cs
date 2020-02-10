using System;

namespace procrastinator.Models
{
    public class Item
    {
        int Id;
        string Name;
        int Price;
        int Power;
        int Total;

        public Item(int id, string name, int price, int power, int total)
        {
            Id = id;
            Name = name;
            Price = price;
            Power = power;
            Total = total;
        }
        
        public int Buy(int totalProcrastination) 
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