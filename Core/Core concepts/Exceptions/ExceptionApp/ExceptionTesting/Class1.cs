using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    public class ExceptionGreaterThanMaxValue : ArgumentOutOfRangeException
    {

        public ExceptionGreaterThanMaxValue(String message) : base(message)
        {

        }
    }


}
