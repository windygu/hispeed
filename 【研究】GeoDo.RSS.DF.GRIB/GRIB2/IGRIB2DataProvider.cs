﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoDo.RSS.DF.GRIB
{
    interface IGRIB2DataProvider:IGRIBDataProvider
    {
        GRIB_Point[] Read(string parameter);
    }
}
