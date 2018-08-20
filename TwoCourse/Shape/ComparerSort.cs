﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ComparerSort : IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            if (x.GetArea() > y.GetArea()) { return 1; }
            else if (x.GetArea() < y.GetArea()) { return -1; }
            else { return 0; }
        }
    }
}