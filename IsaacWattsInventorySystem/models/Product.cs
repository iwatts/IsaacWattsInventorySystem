using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    class Product
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

        public Product(Product product)
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
