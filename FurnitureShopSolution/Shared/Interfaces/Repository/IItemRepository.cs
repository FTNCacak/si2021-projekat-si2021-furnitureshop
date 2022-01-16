using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IItemRepository
    {
        List<Item> GetAllItems();
        List<Item> GetInStockItems();
        int InsertItem(Item i);
        int UpdateItem(Item item);
        void DeleteItem(int itemid);
    }
}
