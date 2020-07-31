using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntellectUniCup
{
    class WorldHandler
    {
        // publically accesible  variables that will make a world instance
        public string[] FileLines;
        public string FileName;
        public List<MapPoint> MapPoints;
        public List<Crate> Crates;
        public List<cratebase> Bases;
        public double MapHeight;
        public double MapWidth;
        public double worms;
        public double NumCrates;
        public double NumBases;

        // a construtor to build the world 
        // to look for errors look for negatives or null lists
        public WorldHandler(string FileName1)
        {
            // initialize everyithing just for good measure 
            FileName = FileName1;
            MapPoints = new List<MapPoint>();
            Crates = new List<Crate>();
            Bases = new List<cratebase>();
            MapHeight = 0;
            MapWidth = 0;
            worms = 0;
            NumCrates = 0;
            NumBases = 0;
            FileLines = null;

            // lets properly build the world 
            FileHandler myFilehandler = new FileHandler();
            // lets get the lines
            FileLines = myFilehandler.GetlinesArray(FileName);
            // lets get num worms
            worms = GetNumWorms();
            // lets get crates 
            NumCrates = GetNumCrates();
            // lets get numbases 
            NumBases = GetNumBases();
            //lets get width 
            MapWidth = GetMapWidth();
            // lets get map height 
            MapHeight = GetMapHeight();

            // lets get map points :
            MapPoints = GetMapPoints();
            // lets get crates 
            Crates = GetCrates(MapPoints);
            // lets get bases 
            Bases = GetBases(MapPoints);

        }

        // make a function returns a value from from a line of text
        //-2 means general error in function
        //-1 means line length or splitter is incorrectly specified 
        // -3 means conversion error
        protected double GetValueFromPosition(string line, char splitter, int position)
        {
            double answer = -2;
            // do safety checks
            if ((line is null) || (line.Length == 0) || (splitter.ToString() is null))
            {
                // invalid call
                return -1;
            }
            else
            {
                // make a copy so the world doesnt get damaged
                string TempLine = line;
                // split by the splitter 
                string[] words = TempLine.Split(splitter);
                // try catch incase of conversion error
                try
                {
                    // convert the related word to double after trimming white space
                    answer = Convert.ToDouble(words[position].Trim());
                    // answer is done
                }
                catch (Exception ex)
                {
                    // returns -3 for a conversion error
                    answer = -3;
                }

            }
            // returns -2 saying that a problem has occured
            return answer;
        }

        /* get the number of worms (position 0)
         -1 is invalid file lines*/
        public double GetNumWorms()
        {
            double answer = -1;
            if (FileLines is null)
            {
                //return error output here
            }
            else
            {
                answer = GetValueFromPosition(FileLines[0], ',', 0);
            }


            return answer;
        }
        // get the number of crates (position 1)
        //-1 means  invalid file lines
        public double GetNumCrates()
        {
            double answer = -1;
            if (FileLines is null)
            {
                //return error output here
            }
            else
            {
                answer = GetValueFromPosition(FileLines[0], ',', 1);
            }


            return answer;
        }
        // get the number of bases (position 2)
        //-1 means invalid filelines
        public double GetNumBases()
        {
            double answer = -1;
            if (FileLines  is null)
            {
                //return error output here
            }
            else
            {
                answer = GetValueFromPosition(FileLines[0], ',', 2);
            }


            return answer;
        }
        // get the map width (position 3)
        //-1 means  invalid file lines
        public double GetMapWidth()
        {
            double answer = -1;
            if (FileLines is null)
            {
                //return error output here
            }
            else
            {
                answer = GetValueFromPosition(FileLines[0], ',', 3);
            }


            return answer;
        }
        // get the map height (position 4)
        //-1 means invalid file lines
        public double GetMapHeight()
        {
            double answer = -1;
            if (FileLines is null)
            {
                //return error output here
            }
            else
            {
                answer = GetValueFromPosition(FileLines[0], ',', 4);
            }


            return answer;
        }
        // get all significant map points 
        // null indicates incorrect params
        public List<MapPoint> GetMapPoints()
        {
            List<MapPoint> points = new List<MapPoint>();
            // test if parms are any good
            if (FileLines is null)
            {
                // null indicates incorrect params
                points = null;
            }
            else
            {
                string currentLine = "";
                double X1, Y1 = 0;
                // loop through list
                for (int y = 1; y < FileLines.GetLength(0); y++)
                {
                    // get this line without white space
                    currentLine = FileLines[y].Trim();
                    // now search for points
                    Y1 =MapHeight - y;
                    for (int x = 0; x < currentLine.Length; x++)
                    {
                        X1 = x ;
                        // check if its a map point 
                        if (currentLine[x] != '#')
                        {
                            MapPoint p;
                            // check if its a crate or a base 
                            if (char.IsUpper(currentLine[x]))
                            {
                                // if its upper its a Crate
                                Crate c = new Crate(X1, Y1, currentLine[x]);
                                p = c;
                            }
                            else
                            {
                                // its a base
                                cratebase b = new cratebase(X1, Y1, currentLine[x]);
                                p = b;
                            }

                            points.Add(p);
                        }
                    }
                }
            }
            return points;
        }

        // get crates 
        public List<Crate> GetCrates(List<MapPoint> points)
        {
            // make a list to return
            List<Crate> MyCrates = new List<Crate>();
            // for type testing
            Crate c = new Crate(0, 0, 'n');
            foreach (MapPoint p in points)
            {
                // check if point instance type == crate instance type
                if (p.GetType() == c.GetType())
                {
                    // p is a crate 

                    MyCrates.Add((Crate)p);
                }
            }

            return MyCrates;

        }
        // get bases
        public List<cratebase> GetBases(List<MapPoint> points)
        {
            // make a list to return
            List<cratebase> MyCratebases = new List<cratebase>();
            // for type testing
            cratebase c = new cratebase(0, 0, 'n');
            foreach (MapPoint p in points)
            {
                // check if point instance type == cratebase instance type
                if (p.GetType() == c.GetType())
                {
                    // p is a cratebase

                    MyCratebases.Add((cratebase)p);
                }
            }

            return MyCratebases;

        }

        // make a to-string to make it easy

        public string toString()
        {// default response 
            string answer = "";
            answer += "File name : "+FileName  + Environment.NewLine;
            answer += "Number of worms : " + Convert.ToString (worms)  + Environment.NewLine;
            answer += "Number of crates : " + Convert.ToString(NumCrates ) + Environment.NewLine;
            answer += "Number of bases : " + Convert.ToString(NumBases ) + Environment.NewLine;
            answer += "map height : " + Convert.ToString(MapHeight) + Environment.NewLine;
            answer += "Map width  :" + Convert.ToString(MapWidth ) + Environment.NewLine;
            answer += "Crates in list :" + Convert.ToString(Crates.Count()) + Environment.NewLine;
            answer += "CrateBases in List :" + Convert.ToString(Bases.Count()) + Environment.NewLine;

            foreach(Crate c in Crates )
            {
                answer += c.toString() + Environment.NewLine;
            }

            return answer;

        }
      
    }
}
