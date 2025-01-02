using System;
using System.Text;
class Program
{
    static void Main()
    {
        {
            bool running = true;
            while (running)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("=== Máy Tính ===");
                Console.Write("Nhập số thứ nhất: ");
                double a = Utils.NhapSo();
                Console.Write("Nhập số thứ hai: ");
                double b = Utils.NhapSo();

                Console.WriteLine("Chọn phép tính:");
                Console.WriteLine("1: Cộng | 2: Trừ | 3: Nhân | 4: Chia");
                int choice = Utils.NhapLuaChon();

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Calculator.Cong(a, b);
                        break;
                    case 2:
                        result = Calculator.Tru(a, b);
                        break;
                    case 3:
                        result = Calculator.Nhan(a, b);
                        break;
                    case 4:
                        result = Calculator.Chia(a, b);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        return;
                }

                Console.WriteLine($"Kết quả: {result}");
            }
        }
    }

}
