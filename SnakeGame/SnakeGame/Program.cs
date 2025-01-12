using System;
using System.Collections.Generic;
using System.Threading;

class SnakeGame
{
    static int width = 40;    // Chiều rộng của lồng
    static int height = 20;   // Chiều cao của lồng
    static int score = 0;     // Điểm số
    static bool gameOver = false;

    static List<(int x, int y)> snake = new List<(int x, int y)>(); // Rắn
    static (int x, int y) food = (0, 0); // Vị trí thức ăn
    static (int x, int y) direction = (0, 1); // Hướng ban đầu: sang phải
    static (int x, int y) nextDirection = (0, 1); // Hướng tiếp theo, tránh đổi hướng ngược

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.CursorVisible = false;

        // Khởi tạo rắn và thức ăn
        snake.Add((height / 2, width / 2)); // Vị trí ban đầu của rắn
        GenerateFood();

        // Vẽ khung ban đầu
        DrawBorder();

        Thread inputThread = new Thread(ReadInput);
        inputThread.Start();

        // Vòng lặp game
        while (!gameOver)
        {
            Draw();
            Logic();
            Thread.Sleep(100); // Tốc độ game (100ms mỗi khung hình)
        }

        // Kết thúc game
        Console.SetCursorPosition(0, height + 2);
        Console.WriteLine("=== Game Over ===");
        Console.WriteLine($"Điểm số của bạn: {score}");
    }

    static void DrawBorder()
    {
        // Vẽ viền trên và dưới
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(new string('#', width + 2));

        Console.SetCursorPosition(0, height + 1);
        Console.WriteLine(new string('#', width + 2));

        // Vẽ viền hai bên
        for (int i = 1; i <= height; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("#");
            Console.SetCursorPosition(width + 1, i);
            Console.Write("#");
        }
    }

    static void Draw()
    {
        Console.Clear();

        // Vẽ khung lồng
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    Console.Write("#");
                }
                else if (snake.Contains((i, j)))
                {
                    Console.Write("O"); // Thân rắn
                }
                else if (food == (i, j))
                {
                    Console.Write("*"); // Thức ăn
                }
                else
                {
                    Console.Write(" "); // Vị trí trống
                }
            }
            Console.WriteLine();
        }

        // Hiển thị điểm
        Console.WriteLine($"Điểm số: {score}");
    }

    static void Logic()
    {
        // Cập nhật hướng di chuyển
        direction = nextDirection;

        // Tính toán vị trí mới của đầu rắn
        (int x, int y) newHead = (snake[0].x + direction.x, snake[0].y + direction.y);

        // Kiểm tra va chạm (tường hoặc chính rắn)
        if (newHead.x < 0 || newHead.x >= height || newHead.y < 0 || newHead.y >= width || snake.Contains(newHead))
        {
            gameOver = true;
            return;
        }

        // Thêm đầu mới vào danh sách rắn
        snake.Insert(0, newHead);

        // Kiểm tra nếu rắn ăn thức ăn
        if (newHead == food)
        {
            score++; // Tăng điểm
            GenerateFood(); // Tạo thức ăn mới
        }
        else
        {
            // Nếu không ăn, xóa phần đuôi
            snake.RemoveAt(snake.Count - 1);
        }
    }

    static void GenerateFood()
    {
        Random rand = new Random();
        do
        {
            food = (rand.Next(0, height), rand.Next(0, width));
        } while (snake.Contains(food)); // Đảm bảo thức ăn không xuất hiện trên rắn
    }

    static void ReadInput()
    {
        while (!gameOver)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            // Thay đổi hướng di chuyển (không được ngược chiều)
            switch (key)
            {
                case ConsoleKey.W:
                    if (direction != (1, 0)) nextDirection = (-1, 0); // Lên
                    break;
                case ConsoleKey.S:
                    if (direction != (-1, 0)) nextDirection = (1, 0); // Xuống
                    break;
                case ConsoleKey.A:
                    if (direction != (0, 1)) nextDirection = (0, -1); // Trái
                    break;
                case ConsoleKey.D:
                    if (direction != (0, -1)) nextDirection = (0, 1); // Phải
                    break;
            }
        }
    }
}
