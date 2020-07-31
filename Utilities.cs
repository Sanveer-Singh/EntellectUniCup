using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntellectUniCup
{
    class Utilities
    {
        // zero point 

       public static MapPoint zero0 = new MapPoint(0, 0);
        // distance calculator using manhattan
        // -1 means wrong params
        // assumes A to B
        public static double GetManhattanDistance(MapPoint A,MapPoint B)
        {
            double answer = -2;
            // safety check
            if((A is null)||(B is null)||(A.x <0)||(A.y<0) || (B.x < 0) || (B.y < 0))
            {
                answer = -1;
            } else
            {
                // manhaten math
                answer = Math.Abs(B.x - A.x) + Math.Abs(B.y - A.y);
            }
            return answer;
        }

        // A number of alternatives that will handle casting for you 
        public static double GetManhattanDistance(Crate A,cratebase B)
        {
            return GetManhattanDistance(A, B);
        }
        public static double GetManhattanDistance(cratebase A, Crate B)
        {
            return GetManhattanDistance(A, B);
        }
        public static double GetManhattanDistance(Crate A, Crate B)
        {
            return GetManhattanDistance(A, B);
        }
        public static double GetManhattanDistance(cratebase A, cratebase B)
        {
            return GetManhattanDistance(A, B);
        }
    }
}
