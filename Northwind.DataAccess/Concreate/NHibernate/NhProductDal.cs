using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concreate.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
     

        public Product Get(Experession<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
       

        public List<Product> GetAll(Experession<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{
                    ProductId=1,
                    CategoryId=1,
                    ProductName="Laptop",
                    QuantityPerUnit="1 in a box",
                    UnitPrice=3000}
            };
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
