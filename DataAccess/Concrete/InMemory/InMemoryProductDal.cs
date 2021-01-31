using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,SQLServer,MangoDb den geliyormuş gibi 
            _products = new List<Product> {
               new Product{ProductID=1, CategoryID=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15 },
               new Product{ProductID=2, CategoryID=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3 },
               new Product{ProductID=3, CategoryID=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2 },
               new Product{ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65 },
               new Product{ProductID=5, CategoryID=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1 },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        
            public void Delete(Product product)
            {
            //LINQ Language Integrated Query (Dile dayalı kodlama)
            //Lambda=  "=>"
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            //her p için tek tek dolaş* anlamına geliyor bu kod
            //.SingleOrDefault(p =>); bu kod üstteki foreach'ı yapıyor.

            _products.Remove(productToDelete);
            }

       
        public List<Product> GetAll()
        {
            return _products;
            //veri tabanını olduğu gibi döndürüyorum
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            //güncellenecek ürünü bulalım.
            //gönderdiğim ürün ID'sine sahip olan listedeki ürünü bul demek.
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

    }
}
