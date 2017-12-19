﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using GeoDo.RSS.Core.UI;
using System.Windows.Forms;

namespace GeoDo.RSS.MIF.Prds.CLD
{
    [Export(typeof(ICommand)), ExportMetadata("VERSION", "1")]
    public class cmdSeriesMeanStat : Command
    {
        public cmdSeriesMeanStat()
            : base()
        {
            _id = 35218;
            _text = _name = "长时间序列均值统计";
        }

        public override void Execute()
        {

            ISmartWindow smartWindow = _smartSession.SmartWindowManager.GetSmartWindow((w) => { return w.GetType() == typeof(dockSeriesMean); });
            if (smartWindow == null)
            {
                smartWindow = new dockSeriesMean(_smartSession);
                _smartSession.SmartWindowManager.DisplayWindow(smartWindow);
            }
            else
                _smartSession.SmartWindowManager.DisplayWindow(smartWindow);
            return;

       }
    }
}
