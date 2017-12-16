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
        protected uint elapsedMs;
        public uint ElapsedMs
        {
            get { return elapsedMs; }
        }

        protected readonly int sliderMax;
        public int SliderMax
        {
            get { return sliderMax; }
        }

        protected readonly ImmutableArray<decimal> sliderLevels;
        public ImmutableArray<decimal> SliderLevels
        {
            get { return sliderLevels; }
        }

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
                value = Math.Min(value, SliderMax);
                sliderValueAbs = value;
            }
        }
        
        public decimal SliderValue
        {
            get
            {
                return decimal.Divide(SliderValueAbs, SliderMax);
            }
            set
            {
                value = Math.Max(value, 0);
                value = Math.Min(value, 1);
                SliderValueAbs = (int)(SliderMax * value);
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

        public UpdateInformation(uint elapsedMs, int sliderMax, ImmutableArray<decimal> sliderLevels, int sliderValueAbs, bool isInterpolating, bool isReturningToCenter)
        {
            if (sliderLevels == null) throw new ArgumentNullException(nameof(sliderLevels));

            this.elapsedMs = elapsedMs;
            this.sliderMax = sliderMax;
            this.sliderLevels = sliderLevels;
            this.sliderValueAbs = sliderValueAbs;
            this.isInterpolating = isInterpolating;
            this.isReturningToCenter = isReturningToCenter;
        }
    }
}
