using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntellectUniCup
{
    class cratebase :MapPoint
    {
   
        public char name;

        // constructor for making bases 
        public cratebase (double x1, double y1 , char  name1 )
        {
            this.x = x1;
            this.y = y1;
            this.name = name1;
        }
    }
}
