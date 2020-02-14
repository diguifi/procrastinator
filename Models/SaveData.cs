using System.Collections.Generic;

namespace procrastinator.Models
{
    public class SaveData
    {
        public decimal Quantity { get; set; }
        public ICollection<Item> Items { get; set; }

        public SaveData() { }

        public SaveData(decimal quantity, ICollection<Item> items)
        {
          Quantity = quantity;
          Items = items;
        }
    }
}