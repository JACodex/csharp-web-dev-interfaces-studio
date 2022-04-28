using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SpinningDiscs
{
    internal class MediaSorter : IComparer<SpinningMediaDisc>
    {
        public int Compare( SpinningMediaDisc x,  SpinningMediaDisc y)
        {
            if(x.YearReleased > y.YearReleased)
            {
                return 1;
            }else if (x.YearReleased < y.YearReleased)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
