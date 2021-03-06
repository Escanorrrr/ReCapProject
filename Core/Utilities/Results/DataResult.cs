using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T Data,bool success, string message) : base(success, message)
        {
            Data = Data;
        }

        public DataResult(T Data, bool success):base(success)
        {
            Data=Data;
        }
        public T Data { get;}   
    }
}
