using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Telerik.WinControls.Themes.ControlDefault
{
    public partial class Panel : ControlDefaultThemeComponent
    {
        public Panel()
        {
            InitializeComponent();
        }

        public Panel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
