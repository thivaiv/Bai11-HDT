/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai11
{
    public sealed class SmokeSensorAdapter : ISensor
    {
        private readonly LegacySmokeDetector legacy;

        public SmokeSensorAdapter(LegacySmokeDetector legacy)
        {
            this.legacy = legacy ??
                throw new ArgumentNullException(nameof(legacy));
        }

        public double ReadValue()
        {
            return legacy.GetSmokeLevel() / 10.0;
        }

        public string GetUnit() => "% smoke";
    }
}
