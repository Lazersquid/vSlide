using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Immutable;

namespace vSlide
{
    public partial class SliderLevelsPanel : UserControl
    {
        public bool IsUsingCustomValues
        {
            get { return customValuesCheckBox.Checked; }
            set
            {
                customValuesCheckBox.Checked = value;
                UpdateSliderLevelDecimalControls(
                    (sliderLevel, i) => sliderLevel.IsValueEditableByUser = value);

                if (!IsUsingCustomValues) SetAutoLevelValues();
            }
        }

        public int SliderLevelCount
        {
            get { return levelFactoriesFlowPanel.Controls.Count; }
            set
            {
                levelCountNumericUpDown.Value = value;
                var newValue = decimal.ToInt32(levelCountNumericUpDown.Value);
                var levelCountDelta = levelFactoriesFlowPanel.Controls.Count - newValue;

                levelFactoriesFlowPanel.SuspendLayout();
                while (levelCountDelta != 0)
                {
                    if(levelCountDelta > 0)
                    {
                        levelCountDelta--;
                        RemoveSliderLevel();
                    }
                    else
                    {
                        levelCountDelta++;
                        AddSliderLevel();
                    }
                }
                levelFactoriesFlowPanel.ResumeLayout();

                // unneeded scrollbar sometimes only disappears by reseting auto-scroll
                levelFactoriesFlowPanel.AutoScroll = false;
                levelFactoriesFlowPanel.AutoScroll = true;
                if (!IsUsingCustomValues) SetAutoLevelValues();
            }
        }
        
        protected int sliderLevelTitleFixedWidth = 55;
        public int SliderLevelTitleFixedWidth
        {
            get { return sliderLevelTitleFixedWidth; }
            set
            {
                sliderLevelTitleFixedWidth = value;
                UpdateSliderLevelDecimalControls(
                    (sliderLevel, i) => sliderLevel.FixedTitleWidth = value);
            }
        }

        protected string sliderLevelPrefix = "Level ";
        public string SliderLevelPrefix
        {
            get { return sliderLevelPrefix; }
            set
            {
                sliderLevelPrefix = value;
                UpdateSliderLevelDecimalControls(
                    (sliderLevel, i) => sliderLevel.Title = value + (i + 1).ToString());
            }
        }

        protected string sliderLevelSuffix = "%";
        public string SliderLevelSuffix
        {
            get { return sliderLevelSuffix; }
            set
            {
                sliderLevelSuffix = value;
                UpdateSliderLevelDecimalControls(
                    (sliderLevel, i) => sliderLevel.Suffix = sliderLevelSuffix);
            }
        }

        protected int seperationHeight = 3;
        public int SeperationHeight
        {
            get { return seperationHeight; }
            set
            {
                seperationHeight = value;
                UpdateSliderLevelDecimalControls(
                    (sliderLevel, i) => sliderLevel.Margin = new Padding(seperationHeight));
            }
        }

        public SliderLevelsPanel()
        {
            InitializeComponent();
            levelCountNumericUpDown.ValueChanged += LevelCountNumericUpDown_ValueChanged;
            customValuesCheckBox.CheckedChanged += CustomValuesCheckBox_CheckedChanged;
        }
        
        protected delegate void SliderLevelHandler(DecimalControl sliderLevelDecimalControl, int sliderLevelIndex);
        protected void UpdateSliderLevelDecimalControls(SliderLevelHandler sliderLevelHandler)
        {
            levelFactoriesFlowPanel.SuspendLayout();
            for (int i = 0; i < SliderLevelCount; i++)
            {
                var control = levelFactoriesFlowPanel.Controls[i];
                if (!(control is DecimalControl))
                    throw new ArgumentOutOfRangeException();

                var sliderLevel = (DecimalControl)control;
                sliderLevelHandler.Invoke(sliderLevel, i);
            }
            levelFactoriesFlowPanel.ResumeLayout();
        }

        protected void SetAutoLevelValues()
        {
            var stepSize = SliderLevelCount <= 1 ? 0 : decimal.Divide(100, SliderLevelCount-1);
            UpdateSliderLevelDecimalControls(
                (sliderLevel, i) => sliderLevel.Value = stepSize * i);
        }

        protected void AddSliderLevel()
        {
            var newControl = new DecimalControl
            {
                DecimalDigits = 1,
                Resolution = 0.5M,
                NumericUpDownIncrement = 0.5M,
                NumericUpDownWidth = 50,
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                IsValueEditableByUser = IsUsingCustomValues,
                FixedTitleWidth = sliderLevelTitleFixedWidth,
                Title = sliderLevelPrefix + (SliderLevelCount + 1).ToString(),
                Suffix = sliderLevelSuffix,
                Margin = new Padding(seperationHeight)
            };
            levelFactoriesFlowPanel.Controls.Add(newControl);
        }

        protected void RemoveSliderLevel()
        {
            levelFactoriesFlowPanel.Controls.RemoveAt(SliderLevelCount - 1);
        }

        protected void LevelCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SliderLevelCount = decimal.ToInt32(levelCountNumericUpDown.Value);
        }

        protected void CustomValuesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsUsingCustomValues = customValuesCheckBox.Checked;
        }

        public ImmutableArray<decimal> CreateSliderLevels()
        {
            var sliderLevels = new decimal[SliderLevelCount];
            for (int i = 0; i < SliderLevelCount; i++)
            {
                var control = levelFactoriesFlowPanel.Controls[i];
                if (!(control is DecimalControl))
                    throw new ArgumentOutOfRangeException();

                var sliderLevel = (DecimalControl)control;
                sliderLevels[i] = sliderLevel.ValueAsFactor;
            }

            return sliderLevels.ToImmutableArray();
        }
    }
}
