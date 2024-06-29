using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Sku { get; set; }
        public string Mpn { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public int CountryId { get; set; }
        public int SupplierId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static List<Equipment> equipments = new List<Equipment>() { 
            new Equipment() { Id = 1, Name = "Laptop", Model = "Dell Inspiron 15", Sku = "SKU-001", Mpn = "MPN-001", SerialNumber = "SN-001", Description = "Dell Inspiron 15", Image = "laptop.jpg", Status = 1, Quantity = 10, CountryId = 1, SupplierId = 1, WarehouseId = 1, PurchaseDate = DateTime.Now, WarrantyDate = DateTime.Now, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            new Equipment() { Id = 2, Name = "Monitor", Model = "Dell Monitor", Sku = "SKU-002", Mpn = "MPN-002", SerialNumber = "SN-002", Description = "Dell Monitor", Image = "monitor.jpg", Status = 1, Quantity = 5, CountryId = 1, SupplierId = 1, WarehouseId = 1, PurchaseDate = DateTime.Now, WarrantyDate = DateTime.Now, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            new Equipment() { Id = 3, Name = "Keyboard", Model = "Dell Keyboard", Sku = "SKU-003", Mpn = "MPN-003", SerialNumber = "SN-003", Description = "Dell Keyboard", Image = "keyboard.jpg", Status = 1, Quantity = 20, CountryId = 1, SupplierId = 1, WarehouseId = 1, PurchaseDate = DateTime.Now, WarrantyDate = DateTime.Now, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            new Equipment() { Id = 4, Name = "Mouse", Model = "Dell Mouse", Sku = "SKU-004", Mpn = "MPN-004", SerialNumber = "SN-004", Description = "Dell Mouse", Image = "mouse.jpg", Status = 1, Quantity = 15, CountryId = 1, SupplierId = 1, WarehouseId = 1, PurchaseDate = DateTime.Now, WarrantyDate = DateTime.Now, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
        };

        
    }
}