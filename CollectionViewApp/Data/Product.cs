
 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewApp.Data
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Source { get; set; }
    }

    public class Products : ObservableCollection<Product>
    {
        public Products()
        {
            Add(new Product() { ProductName="Apple", Source= "apple.png"});
            Add(new Product() { ProductName = "M13", Source = "mthree.png" });
            Add(new Product() { ProductName = "One pLus", Source = "op.png" });
            Add(new Product() { ProductName = "Oppo", Source = "oppo.png" });
            Add(new Product() { ProductName = "RealMe", Source = "realme.png" });
        }
    }
}
