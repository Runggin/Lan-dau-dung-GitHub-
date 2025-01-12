using System;
using System.Collections.Generic;
using System.Threading;

class SnakeGame
{
    static int width = 40;    // Chiều rộng của lồng
    static int height = 20;   // Chiều cao của lồng
    static int score = 0;     // Điểm số
    static bool gameOver = false;
    static bool playAgain = true;

    static List<(int x, int y)> snake;
    static (int x, int y) food;
    static (int x, int y) direction;
    static (int x, int y) nextDirection;

    static void Main()
    {
        while (playAgain)
        {
            InitializeGame();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            ShowWelcomeScreen();

            // Vẽ khung ban đầu
            DrawBorder();

            Thread inputThread = new Thread(ReadInput);
            inputThread.Start();

            int gameSpeed = 100; // Tốc độ game (100ms mỗi khung hình)

            // Vòng lặp game
            while (!gameOver)
            {
                Draw();
                Logic();
                Thread.Sleep(gameSpeed);

                // Tăng tốc độ game dựa trên điểm số
                if (score % 5 == 0 && gameSpeed > 30)
                {
                    gameSpeed -= 1;
                }
            }

            // Kết thúc game
            Console.SetCursorPosition(0, height + 2);
            Console.WriteLine("=== Game Over ===");
            Console.WriteLine($"Điểm số của bạn: {score}");

            // Hỏi người chơi có muốn chơi lại không
            Console.WriteLine("Bạn có muốn chơi lại không? (Y/N)");
            char response = Console.ReadKey().KeyChar;
            if (response != 'Y' && response != 'y')
            {
                playAgain = false;
            }
        }
    }

    static void InitializeGame()
    {
        snake = new List<(int x, int y)>();
        food = (0, 0);
        direction = (0, 1);
        nextDirection = (0, 1);
        gameOver = false;
        score = 0;

        // Khởi tạo rắn và thức ăn
        snake.Add((height / 2, width / 2)); // Vị trí ban đầu của rắn
        GenerateFood();
    }

    static void ShowWelcomeScreen()
    {
        Console.Clear();
        Console.WriteLine("=== Snake Game ===");
        Console.WriteLine("Điều khiển rắn bằng các phím W (lên), S (xuống), A (trái), D (phải).");
        Console.WriteLine("Nhấn bất kỳ phím nào để bắt đầu...");
        Console.ReadKey();
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
        Console.ForegroundColor = ConsoleColor.Gray;

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O"); // Thân rắn
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (food == (i, j))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*"); // Thức ăn
                    Console.ForegroundColor = ConsoleColor.Gray;
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
            food = (rand.Next(1, height - 1), rand.Next(1, width - 1));
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
