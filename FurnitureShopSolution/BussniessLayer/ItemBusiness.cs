using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    class ItemBusiness
    {
        private readonly ItemRepository ItemRepository = new ItemRepository();

        public List<Item> GetAllItems()
        {
            return ItemRepository.GetAllItems();
        }

        public bool InsertItem(Item i)
        {
            if (this.ItemRepository.InsertItem(i) > 0)
                return true;
            return false;
        }
        public void DeleteItem(int item)
        {
            ItemRepository.DeleteItem(item);
        }
    }
}
