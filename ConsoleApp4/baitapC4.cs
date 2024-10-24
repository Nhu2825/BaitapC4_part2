using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class baitapC4
    {
        public static void Main()
        {
            bai2_7();
            Console.ReadKey();
        }
        /// <summary>
        /// kiểm tra tam giác đều, cân hay thường
        /// </summary>
        static void bai2_1()
        {

            Console.WriteLine("nhap so do 3 canh ");
            var a = Console.Read();
            var b = Console.Read();
            var c = Console.Read();
            if (a + b > c)
            {
                if (a == b && b == c)
                { Console.WriteLine("Day la tam giac deu"); }
                else if (a == c || b == c)
                {
                    Console.WriteLine("Day la tam giac can");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong");
                }
            }


        }
        static void bai1_1()
        {
            Console.Write("nhap so nguyen : "); int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            { Console.WriteLine("Day la so chan"); }

            Console.WriteLine("Day la so le");
        }
        /// <summary>
        /// Nhập 3 số và cho biết số lớn nhất
        /// </summary>
        static void bai1_2()
        {
            Console.Write("nhap so thu nhat: "); float a = float.Parse(Console.ReadLine());
            Console.Write("nhap so thu hai: "); float b = float.Parse(Console.ReadLine());
            Console.Write("nhao so thu ba: "); float c = float.Parse(Console.ReadLine());
            float max = a;
            if (max <= b)
            {
                max = b;
            }
            if (max <= c)
            {
                max = c;
            }
            Console.WriteLine($"so lon nhat trong 3 so la {max}");
        }
        /// <summary>
        /// xác định một điểm thuộc góc phần tư thứ mấy trong hệ trục tọa độ
        /// </summary>
        static void bai1_3()
        {
            Console.Write("nhap tung do y = "); int y = int.Parse(Console.ReadLine());
            Console.Write("nhap hoanh do x = "); int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Diem thuoc goc phan tu thu nhat");
                }
                else if (y < 0)
                {
                    Console.WriteLine("Diem thuoc goc phan thu thu 4");
                }
                else
                {
                    Console.WriteLine("Diem nam tren truc hoanh");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Diem thuoc goc phan tu thu hai");
                }
                else if (y < 0)
                {
                    Console.WriteLine("Diem thuoc goc phan tu thu ba");
                }
                else
                {
                    Console.WriteLine("Diem nam tren truc hoanh");
                }
            }
            if (x == 0 && y == 0)
            { Console.WriteLine("Day la goc toa do"); }

        }
        /// <summary>
        /// nhập 10 số rồi tính tổng và trung bình
        /// </summary>
        static void bai2_2()
        {
            List<float> so = new List<float>();


            Console.Write("nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            float sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap so thu {i + 1}: ");
                float number = float.Parse(Console.ReadLine());
                so.Add(number);
                sum += number;
            }
            Console.WriteLine("Tổng các phần tử trong danh sách là: " + sum);
            Console.WriteLine("Trung binh cong cua day tren la " + sum / n);
        }
        /// <summary>
        /// chương trình in ra bản cửu chương theo yêu cầu
        /// </summary>
        static void bai2_3()
        {
            Console.Write("Ban muon biet ban cua chuong may? ___ "); int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} x 1 = {a * 1} \n" +
                $"{a} x 2 = {a * 2}\n" +
                $"{a} x 3 = {a * 3}\n" +
                $"{a} x 4 = {a * 4} \n" +
                $"{a} x 5 = {a * 5} \n" +
                $"{a} x 6 = {a * 6}  \n" +
                $"{a} x 7 = {a * 7}  \n" +
                $"{a} x 8 = {a * 8}  \n" +
                $"{a} x 9 = {a * 9}  \n" +
                $"{a} x 10 = {a * 10}");
        }
        for (int i = 1 ; i<=10 ; i++)
{ Console.WriteLine($"{a} * {i} = {a*i}"); }
        /// <summary>
        /// viết chương trình in ra tam giác bằng số
        /// </summary>
        static void bai2_4()
        {
            Console.WriteLine(@"
1
12
123
1234
|
|
1
2 3
4 5 6
7 8 9 10
||||||||
   1
  2 3
 4 5 6
7 8 9 10");
        }
        /// <summary>
        /// in ra dãy 1+1/2+1/3+...+1/n và tổng
        /// </summary>
        static void bai2_5()
        {
            Console.Write("Nhap n __"); int n = int.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum += (float)1 / n;
            }

            Console.WriteLine($"1+1/2+...+ 1/{n} = {sum}");

        }
        /// <summary>
        /// in ra số hoàn hảo
        /// </summary>
        static void bai2_6()
        {
            Console.Write("Nhap so bat dau: __"); int start = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ket thuc: __"); int end = int.Parse(Console.ReadLine());
            Console.Write("Cac so hoan hao la: ");
            for (int i = start; i < end; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                    if (sum == i)
                    {
                        Console.Write($"{i} ");
                    }
                
            }
        }
        /// <summary>
        /// kiểm tra số nguyên tố
        /// </summary>
        static void bai2_7()
        {
            Console.Write("Nhap so nguyen bat ky: __"); int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i< n-1; i++)
            {
                if ((n%i) == 0)
                {
                    count++;
                }    
            }
            if (count == 0)
            {
                Console.WriteLine("day la so nguyen to!");
            }
            else
            {
                Console.WriteLine("Day khong phai so nguyen to!");
            }    
                                            
        }
    }
}
