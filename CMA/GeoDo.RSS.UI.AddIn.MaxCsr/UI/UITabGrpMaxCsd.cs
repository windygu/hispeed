﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using GeoDo.RSS.Core.UI;

namespace GeoDo.RSS.UI.AddIn.MaxCsr
{
    public partial class UITabGrpMaxCsd : UserControl, IUIGroupProvider
    {
        RadRibbonBar _bar = null;
        RibbonTab _tab = null;
        RadRibbonBarGroup rbgMaxCsd = new RadRibbonBarGroup();
        ISmartSession _session = null;
        RadButtonElement _btnCompute = new RadButtonElement("晴空数据集计算");

        public UITabGrpMaxCsd()
        {
            InitializeComponent();
            CreateRibbonBar();
        }

        private void CreateRibbonBar()
        {
            _bar = new RadRibbonBar();
            _bar.Dock = DockStyle.Top;
            _tab = new RibbonTab();
            _tab.Title = "晴空数据集";
            _tab.Text = "晴空数据集";
            _tab.Name = "晴空数据集";

            rbgMaxCsd.Text = "晴空数据集";
            _btnCompute.Margin = new Padding(2, 2, 2, 2);
            _btnCompute.TextAlignment = ContentAlignment.BottomCenter;
            _btnCompute.ImageAlignment = ContentAlignment.TopCenter;
            _btnCompute.Click += new EventHandler(_btnCompute_Click);
            rbgMaxCsd.Items.Add(_btnCompute);  
        }

        void _btnCompute_Click(object sender, EventArgs e)
        {
            ICommand cmd = _session.CommandEnvironment.Get(4501);
            if (cmd != null)
            {
                cmd.Execute();
            }
        }

        public object Content
        {
            get { return rbgMaxCsd; }
        }

        public void Init(ISmartSession session, params object[] arguments)
        {
            this._session = session;
            SetImage();
        }

        public void UpdateStatus()
        {

        }

        private void SetImage()
        {
            _btnCompute.Image = _session.UIFrameworkHelper.GetImage("system:CSR.png");
        }
    }
}
