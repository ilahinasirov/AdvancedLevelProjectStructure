using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTestViewDal:EfEntityRepositoryBase<MyTestView,NorthWindContext>,ITestViewDal
    {
    }
}
