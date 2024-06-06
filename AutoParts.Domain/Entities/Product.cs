using AutoParts.Domain.Base;
using CSharpFunctionalExtensions;

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

        public string Name { get; set; }= string.Empty;
        public string VendorName { get; set; } = string.Empty;

  

        private Product (bool state,bool inStock, DateTime dateArrial, string categoy, string description, string manufacture, string name, string vendorName)
        {
            Id = Guid.NewGuid ();
            State = state;
            InStock = inStock;
            DateArrival = dateArrial;
            Category = categoy;
            Description = description;
            Manufacture = manufacture;
            Name = name;
            VendorName = vendorName;
        }

        public static Result<Product> Create(bool state, bool inStock, DateTime dateArrial, string categoy, string description, string manufacture, string name, string vendorName)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Result.Failure<Product>($"{nameof(name)} не может быть пустым");

            }

            if (string.IsNullOrEmpty(vendorName))
            {
                return Result.Failure<Product>($"{nameof(vendorName)} не может быть пустым");
            }

            if (string.IsNullOrEmpty(categoy))
            {
                return Result.Failure<Product>($"{nameof(categoy)} не может быть пустым");
            }

            if (string.IsNullOrEmpty(description))
            {
                return Result.Failure<Product>($"{nameof(description)} не может быть пустым");
            }

            if (string.IsNullOrEmpty(manufacture))
            {
                return Result.Failure<Product>($"{nameof(manufacture)} не может быть пустым");
            }

            var product = new Product(state, inStock, dateArrial, categoy, description, manufacture, name, vendorName);

            return Result.Success(product);
        }


    }
}
