using AutoParts.Domain.Base;
using AutoParts.Domain.ValueObjects;

namespace AutoParts.Domain.Entities
{
    public class Product:Identity
    {
        public bool State {  get; set; }

        public bool InStock { get; set; }

        public DateTime DateArrival { get; set; }
        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Manufacture {  get; set; } = string.Empty;

        public ProductName Name {  get; set; }

        public Product (bool state,bool inStock, DateTime dateArrial, string categoy, string description, string manufacture, ProductName name)
        {
            State = state;
            InStock = inStock;
            DateArrival = dateArrial;
            Category = categoy;
            Description = description;
            Manufacture = manufacture;
            Name = name;
        }
    }
}
