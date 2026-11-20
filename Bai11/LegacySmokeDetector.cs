/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai11
{
    public sealed class LegacySmokeDetector
    {
        private int smokeLevel;

        public LegacySmokeDetector(int smokeLevel)
        {
            this.smokeLevel = smokeLevel;
        }

        public int GetSmokeLevel() => smokeLevel;
        public string GetDescription() => "Legacy smoke detector";
        public void SetSmokeLevel(int value)
        {
            smokeLevel = Math.Clamp(value, 0, 1000);
        }
    }
}
