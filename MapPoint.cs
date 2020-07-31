using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntellectUniCup
{
    class MapPoint
    {
        public double x;
        public double y;
        public bool visited = false;


        public MapPoint (double X, double Y)
        {
            x = X;
            y = Y;
        }
        public MapPoint()
        {
            x = 0;
            y = 0;
        }
        public string toString()
        {// default response 
            string answer = "";
            answer += " (X : " + Convert.ToString(x) + " ; ";
            answer += " Y : " + Convert.ToString(y) + " ; ";
       
            return answer;

        }
    }
}
