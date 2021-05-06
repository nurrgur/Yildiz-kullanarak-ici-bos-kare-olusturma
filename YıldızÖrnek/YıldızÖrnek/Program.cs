using System;

namespace YıldızOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oluşturmak istediğiniz karenin kenar uzunluğunu giriniz..");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= k; i++) 
            {

                if (i==1 || i == k)
                {
                    for(int x = 1; x <= k; x++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int y = 1; y <= k; y++)
                    {
                        if (y == 1 || y == k)
                        {
                            Console.Write("* ");
                            if (y == k) Console.WriteLine();
                        }
                        else Console.Write("  ");
                    }
                }
            }
            Console.Read();
        }
    }
}


