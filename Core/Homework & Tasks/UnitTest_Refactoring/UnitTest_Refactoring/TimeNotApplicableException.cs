using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToTest;
public class TimeNotApplicableException : ArgumentOutOfRangeException 
{

    public TimeNotApplicableException(String message) : base(message) { 


    }
}
