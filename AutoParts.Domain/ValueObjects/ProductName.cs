using AutoParts.Domain.ValueObjects.Abstract;

namespace AutoParts.Domain.ValueObjects
{
    public class ProductName : ValueObject
    {
        public string Name { get; set; }
        public string VendorName { get; set; }

        public ProductName(string name, string vendoreName)
        {           
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (vendoreName == null)
            {
                throw new ArgumentNullException(nameof(vendoreName));
            }

            this.Name = name;
            this.VendorName = vendoreName;
        }

       

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return VendorName;
        }
    }
}
