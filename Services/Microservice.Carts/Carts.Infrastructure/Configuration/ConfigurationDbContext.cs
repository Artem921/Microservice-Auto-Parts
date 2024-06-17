using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carts.Infrastructure.Configuration
{
    public static  class ConfigurationDbContext
    {
        public const string connectionString = "Host=localhost;Port=5433;Database=AutoParts_Cart;Username=postgres;Password=123";
    }
}
