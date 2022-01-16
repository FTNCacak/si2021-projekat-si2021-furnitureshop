using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IItemBusiness
    {
        List<Item> GetAllItems();
        List<Item> GetInStockItems();
        bool InsertItem(Item i);
        int UpdateItem(Item Item);
        int DeleteItem(int item);

    }
}
