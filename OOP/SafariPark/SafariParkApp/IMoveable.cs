﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public interface IMoveable
    {
        public String Move();
        public String Move(int times);
    }
}
