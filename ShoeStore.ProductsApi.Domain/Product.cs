using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.ProductsApi.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int Rank { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Cost { get; set; }

        public int Stock { get; set; }        
    }
}
