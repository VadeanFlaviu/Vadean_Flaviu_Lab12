using System.Collections.Generic;
using System.Threading.Tasks;
using Vadean_Flaviu_Lab12.Models;

namespace Vadean_Flaviu_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
