﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3._2
{
    public interface IHashFunction
    {
        public int HashFunction(string value, int hashSize);
    }
}
