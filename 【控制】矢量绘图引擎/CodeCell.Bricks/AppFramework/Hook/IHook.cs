﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CodeCell.Bricks.AppFramework
{
    public interface IHook
    {
        IApplication Application { get; }
        ICommandHelper CommandHelper { get; }
        ToolStripItem Control { get; }
        Control ContainerControl { get; }
    }
}
