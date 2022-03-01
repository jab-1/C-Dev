using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToTest;
    public class ClassificationException : ArgumentOutOfRangeException
    {
        public ClassificationException(string message) : base(message) {
    
        }
    }

