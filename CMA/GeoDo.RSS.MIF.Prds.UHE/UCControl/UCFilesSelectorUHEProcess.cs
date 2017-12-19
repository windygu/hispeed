﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeoDo.RSS.MIF.Core;
using System.IO;
using GeoDo.RSS.Core.DF;

namespace GeoDo.RSS.MIF.Prds.UHE
{
    /// <summary>
    /// 待计算文件选择方式
    /// 1、选择多个文件，返回Dictionary<"FileNames",_fileNames>;
    /// 2、选择局地文件夹路径，返回Dictionary<"DirectoryPath",_dirPath>;
    /// </summary>
    public partial class UCFilesSelectorUHEProcess : UserControl, IArgumentEditorUI
    {
        private string[] _fileNames = null;
        private string _dirPath = string.Empty;
        private Action<object> _handle = null;
        private Dictionary<string, string[]> _result = null;
        private string _saveFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MonitoringProductArgs", "UHE", "产品文件夹路径.txt");

        public UCFilesSelectorUHEProcess()
        {
            InitializeComponent();
            InitArgument();
            GetDefaultPathFromTxt();
        }

        private void GetDefaultPathFromTxt()
        {
            if (!File.Exists(_saveFile))
                return;
            using (StreamReader sr = new StreamReader(_saveFile, Encoding.GetEncoding("GB2312")))
            {
                _dirPath = sr.ReadToEnd();
                if (Directory.Exists(_dirPath))
                    cmbDirPath.Text = _dirPath;
            }
        }

        private void InitArgument()
        {
            _result = new Dictionary<string, string[]>();
        }

        private void robFiles_CheckedChanged(object sender, EventArgs e)
        {
            lsbFileNames.Enabled = robFiles.Checked;
            btnOpenFiles.Enabled = robFiles.Checked;
            btnDelete.Enabled = robFiles.Checked;
            btnOK_Click(null, null);
        }

        private void robDirectory_CheckedChanged(object sender, EventArgs e)
        {
            cmbDirPath.Enabled = robDirectory.Checked;
            btnOpenDir.Enabled = robDirectory.Checked;
            btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_handle != null)
                _handle(GetArgument());
        }

        private object GetArgument()
        {
            _result.Clear();
            if (robFiles.Checked)
            {
                _fileNames = GetFileNamesFromLsb();
                _result.Add("FileNames", _fileNames);
            }
            if (robDirectory.Checked)
            {
                string path = cmbDirPath.Text;
                if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                {
                    _dirPath = path;
                    _result.Add("DirectoryPath", new string[] { _dirPath });
                }
            }
            return _result;
        }

        private string[] GetFileNamesFromLsb()
        {
            if (lsbFileNames.Items.Count == 0)
                return null;
            List<string> names = new List<string>();
            foreach (FileItemInfo item in lsbFileNames.Items)
            {
                if (item != null)
                    names.Add(item.FileName);
            }
            return names.Count != 0 ? names.ToArray() : null;
        }

        #region IArgumentEditorUI 成员
        public object GetArgumentValue()
        {
            _result.Clear();
            if (robFiles.Checked)
                _result.Add("FileNames", _fileNames);
            if (robDirectory.Checked)
                _result.Add("DirectoryPath", new string[] { _dirPath });
            return _result;
        }

        public void SetChangeHandler(Action<object> handler)
        {
            _handle = handler;
        }

        public object ParseArgumentValue(System.Xml.Linq.XElement ele)
        {
            robDirectory.Checked = true;
            return null;
        }
        #endregion

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _dirPath = dlg.SelectedPath;
                    cmbDirPath.Text = _dirPath;
                }
            }
            SaveDefaultFile();
            btnOK_Click(null, null);
        }

        private void SaveDefaultFile()
        {
            if (string.IsNullOrEmpty(_dirPath))
                return;
            if (!File.Exists(_saveFile))
            {
                string dir = Path.GetDirectoryName(_saveFile);
                Directory.CreateDirectory(dir);
            }
            using (StreamWriter sw = new StreamWriter(_saveFile, false, Encoding.GetEncoding("GB2312")))
            {
                sw.Write(_dirPath);
            }
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "产品文件(*.dat)|*.dat|所有文件(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AddFiles(dlg.FileNames);
            }
            btnOK_Click(null, null);
        }

        private void AddFiles(string[] value)
        {
            if (value != null && value.Length != 0)
            {
                foreach (string s in value)
                {
                    if (!Exist(s) && IsSameTypeFile(s))
                        lsbFileNames.Items.Add(new FileItemInfo(s));
                }
            }
        }

        private bool Exist(string fileName)
        {
            if (lsbFileNames.Items == null || lsbFileNames.Items.Count == 0)
                return false;
            foreach (FileItemInfo item in lsbFileNames.Items)
            {
                if (item.FileName == fileName)
                    return true;
            }
            return false;
        }

        bool _isFirst = true;
        string _satellite = null;
        string _sensor = null;
        int _bandCount = 0;
        private bool IsSameTypeFile(string fileName)
        {
            using (IRasterDataProvider prd = GeoDataDriver.Open(fileName) as IRasterDataProvider)
            {
                if (_isFirst)
                {
                    _satellite = prd.DataIdentify.Satellite;
                    _sensor = prd.DataIdentify.Sensor;
                    _bandCount = prd.BandCount;
                    _isFirst = false;
                    return true;
                }
                else
                {
                    if (prd.DataIdentify.Satellite != _satellite || prd.DataIdentify.Sensor != _sensor
                     || prd.BandCount != _bandCount)
                        return false;
                    else
                        return true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsbFileNames.SelectedItem == null)
                return;
            List<FileItemInfo> items = new List<FileItemInfo>();
            foreach (FileItemInfo item in lsbFileNames.SelectedItems)
                items.Add(item);
            foreach (FileItemInfo item in items)
                lsbFileNames.Items.Remove(item);
            btnOK_Click(null, null);
        }

        private void cmbDirPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK_Click(null, null);
        }

        private void cmbDirPath_TextChanged(object sender, EventArgs e)
        {
            btnOK_Click(null, null);
        }
    }

    internal class FileItemInfo
    {
        public string FileName;

        public FileItemInfo(string fileName)
        {
            FileName = fileName;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(FileName))
                return base.ToString();
            else
                return Path.GetFileName(FileName);
        }
    }
}
