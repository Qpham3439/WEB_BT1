using System;
using MathLibrary; // Gọi namespace trong DLL

namespace ConsoleApp_CheckSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen: ");
            if (long.TryParse(Console.ReadLine(), out long n))
            {
                bool result = NumberChecks.IsPerfectSquare(n);
                if (result)
                    Console.WriteLine($"{n} la so chinh phuong.");
                else
                    Console.WriteLine($"{n} khong phai la so chinh phuong.");
            }
            else
            {
                Console.WriteLine("Gia tri nhap khong hop le!");
            }

            Console.WriteLine("Nhan phim bat ky đe thoat...");
            Console.ReadKey();
        }
    }
}
