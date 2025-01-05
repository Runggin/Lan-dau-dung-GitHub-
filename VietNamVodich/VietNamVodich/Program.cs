using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Ký tự LED cho chữ "Việt Nam vô địch"
        string[] led = new string[]
        {
            "##            ##   ##    ########   #########    ####        ##        ###        ####     ####   ##           ##     ######     ####     ##     ####   ##     ##",
            " ##          ##    ##    ##             #        ##  ##      ##       ## ##       ## ##   ## ##    ##         ##    ##      ##   ##  ##   ##   ##       ##     ##",
            "  ##        ##     ##    ##             #        ##   ##     ##      ##   ##      ##  ## ##  ##     ##       ##     ##      ##   ##   ##  ##  ##        ##     ##",
            "   ##      ##      ##    ########       #        ##     ##   ##     ##     ##     ##   ###   ##      ##     ##      ##      ##   ##   ##  ##  ##        #########",
            "    ##    ##       ##    ##             #        ##      ##  ##    ###########    ##         ##       ##   ##       ##      ##   ##   ##  ##  ##        ##     ##",
            "     ##  ##        ##    ##             #        ##        ####   ##         ##   ##         ##        ## ##        ##      ##   ##  ##   ##   ##       ##     ##",
            "      ###          ##    ########       #        ##          ##  ##           ##  ##         ##         ###           ######     ####     ##     ####   ##     ##"
        };
        int consoleWidth = 120; // Chiều rộng của console
        int ledWidth = led[0].Length; // Chiều rộng của toàn bộ chữ LED
        int scrollWidth = consoleWidth + ledWidth;

        // Hiệu ứng chạy ngang từ trái sang phải
        for (int offset = -consoleWidth; offset < ledWidth; offset++)
        {
            Console.Clear();
            for (int i = 0; i < led.Length; i++)
            {
                string row = led[i];

                // Tính toán phần hiển thị
                int start = Math.Max(0, offset);
                int end = Math.Min(ledWidth, consoleWidth + offset);

                if (start < end)
                {
                    Console.WriteLine(new string(' ', Math.Max(0, offset < 0 ? -offset : 0)) +
                                      row.Substring(start, end - start));
                }
                else
                {
                    Console.WriteLine(); // Dòng trống
                }
            }

            // Tốc độ chạy
            Thread.Sleep(10); // 10ms mỗi khung
        }
        Console.WriteLine("\nViệt Nam vô địch! Thái Lọ tuổi L*n!");
    }
}
