﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rx.EntityFrameworkCore
{
    internal class InstanceRepository
    {
        public Type Entity { get; set; }

        public object Repository  { get; set; }
        
    }
}
