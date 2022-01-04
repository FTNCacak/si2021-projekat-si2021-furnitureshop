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

        public bool InsertItems(Item i)
        {
            if (this.ItemRepository.InsertItems(i) > 0)
                return true;
            return false;
        }
        public void DeleteItems(int item)
        {
            ItemRepository.DeleteItems(item);
        }
    }
}
