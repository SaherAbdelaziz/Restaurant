using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurant.Models.AppModels;
namespace Restaurant.ViewModels
{
    public class ItemsViewModel
    {
        public List<Item> Items  { get; set; }
        public List<Category> Categories { get; set; }
        public int ItemsToShowCount { get; set; }

        public ItemsViewModel(List<Item> items, List<Category> categories, int itemsToShowCount)
        {
            Items = items.ToList();
            Categories = categories.ToList();
            ItemsToShowCount = itemsToShowCount;
        }
    }
}