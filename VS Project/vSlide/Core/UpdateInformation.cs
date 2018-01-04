using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace vSlide
{
    public class UpdateInformation
    {
        public int ElapsedMs { get; }
        public int MaxSliderValueAbs { get; }
        public ImmutableArray<decimal> SliderLevels { get; }

        protected int sliderValueAbs;
        public int SliderValueAbs
        {
            get { return sliderValueAbs; }
            set
            {
                value = Math.Max(value, 0);
                value = Math.Min(value, MaxSliderValueAbs);
                sliderValueAbs = value;
            }
        }
        
        public decimal SliderValue
        {
            get { return decimal.Divide(SliderValueAbs, MaxSliderValueAbs); }
            set
            {
                value = Math.Max(value, 0);
                value = Math.Min(value, 1);
                SliderValueAbs = ToAbs(value);
            }
        }

        protected ISliderMode sliderMode;
        public ISliderMode SliderMode
        {
            get { return sliderMode; }
            set
            {
                sliderMode = value ?? throw new ArgumentNullException();
            }
        }

        public UpdateInformation(int elapsedMs, int maxSliderValueAbs, int sliderValueAbs, ImmutableArray<decimal> sliderLevels, ISliderMode sliderMode)
        {
            if (sliderLevels == null) throw new ArgumentNullException(nameof(sliderLevels));

            ElapsedMs = elapsedMs;
            MaxSliderValueAbs = maxSliderValueAbs;
            SliderValueAbs = sliderValueAbs;
            SliderLevels = sliderLevels;
            SliderMode = sliderMode;
        }

        /// <summary>
        /// Returns product of relative slider value (a factor between 0 and 1) and absolute maximum slider value
        /// </summary>
        /// <param name="relativeValueAsFactor"></param>
        /// <returns></returns>
        public int ToAbs(decimal relativeValueAsFactor)
        {
            if (relativeValueAsFactor > 1) throw new ArgumentOutOfRangeException();
            if (relativeValueAsFactor < 0) throw new ArgumentOutOfRangeException();
            var result = (int)(relativeValueAsFactor * MaxSliderValueAbs);
            result = Math.Max(result, 0);
            result = Math.Min(result, MaxSliderValueAbs);
            return result;
        }
    }
}
