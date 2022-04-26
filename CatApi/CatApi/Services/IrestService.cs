using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CatApi.Model;

namespace CatApi.Services
{
    public interface IrestService
    {
        Task<List<CatItemModel>> GetCatItemAsync();
        Task SaveCatItemAsync(CatItemModel item, bool isNewItem);
        Task DeleteCatItemAsync(CatItemModel item);
    }
}
