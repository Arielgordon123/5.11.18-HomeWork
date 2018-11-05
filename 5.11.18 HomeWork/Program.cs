using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._11._18_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] arr = new string[3][];
            int center;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[3];
                center = (int)(arr[i].Length / 2);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i == j && i != center)//main diagonal
                        arr[i][j] = "main";

                    else if (i != center && (i + j == arr.Length - 1))//sub diagonal
                        arr[i][j] = "sub";

                    else if (i > j)//bottom
                        arr[i][j] = "bottom";

                    else if (j > i)//up
                        arr[i][j] = "up";

                    else
                        arr[i][j] = "center";
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write($"{arr[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
