using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_10_3_16
{
    class TimePeriod  //Internally my class stores time in seconds.  
    {

        private double seconds;

        public double Hours
        {
            get { return this.seconds / 3600; }  //If you get something you bring it back - return
            set { this.seconds = value * 3600;  }   //seconds = the value of hours * 3600
        }
        
       


    }
}
