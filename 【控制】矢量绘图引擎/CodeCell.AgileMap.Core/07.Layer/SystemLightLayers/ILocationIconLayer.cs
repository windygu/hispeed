﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCell.AgileMap.Core
{
    public interface ILocationIconLayer:ILightLayer
    {
        void Clear();
        void Add(LocationIcon locationIcon);
    }
}
