using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Business.Abstract;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        //EfProductDal _productDal = new EfProductDal();

        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;


        }

        public List<Product> GetAll()
        {
            //Buisness Code
            
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int ctegoryId)
        {

            var a = _productDal.GetAll().Where(p => p.CategoryId == ctegoryId);
            return a.ToList();
        }

        public List<Product> GetProductsByName(string text)
        {

            
            var a = _productDal.GetAll().Where(p => p.ProdyctName.ToLower().Contains(text) );

            return a.ToList();
        }
    }
}
