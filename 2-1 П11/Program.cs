using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_П11
{
    class Program
    {
        /// <summary>
        /// y = kx+b
        /// 0 = kx + b
        /// x = -b/k
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int LineFunc(int k, int b)
        {
            string message;
            int result = LineFunc(k, b, out message);
            if (message != string.Empty)
                throw new Exception(message);
            return result;
        }

        public static int LineFunc(int k, int b, out string message)
        {
            if (k == 0)
            {
                if (b == 0)
                    message = "Прямая совпадает с осью Ох.";
                else
                    message = "Нет точек пересечния с осью Ох.";
                return 0;
            }
            message = "";
            return -b / k;
        }
        static void inc(ref int x, out int z)
        {
            x++;
            z = x * x;
        }
        struct Point
        {
            public int x;
            public int y;
        }

        static double Pifagor(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        static Point vector(Point p, int v)
        {
            p.x = p.x * v;
            p.y = p.y * v;
            return p;
        }
        static void Main(string[] args)
        {
            try
            {
                int[] vs = new int[10];
                int[] vs1 = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 };
                int[,] vs2 = new int[,] {
                    {2,3,4},
                    {3,4,5},
                    {4,5,6}
                };
                int[][] vs3 = new int[3][];
                vs3[0] = new int[] { 1, 2, 3 };
                vs3[1] = new int[] { 1, 2 };
                vs3[2] = new int[] { 1 };

                for (int i = 0; i < vs.Length; i++)
                    Console.Write($"{i}-{vs[i]} ");
                Console.WriteLine();

                Console.WriteLine(string.Join(" ", vs));

                foreach (var item in vs1)
                    Console.Write($"{item} ");
                Console.WriteLine();

                for (int i = 0; i < vs2.GetLength(0); i++)
                {
                    for (int j = 0; j < vs2.GetLength(1); j++)
                        Console.Write($"{vs2[i,j]} ");
                    Console.WriteLine();
                }

                for (int i = 0; i < vs3.Length; i++)
                {
                    int[] row = vs3[i];
                    for (int j = 0; j < row.Length; j++)
                        Console.Write($"{row[j]} ");
                    Console.WriteLine();
                }

                for (int i = 0; i < vs3.Length; i++)
                {
                    for (int j = 0; j < vs3[i].Length; j++)
                        Console.Write($"{vs3[i][j]} ");
                    Console.WriteLine();
                }

                Array.Sort(vs1);
                foreach (var item in vs1)
                    Console.Write($"{item} ");
                Console.WriteLine();

                Array.Reverse(vs1);
                foreach (var item in vs1)
                    Console.Write($"{item} ");
                Console.WriteLine();

                Console.WriteLine(vs1.Max());

                vs1[7] = 100;
                Console.WriteLine(vs1.Max());

                Point A = new Point()
                {
                    x = 10,
                    y = 20
                };
                A = vector(A, 2);
                Console.WriteLine($"{A.x} {A.y}");
                Point B = new Point();
                B.x = 100;
                B.y = 200;
                Console.WriteLine(Pifagor(A,B));
                int y;
                Console.WriteLine(int.TryParse(Console.ReadLine(), out y));
                Console.WriteLine(y);
                int w;
                inc(ref y, out w);
                Console.WriteLine(y);
                Console.WriteLine(w);
                string message;
                Console.WriteLine($"{LineFunc(0, 0, out message)} {message}");
                Console.WriteLine($"{LineFunc(0, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            
            Console.ReadLine();
        }
    }
}
