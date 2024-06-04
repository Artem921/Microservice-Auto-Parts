using AutoParts.Domain.Base;

namespace AutoParts.Domain.Entities
{
    public class Product:Identity
    {
        public bool State {  get; set; }

        public int InStock { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Description { get; set; }

        public Name Name {  get; set; }
    }
}
