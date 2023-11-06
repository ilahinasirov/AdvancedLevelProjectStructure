using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class TestViewManager:ITestViewService
    {
        private ITestViewDal _testViewDal;

        public TestViewManager(ITestViewDal testViewDal)
        {
            _testViewDal = testViewDal;
        }

        public IDataResult<List<MyTestView>> GetViewList()
        {
            return new SucccessDataResult<List<MyTestView>>(_testViewDal.GetList().ToList());
        }
    }
}
