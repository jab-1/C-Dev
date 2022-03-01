using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    public class GradeException : ArgumentOutOfRangeException
    {

        public GradeException(String message) : base(message)
        {

        }
    }

    
}
