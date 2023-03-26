using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TMSLesson17.Models;

namespace TMSLesson17.Controllers
{
    public class StorageController : Controller
    {
        private readonly ILogger<StorageController> _logger;

        CategoryViewModel[] categories;
        ItemViewModel[] items;
        InventoryViewModel inventory;

        public StorageController(ILogger<StorageController> logger)
        {
            _logger = logger;

            categories = new CategoryViewModel[]
            {
                new CategoryViewModel(1, "Laptops"),
                new CategoryViewModel(2, "Tablets"),
                new CategoryViewModel(3, "Printers"),
                new CategoryViewModel(4, "Monitors")
            };

            items = new ItemViewModel[]
{
                new ItemViewModel(1, "0155554522", "Apple MacBook Pro 13", 1, 52, 48),
                new ItemViewModel(2, "0155585456", "Lenovo Thinkpad T580", 1, 34, 35),
                new ItemViewModel(3, "0155522455", "Microsoft Surface Laptop", 1, 2, 2),
                new ItemViewModel(5, "0225345478", "Apple iPad Pro", 2, 13, 13),
                new ItemViewModel(6, "0225396857", "Samsung Galaxy Tab", 2, 44, 44),
                new ItemViewModel(7, "0145874125", "Epson Expression Home XP-2200", 3, 5, 4),
                new ItemViewModel(8, "0145886248", "Canon Pixma TS3122", 3, 8, 6),
                new ItemViewModel(11, "0475812587", "HP EliteDisplay E233", 4, 2, 0),
                new ItemViewModel(12, "0475856987", "Dell UltraSharp U3415W", 4, 6, 6),
                new ItemViewModel(13, "0475815782", "Apple Thunderbolt Display", 4, 7, 7)
            };

            inventory = new InventoryViewModel(categories, items);
        }

        public IActionResult Inventory()
        {
            return View(inventory);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}