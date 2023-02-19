using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radian
{
    internal class Corner
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;

            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                Min = value % 60;

            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                Sec = value % 60;
            }
        }

        public Corner(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public int ToRadian()
        {
            return ((gradus + (sec + (min / 60)) / 60) + (sec + (min / 60)) / 60) * Math.PI / 180;
            //gradus + (sec + min / 60) / 60;

        }
    }
}
