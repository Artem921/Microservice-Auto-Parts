using Carts.Domain.Entities.ValueObjects.Base;

namespace Carts.Domain.Entities.ValueObjects
{
    public class ProductCart : ValueObject
    {
        public bool State { get; set; }

        public bool InStock { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Manufacture { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string VendorName { get; set; } = string.Empty;

        public decimal Price { get; set; } = decimal.Zero;

        public string Articul { get; set; } = string.Empty;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return State;
            yield return InStock;
            yield return Category;
            yield return Description;
            yield return Manufacture;
            yield return Name;
            yield return VendorName;
            yield return Price;
            yield return Articul;
        }
    }
}
