using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productdal;
        public ProductManager(IProductDal productdal )
        {
            _productdal = productdal;
        }

       


        public IDataResult<Product> GetByid(int productId)
        {
            return new SucccessDataResult<Product>(_productdal.Get(p => p.ProductId == productId)) ;
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SucccessDataResult<List<Product>>(_productdal.GetList().ToList()) ;
        }

        public IDataResult<List<Product>> GetByCategoryId(int categoryId)
        {
            return new SucccessDataResult<List<Product>>(_productdal.GetList(p => p.CategoryID == categoryId).ToList());
        }


        public IResult Add(Product product)
        {
            _productdal.Add(product);
            return new SuccessResult("Added");
        }

        public IResult Update(Product product)
        {
            _productdal.Update(product);
            return new SuccessResult("Updated");
        }

        public IResult Delete(Product product)
        {
            _productdal.Delete(product);
            return new SuccessResult("Deleted");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
