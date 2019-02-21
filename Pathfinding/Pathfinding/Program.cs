using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Path t = new Path();
            Console.WriteLine("How many rows you want: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cols you want: ");
            int col = Convert.ToInt32(Console.ReadLine());
            string[,] arr = new string[row, col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.WriteLine("Is the row: " + i + " and col: " + j + " x or -? (Type \"x\" or \"-\" or error)");
                    arr[i, j] = Console.ReadLine();
                }
            }
            List<string> ans = t.FindPath(arr);
            for(int i=0;i<ans.Count;i++)
            {
                Console.WriteLine(ans.ElementAt(i) + '\n');
            }
            Console.WriteLine("Press Enter to close the program. . .");
            Console.ReadLine();
        }
    }
}
