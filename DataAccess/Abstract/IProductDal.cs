using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal  // I interface- Product Entity- Dal dataaccesslayer
    {
        List<Product> GetAll(); // entities den buraya bağladık
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllCategory(int CategoryId);

    }
}
