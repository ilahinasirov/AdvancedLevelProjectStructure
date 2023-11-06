using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface ITestViewService
    {
        IDataResult<List<MyTestView>> GetViewList();
    }
}
