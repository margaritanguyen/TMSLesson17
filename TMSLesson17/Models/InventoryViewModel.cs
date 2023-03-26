using System.ComponentModel.DataAnnotations;

namespace TMSLesson17.Models
{
    public class InventoryViewModel
    {
        public CategoryViewModel[] Categories { get; set; }
        public ItemViewModel[] Items { get; set; }

        public InventoryViewModel(CategoryViewModel[] categories, ItemViewModel[] items)
        {
            Categories = categories;
            Items = items;
        }
    }
}