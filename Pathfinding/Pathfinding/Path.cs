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
            for (int j = 0; j <= arr.GetLength(1); j++)
            {
                List<string> path = new List<string>();
                if (j == arr.GetLength(1))
                {
                    path.Add("");
                    return path;
                }
                if(arr[0, j].Equals("-"))
                {
                    path.Add("0" + j);
                    for (int i=1;i<= arr.GetLength(0);i++)
                    {
                        if(arr.GetLength(0) == i)
                        {
                            return path;
                        }
                        for(int h=j-1;h<=j+1;h++)
                        {
                            if(h<0||h>= arr.GetLength(1))
                            {

                            }
                            else if(arr[i, h].Equals("-"))
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
