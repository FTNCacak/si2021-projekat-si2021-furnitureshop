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
        int InsertItem(Item i);
        List<Item> GetInStockItems();
        int UpdateItem(Item item);
        int DeleteItem(int itemid);
    }
}
