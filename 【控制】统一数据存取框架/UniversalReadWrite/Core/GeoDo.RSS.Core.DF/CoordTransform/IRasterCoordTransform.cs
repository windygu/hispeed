﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoDo.RSS.Core.DF
{
    public interface IRasterCoordTransform:ICoordTransform
    {
        void GetGeoTransform(double[] affinePoints);
    }
}
