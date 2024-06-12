﻿namespace Products.Infrastructure.Configuration.ContextEntities
{
    public class ProductContext
    {
        public Guid Id { get; set; }
        public bool State { get; set; }

        public bool InStock { get; set; }

        public DateTime DateArrival { get; set; }
        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Manufacture { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string VendorName { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public string Articul { get; set; } = string.Empty;
    }
}