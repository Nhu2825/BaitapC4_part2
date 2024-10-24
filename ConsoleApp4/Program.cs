namespace ConsoleApp4
{
    internal class buoi4
    {
        public static void Main(string[] args)
        {
            ex02();
            Console.ReadKey();
        }
        /// <summary>
        /// giai va bien luan phuong tring bac 1 <br/>
        /// hmmm
        /// </summary>
        /// <param name="args"></param>
        static void ex01()
        {
            Console.WriteLine("nhap a"); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b"); int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("vo so nghiem");
                else
                    Console.WriteLine("vo nghiem");
            else
                Console.WriteLine("x = " + (-b / (float)a));
        }
        /// <summary>
        /// game doan so <br/>
        /// doan giong may thi thang
        /// </summary>
        static void ex02()
        {
            do
            {
                Random rnd = new Random();
                int com_num = rnd.Next(0, 10) + 1;
                int count = 0;
                bool tiep = true;
                do
                {
                    count++;
                    Console.WriteLine("ban doan so may? tu 1 den 10");
                    int ur_num = int.Parse(Console.ReadLine());
                    if (ur_num == com_num)
                    {
                        Console.WriteLine($"ban doan dung sau {count} lan");
                        tiep = false;
                    }
                    else
                    {
                        if (ur_num >= com_num)
                        {
                            Console.WriteLine("ban doan lon hon may. Doan lai di!");
                        }
                        else
                        {
                            Console.WriteLine("ban doan nho hon may. Doan lai di!");
                        }
                    }
                } while (tiep);
                Console.WriteLine("===============================================================");
                Console.WriteLine("Tiep khong? ok/ko");
                string rep = Console.ReadLine();
                if (rep.ToLower().Equals("ko"))
                {
                    Console.WriteLine("ok nghi");
                    return;
                }


            } while (true);
        }
    }
}
