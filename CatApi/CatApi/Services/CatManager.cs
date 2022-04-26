using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CatApi.Model;

namespace CatApi.Services
{
    public class CatManager
    {
        IrestService service;

        public CatManager(IrestService restService)
        {
            service = restService;
        }

        public Task<List<CatItemModel>> GetCatItemModels()
        {
            return service.GetCatItemAsync();
        }

        public Task DeleteCatAsync(CatItemModel item)
        {
            return service.DeleteCatItemAsync(item);
        }
        public Task SaveCatItemAsync(CatItemModel catItem, bool isNewItem = false)
        {
            return service.SaveCatItemAsync(catItem, isNewItem);
        }
    }
}
