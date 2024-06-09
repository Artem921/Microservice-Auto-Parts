using CSharpFunctionalExtensions;

namespace Products.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; }
        public bool State { get; }

        public bool InStock { get; }

        public DateTime DateArrival { get; }
        public string Category { get; } = string.Empty;

        public string Description { get; } = string.Empty;

        public string Manufacture { get; } = string.Empty;

        public string Name { get; } = string.Empty;
        public string VendorName { get; } = string.Empty;

        public decimal Price { get; } = decimal.Zero;

        public string Articul { get; } = string.Empty;




        private Product(Guid id, bool state, bool inStock, DateTime dateArrial, string categoy, string description, string manufacture, string name, string vendorName, decimal price, string articul)
        {
            Id = id;
            State = state;
            InStock = inStock;
            DateArrival = dateArrial;
            Category = categoy;
            Description = description;
            Manufacture = manufacture;
            Name = name;
            VendorName = vendorName;
            Price = price;
            Articul = articul;
        }

        public static Result<Product> Create(Guid id, bool state, bool inStock, DateTime dateArrial, string categoy, string description, string manufacture, string name, string vendorName, decimal price, string articul)
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
            if (string.IsNullOrEmpty(articul))
            {
                return Result.Failure<Product>($"{nameof(articul)} не может быть пустым");
            }
            var product = new Product(id, state, inStock, dateArrial, categoy, description, manufacture, name, vendorName, price, articul);

            return Result.Success(product);
        }


    }
}
