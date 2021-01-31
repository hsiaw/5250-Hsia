using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Kunai", Description="Sharp, multipurpose throwing knife.", Value=2},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Shuriken", Description="Sharp weapon made for throwing and spinning.", Value=1},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Soldier Pill", Description="Restores chakra and temporarily buffs stats.", Value=3},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Exploding Tag", Description="Sealed paper that will explode upon chakra infusion.", Value=5},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Senbon", Description="Pointed needle meant to be thrown or stabbed with.", Value=4}
            };
        }

        public async Task<bool> AddItemAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}