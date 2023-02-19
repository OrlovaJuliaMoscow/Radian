using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_1
{
    internal class Clock
    {
        int hour;
        int minutes;
        int seconds;

        public int Hour
        {
            get
            {
               return hour;          
            }  
                set
            {
                hour= value %24;
                
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                Hour += value / 60;
                Minutes = value % 60;   

            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                Minutes += value / 60;
                Seconds = value % 60;
            }
        }

        public Clock(int hour, int minutes, int seconds)
        {
            this.Hour = hour;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public int ToSecond()
        {
            return seconds + minutes * 60 + hour * 60 * 60;

        }
    }
}
