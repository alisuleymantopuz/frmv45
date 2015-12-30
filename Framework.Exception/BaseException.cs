using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Exception
{
    public abstract class BaseException : System.Exception
    {
        public List<int> ErrorCodes { get; set; }


        public int ErrorCode
        {
            get
            {
                if (this.ErrorCodes != null && this.ErrorCodes.Count > 0)
                    return this.ErrorCodes[0];
                else
                    return 0;
            }
        }

        public BaseException(List<int> errorCodes)
            : base(string.Join(",",errorCodes.ToArray()))
        {
            this.ErrorCodes = errorCodes;
        }


        public BaseException(int errorCode)
            : base(errorCode.ToString())
        {
            this.ErrorCodes = new List<int>();
            this.ErrorCodes.Add(errorCode);
        }


        public BaseException(string message)
            : base(message)
        {

        }




    }
}
