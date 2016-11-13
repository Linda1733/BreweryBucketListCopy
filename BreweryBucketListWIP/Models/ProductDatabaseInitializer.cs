using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BreweryBucketListWIP.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category 
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                }, 
                new Category 
                { 
                    CategoryID = 2, 
                    CategoryName = "Planes"
                }, 
                new Category
                {
                    CategoryID = 3, 
                    CategoryName = "Trucks"
                }, 
                new Category
                {
                    CategoryID = 4, 
                    CategoryName = "Boats"
                }, 
                new Category
                {
                    CategoryID = 5, 
                    CategoryName = "Rockets"
                }
            };

            return categories; 
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>{ 
                new Product
                {
                    ProductID = 1, 
                    ProductName = "Convertible Car", 
                    Description = "Convertible Car description", 
                    ImagePath = "insert png", 
                    UnitPrice = 22.50, 
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2, 
                    ProductName = "Old-time Car", 
                    Description = "Old-time Car description", 
                    ImagePath = "insert old time png", 
                    UnitPrice = 15.95, 
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3, 
                    ProductName = "Fast Car", 
                    Description = "Fast Car description", 
                    ImagePath = "Fast car png", 
                    UnitPrice = 32.99, 
                    CategoryID = 1
                }
            };
        
            return products;
        }
    }
}


