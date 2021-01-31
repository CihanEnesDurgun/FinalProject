using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

//eğer sadece entities erişsin istersek internal/ tüm classlar erişebilsin istersek de public yaparız.
//short int'in bir küçüğü
//decimal- fiyat tutmak için
