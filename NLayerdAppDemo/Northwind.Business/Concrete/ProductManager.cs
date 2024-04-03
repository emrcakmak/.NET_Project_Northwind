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


    }
}
