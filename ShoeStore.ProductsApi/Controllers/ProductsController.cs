using ShoeStore.ProductsApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoeStore.ProductsApi.Controllers
{
    [RoutePrefix("api/v1")]
    public class ProductsController : ApiController
    {

        [Route("products")]
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "iPhone 8",
                Code = "iP8",
                Cost = 1000,
                ShortDescription = "iPhone 8 mobile phone",
                LongDescription = "iPhone 8 mobile phone is better",
                Rank = 1,
                Stock = 3
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "iPhone X",
                Code = "iPX",
                Cost = 2000,
                ShortDescription = "iPhone X mobile phone",
                LongDescription = "iPhone X mobile phone is better",
                Rank = 2,
                Stock = 5
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "iPhone 7",
                Code = "iP7",
                Cost = 2000,
                ShortDescription = "iPhone 7 mobile phone",
                LongDescription = "iPhone 7 mobile phone is better",
                Rank = 3,
                Stock = 8
            });

            return products;
        }
    }
}
