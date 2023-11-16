using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    internal class Product : IComparable<Product>
    {
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int CompareTo(Product? other)
        {
            return Description!.CompareTo(other!.Description);
        }

        public override string ToString()
        {
            return $"{Description}, price: {Price:N2}, quantity: {Quantity} ";
        }
    }
}
