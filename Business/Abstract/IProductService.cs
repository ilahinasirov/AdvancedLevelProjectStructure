using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product>  GetByid(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetByCategoryId (int categoryId);
        IResult Add (Product product);
        IResult Update (Product product);
        IResult Delete (Product product);
    }
}
