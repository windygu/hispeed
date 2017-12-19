using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Telerik.WinControls
{
    // NOT TESTED REASON:
    // NO POINTF PROPERTY AVAILABLE AT THE MOMENT 

    public partial class PointFAnimationForm : AnimationForm
    {
        public PointFAnimationForm()
        {
            InitializeComponent();
            this.generalAnimationSettings1.groupBox2.Visible = false;
        }

        private void PointFAnimationForm_Load(object sender, EventArgs e)
        {
            Decimal minValue = Decimal.MinValue;
            Decimal maxValue = Decimal.MaxValue;

            int decimalPlaces = 0;

            if (Property.PropertyType == typeof(float))
            {
                decimalPlaces = 2;
            }
            else if (Property.PropertyType == typeof(double))
            {
                decimalPlaces = 3;
            }

            this.numericUpDownStart1.Minimum = minValue;
            this.numericUpDownStart1.Maximum = maxValue;
            this.numericUpDownStart1.DecimalPlaces = decimalPlaces;
            this.numericUpDownEnd1.Minimum = minValue;
            this.numericUpDownEnd1.Maximum = maxValue;
            this.numericUpDownEnd1.DecimalPlaces = decimalPlaces;

            if (AnimatedSetting.Value != null)
            {
                if (Property.PropertyType == typeof(PointF))
                {
                    PointF pt = (PointF)AnimatedSetting.Value;
                    this.numericUpDownStart1.Value = Convert.ToDecimal(pt.X); //Convert.ToDecimal((float)XmlPropertySetting.DeserializeValue(Property, AnimatedSetting.Value));
                    this.numericUpDownEnd1.Value = Convert.ToDecimal(pt.Y);
                }
                if (this.numericUpDownStart1.Value == 0)
                    this.checkBoxUseCurrentValue.Checked = true;
            }
            if (AnimatedSetting.EndValue != null)
            {
                PointF pt = (PointF)AnimatedSetting.EndValue;
                this.numericUpDownStart2.Value = Convert.ToDecimal(pt.X); //Convert.ToDecimal((float)XmlPropertySetting.DeserializeValue(Property, AnimatedSetting.Value));
                this.numericUpDownEnd2.Value = Convert.ToDecimal(pt.Y);             
            }
        }

        public override void GetSetting()
        {
            base.GetSetting();

            this.generalAnimationSettings1.GetValues();

            this.AnimatedSetting.Property = AnimatedSetting.Property;
            this.AnimatedSetting.StartValueIsCurrentValue = (this.checkBoxUseCurrentValue.Checked);
        
            if (this.checkBoxUseCurrentValue.Checked)
                this.AnimatedSetting.Value = null;
            else
                this.AnimatedSetting.Value = new PointF((float)(this.numericUpDownStart1.Value),
                    (float)(this.numericUpDownEnd1.Value) );


            if (this.AnimatedSetting.AnimationType == RadAnimationType.ByStartEndValues)
            {
                this.AnimatedSetting.EndValue = new PointF((float)(this.numericUpDownStart2.Value),
                    (float)(this.numericUpDownEnd2.Value));
            }

        }

        private object ConvertFromDecimal(Decimal value)
        {
            if (this.Property.PropertyType == typeof(int))
            {
                return Convert.ToInt32(value);
            }

            if (this.Property.PropertyType == typeof(float))
            {
                return (float)Convert.ToDouble(value);
            }

            if (this.Property.PropertyType == typeof(double))
            {
                return Convert.ToDouble(value);
            }

            if (this.Property.PropertyType == typeof(decimal))
            {
                return value;
            }

            throw new ArgumentException("Internal error: Expected property type int, float, double or decimal type, but was: " + this.Property.PropertyType.FullName);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.GetSetting();
            if (this.AnimatedSetting.AnimationType == RadAnimationType.ByStartEndValues)
            {
                if (this.AnimatedSetting.EndValue == null)//string.IsNullOrEmpty(this.AnimatedSetting.EndValue))
                {
                    MessageBox.Show("Please specify animation EndValue or change animation type to 'By Step'");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void checkBoxUseCurrentValue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseCurrentValue.Checked)
            {
                this.numericUpDownStart1.Enabled = false;
                this.numericUpDownEnd1.Enabled = false;
            }
            else
            {
                this.numericUpDownStart1.Enabled = true;
                this.numericUpDownEnd1.Enabled = true;
            }
        }
    }
}