using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestStatistics
    {
        private float _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;

        public void AddScore(float score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentException("Please enter a score between 0 and 100.");
            }
            else if (score > 0 && score < 100)
            {
                _count++;
                _sum += score;
                _avg = _sum / _count;
                _min = Math.Min(_min, score);
                _max = Math.Max(_max, score);
            }
        }
        public float Count { get { return _count; } }
        public float Sum { get { return _sum; } }
        public float Min { get { return _min; } }
        public float Max { get { return _max; } }
        public float Average { get { return _avg; } }
    }
}
