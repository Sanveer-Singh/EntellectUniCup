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
        public bool HitCapacity = false;
        // constructor for making bases 
        public cratebase (double x1, double y1 , char  name1 )
        {
            this.x = x1;
            this.y = y1;
            this.name = name1;
        }
        public string toString()
        {// default response 
            string answer = "";
            answer += " (X : " + Convert.ToString(x) + " ; ";
            answer += " Y : " + Convert.ToString(y) + " ; ";
            answer += "Name : " + Convert.ToString(name) + " )";
            return answer;

        }
    }
}
