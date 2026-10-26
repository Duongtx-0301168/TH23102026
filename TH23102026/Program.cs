using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TH23102026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i.ToString() + "] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n Dãy số vừa nhập là:  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            // Nhập vào ma trận A[m x n]
            Console.Write("\n\nNhập số dòng m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int soCot = Convert.ToInt32(Console.ReadLine());

            int[,] MaTran = new int[m, soCot];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write("A[" + i.ToString() + "," + j.ToString() + "] = ");
                    MaTran[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Ma trận vừa nhập là:  ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(MaTran[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Nhập vào ma trận vuông A[n x n]
            Console.Write("\nNhập cấp ma trận vuông k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[,] MaTranVuong = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("A[" + i.ToString() + "," + j.ToString() + "] = ");
                    MaTranVuong[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Ma trận vuông vừa nhập là:  ");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(MaTranVuong[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Tính tổng các phần tử nằm trên đường chéo chính (j > i)
            int tong = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    tong += MaTranVuong[i, j];
                }
            }
            Console.WriteLine("\n Tổng các phần tử nằm trên đường chéo chính: " + tong);

            // Tính tích các phần tử nằm dưới đường chéo chính (i > j) và lớn hơn 0
            long tich = 1;
            bool coPhanTu = false;
            for (int i = 1; i < k; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (MaTranVuong[i, j] > 0)
                    {
                        tich *= MaTranVuong[i, j];
                        coPhanTu = true;
                    }
                }
            }
            if (coPhanTu)
                Console.WriteLine(" Tích các phần tử dưới đường chéo chính và lớn hơn 0: " + tich);
            else
                Console.WriteLine(" Không có phần tử nào dưới đường chéo chính lớn hơn 0");
        }
    }
}
