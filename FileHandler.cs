using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EntellectUniCup
{
    class FileHandler
    {

        // need a function that can read a file 
        // list was chosen as return type for flexibility, and linq
        // returns null if something went wrong
        protected List<string>  GetText(string FileName)
        {
          
            // a list to hold the lines of the text file 
            List<string> lines = new List<string>();
            if (File.Exists(FileName))
            {
                // gets all the lines to an array
                string[] line = GetlinesArray(FileName);
                // add them all to the list
                foreach (string line1 in line)
                {
                    lines.Add(line1);
                }
            }
            else
            {
                // use a null check to check for a problem with file reading
                return null;
            }
            return lines;
        }

        // incase you prefer working with an array
        // returns null if something went wrong
        public string[] GetlinesArray(string FileName)
        {

            string[] line = null;
            if (File.Exists(FileName))
            {
                // a array to hold the lines of the text file 
                // gets all the lines to an array
                line = File.ReadAllLines(FileName);
       
               
            }
            else
            {
                // use a null check to check for a problem with file reading
                return null;
            }
            return line;
        }

        

       
        
      
    }
}
