using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Shared.Utilities.Result.Abstract;
using ZenBlog.Shared.Utilities.Result.ComplexTypes;

namespace ZenBlog.Shared.Utilities.Result.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }

        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            exception = Exception;
        }
        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }

        //New Result(ResultStatus.Error,expception.message,expception)
    }
}
