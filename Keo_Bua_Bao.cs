using System;
using System.Text;
class KeoBuaBao
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("=== Kéo Búa Bao ===");
        Console.WriteLine("0: Kéo, 1: Búa, 2: Bao. Nhập -1 để thoát.");
        Random rd = new Random();
        while (true)
        {
            Console.Write("Nhập lựa chọn: ");
            int nguoi, may;
            try
            {
                nguoi = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nhập số đi bạn ơi!");
                continue;
            }

            if (nguoi == -1)
            {
                Console.WriteLine("Bye bạn nhé!");
                break;
            }
            if (nguoi < 0 || nguoi > 2)
            {
                Console.WriteLine("Số không hợp lệ, nhập lại đi!");
                continue;
            }

            may = rd.Next(0, 3); // Máy chọn random
            Console.WriteLine($"Bạn chọn: {HienThi(nguoi)}, Máy chọn: {HienThi(may)}");

            if (nguoi == may)
                Console.WriteLine("Hòa nhé!");
            else if ((nguoi == 0 && may == 2) || (nguoi == 1 && may == 0) || (nguoi == 2 && may == 1))
                Console.WriteLine("Bạn thắng!!!");
            else
                Console.WriteLine("Máy thắng, chúc may mắn lần sau!");

            Console.WriteLine();
        }
    }

    static string HienThi(int choice)
    {
        if (choice == 0) return "Kéo";
        if (choice == 1) return "Búa";
        return "Bao";
    }
}
