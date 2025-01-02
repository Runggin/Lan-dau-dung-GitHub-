using System;

public static class Utils
{
    public static double NhapSo()
    {
        while (true)
        {
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Dữ liệu không hợp lệ, vui lòng nhập số: ");
            }
        }
    }

    public static int NhapLuaChon()
    {
        while (true)
        {
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 4)
                    return choice;

                Console.Write("Lựa chọn không hợp lệ, vui lòng chọn từ 1 đến 4: ");
            }
            catch
            {
                Console.Write("Dữ liệu không hợp lệ, vui lòng nhập số: ");
            }
        }
    }
}
