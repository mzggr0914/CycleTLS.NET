﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTLS.Interfaces
{
    public interface ICycleServer : IDisposable
    {
        public bool Start();
    }
}
