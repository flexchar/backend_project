using System.Collections.Generic;
using System.Linq;
using Backend.Models;

namespace Backend.Models.ViewModels
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine item = lineCollection.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();

            if (item == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) => lineCollection.RemoveAll(i => i.Product.ProductId == product.ProductId);

        public decimal ComputeTotalValue() => lineCollection.Sum(el => el.Product.Price * el.Quantity);

        public virtual void Clear() => lineCollection.Clear();
        public List<CartLine> Lines => lineCollection;

    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}