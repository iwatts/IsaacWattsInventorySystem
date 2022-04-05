using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public static BindingList<Product> products = new BindingList<Product>();
        private Product product;

        static Product()
        {
            products.Add(new Product{
                ProductID = 0,
                Name = "Blue Bike",
                Price = 12.00f,
                InStock = 3,
                Min = 1,
                Max = 10,
                AssociatedParts = new BindingList<Part>(Part.parts.Where(data => (data.PartID == 1 || data.PartID == 3)).ToList())
            });
            products.Add(new Product
            {
                ProductID = 1,
                Name = "Red Bike",
                Price = 16.00f,
                InStock = 8,
                Min = 1,
                Max = 50,
                AssociatedParts = new BindingList<Part>(Part.parts.Where(data => (data.PartID == 1 || data.PartID == 2)).ToList())
            });
            products.Add(new Product
            {
                ProductID = 2,
                Name = "Green Bike",
                Price = 18.00f,
                InStock = 8,
                Min = 1,
                Max = 20,
                AssociatedParts = new BindingList<Part>(Part.parts.Where(data => (data.PartID == 0 || data.PartID == 3)).ToList())
            });
        }

        public Product(Product product = null)
        {
            if (!Object.ReferenceEquals(null, product)) { this.product = product; }
        }

        public void deleteProduct(int productPosition)
        {
            products.RemoveAt(productPosition);
        }

        public void addProduct(Product product)
        {
            products.Add(new Product(product));
        }

        public void modifyProduct(int productPosition, Product product)
        {
            products[productPosition] = new Product(product);
        }
    }
}
