using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context){
            if (context.Products.Any()) return;

            var products = new List<Product>{
                new Product{
                    Name = "fdsf",
                    Description = "fdsfs",
                    Price = 1000,
                    ImageUrl = "/images/...",
                    Brand = "Something",
                    Type = "gloves",
                    QuantityInStock = 7
                },
                                new Product{
                    Name = "ccv",
                    Description = "cxv",
                    Price = 454,
                    ImageUrl = "/images/...",
                    Brand = "vcx",
                    Type = "glovcxves",
                    QuantityInStock = 47
                },
            };
            foreach(var product in products){
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}