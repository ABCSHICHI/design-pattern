﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.DrawAPI
{
    public interface IDraw
    {
        void DrawCircle(int radius, int x, int y);
    }
}
