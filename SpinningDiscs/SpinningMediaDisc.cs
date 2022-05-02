using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class SpinningMediaDisc
    {
        internal string Data { get; set; }
        internal bool isBlank { get; set; }

        public int? YearReleased { get; }

        public  SpinningMediaDisc(string discData, bool discIsBlank, int date)
        {
            Data = discData;
            isBlank = discIsBlank;
            YearReleased = date;
        }
        public abstract string Play();
    }

    
}
