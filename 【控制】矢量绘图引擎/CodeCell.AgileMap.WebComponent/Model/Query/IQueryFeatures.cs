﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCell.AgileMap.WebComponent
{
    public interface IQueryFeatures
    {
        Feature[] Query(QueryFilter filter);
    }
}
