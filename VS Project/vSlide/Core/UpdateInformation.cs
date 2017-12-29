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
        protected int elapsedMs;
        public int ElapsedMs
        {
            get { return elapsedMs; }
        }

        public readonly int MaxSliderValueAbs;

        public readonly ImmutableArray<decimal> SliderLevels;

        protected bool wasSliderModified = false;
        public bool WasSliderModified
        {
            get { return wasSliderModified; }
        }

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
            get
            {
                return decimal.Divide(SliderValueAbs, MaxSliderValueAbs);
            }
            set
            {
                value = Math.Max(value, 0);
                value = Math.Min(value, 1);
                SliderValueAbs = (int)(MaxSliderValueAbs * value);
            }
        }

        protected bool isInterpolating;
        public bool IsInterpolating
        {
            get { return isInterpolating; }
            set
            {
                isInterpolating = value;
            }
        }

        protected bool isReturningToCenter;
        public bool IsReturningToCenter
        {
            get { return isReturningToCenter; }
            set
            {
                isReturningToCenter = value;
            }
        }

        public UpdateInformation(int elapsedMs, int maxSliderValueAbs, ImmutableArray<decimal> sliderLevels, int sliderValueAbs, bool isInterpolating, bool isReturningToCenter)
        {
            if (sliderLevels == null) throw new ArgumentNullException(nameof(sliderLevels));

            this.elapsedMs = elapsedMs;
            this.MaxSliderValueAbs = maxSliderValueAbs;
            this.SliderLevels = sliderLevels;
            this.sliderValueAbs = sliderValueAbs;
            this.isInterpolating = isInterpolating;
            this.isReturningToCenter = isReturningToCenter;
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
