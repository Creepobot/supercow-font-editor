using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SupercowFontEditor
{
    public partial class SliderNumericUpDown : Panel
    {
        public delegate void ValueChangedHandler(object sender, EventArgs e);
        public event ValueChangedHandler ValueChanged;

        [DefaultValue(0)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Number of decimal places to display")]
        public int DecimalPlaces
        {
            get => numericUpDown1.DecimalPlaces;
            set => numericUpDown1.DecimalPlaces = value;
        }

        [DefaultValue(0)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Minimum value of numeric updown")]
        public float NumericUpDownMinimum
        {
            get => (float)numericUpDown1.Minimum;
            set => numericUpDown1.Minimum = (decimal)value;
        }

        [DefaultValue(100)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Maximum value of numeric updown")]
        public float NumericUpDownMaximum
        {
            get => (float)numericUpDown1.Maximum;
            set => numericUpDown1.Maximum = (decimal)value;
        }

        [DefaultValue(0)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Minimum value of trackbar")]
        public int TrackBarMinimum
        {
            get => trackBar1.Minimum;
            set => trackBar1.Minimum = value;
        }

        [DefaultValue(10)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Maximum value of trackbar")]
        public int TrackBarMaximum
        {
            get => trackBar1.Maximum;
            set => trackBar1.Maximum = value;
        }

        [DefaultValue(1)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Number of positions between the marks on the axis")]
        public int TickFrequency
        {
            get => trackBar1.TickFrequency;
            set => trackBar1.TickFrequency = value;
        }

        [DefaultValue(0)]
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Current value of the control")]
        public float Value
        {
            get => (float)numericUpDown1.Value;
            set => numericUpDown1.Value = (decimal)value;
        }

        public SliderNumericUpDown()
        {
            InitializeComponent();
        }

        public SliderNumericUpDown(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object s, EventArgs e)
        {
            Value = trackBar1.Value;
        }

        private void NumericUpDown1_ValueChanged(object s, EventArgs e)
        {
            var value = (int)numericUpDown1.Value;
            if (value > trackBar1.Maximum) value = trackBar1.Maximum;
            trackBar1.Value = value;
            ValueChanged?.Invoke(this, new EventArgs());
        }
    }
}
