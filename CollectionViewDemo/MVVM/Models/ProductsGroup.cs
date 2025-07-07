using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.MVVM.Models
{
    public class ProductsGroup : List<Produkt>
    {
        public string Name {  get; set; }
        public ProductsGroup(string name, List<Produkt> products) : base(products)
        {
            Name = name;
        }
    }
}
