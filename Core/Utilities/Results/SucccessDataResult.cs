using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SucccessDataResult<T>:DataResult<T>
    {
        public SucccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SucccessDataResult(T data) : base(data, true)
        {
        }
    }
}
