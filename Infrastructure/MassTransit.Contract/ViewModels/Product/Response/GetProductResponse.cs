using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.Contract.ViewModels.Product.Response
{
    public class GetProductResponse
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
