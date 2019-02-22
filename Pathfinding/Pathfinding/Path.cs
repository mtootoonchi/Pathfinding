using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding
{
    class Path
    {
        public List<string> FindPath(string[,] arr)
        {
            for (int j = 0; j <= arr.GetLength(1); j++)  //checks each start col for possible path start locations
            {
                List<string> path = new List<string>();
                if (j == arr.GetLength(1))  //finds no complete path to end therefore path is deleted and emtry path returned.
                {
                    path = new List<string>();
                    path.Add("");
                    return path;
                }
                if(arr[0, j].Equals("-"))  //possible start index path found : testing
                {
                    path.Add("0" + j);
                    for (int i=1;i<= arr.GetLength(0);i++)  //runs through each row excluding first one for possible path
                    {
                        if(arr.GetLength(0) == i)  //complete path discovered returning list path
                        {
                            return path;
                        }
                        for(int h=j-1;h<=j+1;h++)  //checks possible path directions
                        {
                            if(h<0||h>= arr.GetLength(1))  //checks arr out of bounds error
                            {

                            }
                            else if(arr[i, h].Equals("-"))  //path found, writing in list path
                            {
                                path.Add("" + i + h);
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
