using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftsProject.Models;

namespace GiftsProject.Services
{
    public class MockDataStore : IDataStore<Envie>
    {
        List<Envie> items;

        public MockDataStore()
        {
            items = new List<Envie>();
            var mockItems = new List<Envie>
            {
                new Envie { Id = Guid.NewGuid().ToString(), Nom = "First item", Description="This is an item description." },
                new Envie { Id = Guid.NewGuid().ToString(), Nom = "Second item", Description="This is an item description." },
                new Envie { Id = Guid.NewGuid().ToString(), Nom = "Third item", Description="This is an item description." },
                new Envie { Id = Guid.NewGuid().ToString(), Nom = "Fourth item", Description="This is an item description." },
                new Envie { Id = Guid.NewGuid().ToString(), Nom = "Fifth item", Description="This is an item description." },
                new Envie { Id = Guid.NewGuid().ToString(), Nom = "Sixth item", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Envie item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Envie item)
        {
            var oldItem = items.Where((Envie arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Envie arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Envie> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Envie>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}