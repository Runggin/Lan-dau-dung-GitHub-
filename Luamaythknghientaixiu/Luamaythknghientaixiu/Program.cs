using System;
using System.Text;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random random = new Random();

        Console.WriteLine("=== Game Tài Xỉu ===");
        Console.WriteLine("Luật chơi:");
        Console.WriteLine("- Tài: Tổng xúc xắc từ 11 đến 17");
        Console.WriteLine("- Xỉu: Tổng xúc xắc từ 3 đến 10");
        Console.WriteLine("- Nhập 'exit' để thoát game.\n");

        while (true)
        {
            Console.Write("Đặt cược (Tài/Xỉu): ");
            string luaChon = Console.ReadLine()?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(luaChon))
            {
                Console.WriteLine("Vui lòng nhập giá trị hợp lệ!");
                continue;
            }

            // Chuẩn hóa chuỗi nhập (không dấu và chữ thường)
            luaChon = ChuyenKhongDau(luaChon).ToLowerInvariant();

            if (luaChon == "exit")
            {
                Console.WriteLine("Cảm ơn bạn đã chơi! Hẹn gặp lại.");
                break;
            }

            // Kiểm tra lựa chọn hợp lệ, chấp nhận các biến thể của "Tài" và "Xỉu"
            if (luaChon == "tai" || luaChon == "xiu")
            {
                int xucXac1 = random.Next(1, 7); // 1 đến 6
                int xucXac2 = random.Next(1, 7);
                int xucXac3 = random.Next(1, 7);

                int tong = xucXac1 + xucXac2 + xucXac3;
                string ketQua = (tong >= 11 && tong <= 17) ? "tai" : "xiu";

                // Hiển thị kết quả
                Console.WriteLine($"Xúc xắc: {xucXac1}, {xucXac2}, {xucXac3}");
                Console.WriteLine($"Tổng: {tong} => {ketQua.ToUpper()}");

                // So sánh kết quả
                if (luaChon == ketQua)
                {
                    Console.WriteLine("Bạn đã thắng!");
                }
                else
                {
                    Console.WriteLine("Bạn đã thua, thử lại nhé!");
                }

                Console.WriteLine(); // Dòng trống để phân cách lần chơi
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 'Tài' hoặc 'Xỉu'.");
            }
        }
    }

    /// <summary>
    /// Hàm chuyển chuỗi Unicode về dạng không dấu.
    /// </summary>
    /// <param name="input">Chuỗi cần chuyển đổi</param>
    /// <returns>Chuỗi không dấu</returns>
    static string ChuyenKhongDau(string input)
    {
        var normalizedString = input.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }
}
