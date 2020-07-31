using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntellectUniCup
{
    class TesterClass
    {

        // get filename 
        // read file 
        // process line by line 
        // get score 
        // variables 
        public string[] FileLines = null;
        public string TestFileName, WorldFileName1;
        public WorldHandler MyWorld;
        public double TotalScore;

        //constructor
        public TesterClass( string FileName1,string WorldFileName1)
        {
            // store the file name 
            TestFileName = FileName1;
            // make  a file handler 
            FileHandler myHandler = new FileHandler();
            // get the file lines
            FileLines = myHandler.GetlinesArray(TestFileName);
           
            if(FileLines is null)
            {
                // file was not read succesfully 
                return;
            }
            else
            {
                MyWorld = new WorldHandler(WorldFileName1);
                // lets make a list of points to add to score 
                List<MapPoint> pointsVisited = new List<MapPoint>();
                double score = 0;
                foreach (string line in FileLines)
                {
                    pointsVisited = ListOfVisitedPoints(line);
                    score += ScoreMyWorm(pointsVisited);
                }
                TotalScore = score;
            }
        }
        // from the list of points get a score 
        public double ScoreMyWorm(List<MapPoint> visited)
        {// default error test answer
            double answer = 0;
            // loop from 0 to second last
            for(int x =0; x< visited.Count-1; x++ )
            {
                // score them in pairs , from a to b , then b to c 
                answer += Utilities.GetManhattanDistance(visited[x], visited[x + 1]);
            }
            return answer;
        }

        // gets a list of points visited by one worm including the start point
        public List<MapPoint> ListOfVisitedPoints( string line)
        {
            // default answer
            List<MapPoint> ThisWormsVisitedPoints = new List<MapPoint>();
            // make a temp 
            MapPoint temp = new MapPoint(0, 0);
            // added zero where all worms start 
            ThisWormsVisitedPoints.Add(Utilities.zero0);
            // split on commas
            string[] letter = line.Split(',');
            //for each letter
            foreach (string s in letter)
            {
                // get the map point
                temp = GetPointFromLetter(s);
                // add the map point
                ThisWormsVisitedPoints.Add(temp);
            }
            return ThisWormsVisitedPoints;
        }

        // gets a map point from a letter 
        public MapPoint GetPointFromLetter(string letter)
        {
            // convert  string to char
            char Name = letter[0];
            // default return
            MapPoint answer = null;
            // for type testing
            Crate C1 = new Crate(0, 0, 'n');
            cratebase CB = new cratebase(0, 0, 'n');
            foreach(MapPoint p in MyWorld.MapPoints)
            {
                if(p.GetType() == C1.GetType())
                {
                    // its a crate
                    if (C1.Name == Name)
                    {
                        // found x its a base
                        answer = p;
                    }
                }
                if (p.GetType ()== CB.GetType ())
                {
                    // its a crate base

                    if (CB.name == Name)
                    {
                        // found x its a base
                        answer = p;
                    }
                }
            }


            return answer;
        }

    }
}
