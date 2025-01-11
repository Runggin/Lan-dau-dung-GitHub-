using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Chào mừng đến với game Blackjack! ===\n");

        while (true)
        {
            Console.Write("Bắt đầu trò chơi mới? (Y/N): ");
            string choice = Console.ReadLine()?.Trim().ToLower();

            if (choice == "y")
            {
                PlayGame();
            }
            else if (choice == "n")
            {
                Console.WriteLine("Cảm ơn bạn đã chơi! Hẹn gặp lại.");
                break;
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập 'Y' để chơi hoặc 'N' để thoát.");
            }
        }
    }

    static void PlayGame()
    {
        // Tạo bộ bài
        List<string> deck = CreateDeck();
        ShuffleDeck(deck);

        // Chia bài cho người chơi và dealer
        List<string> playerHand = new List<string> { DrawCard(deck), DrawCard(deck) };
        List<string> dealerHand = new List<string> { DrawCard(deck), DrawCard(deck) };

        Console.WriteLine("\nBài của bạn: " + string.Join(", ", playerHand) + " (Tổng điểm: " + CalculateScore(playerHand) + ")");
        Console.WriteLine("Dealer có: " + dealerHand[0] + ", ?");

        // Lượt chơi của người chơi
        while (true)
        {
            Console.Write("\nBạn muốn 'hit' (rút bài) hay 'stand' (dừng lại)? ");
            string action = Console.ReadLine()?.Trim().ToLower();

            if (action == "hit")
            {
                playerHand.Add(DrawCard(deck));
                int playerScore = CalculateScore(playerHand);
                Console.WriteLine("Bài của bạn: " + string.Join(", ", playerHand) + " (Tổng điểm: " + playerScore + ")");

                if (playerScore > 21)
                {
                    Console.WriteLine("Bạn đã vượt quá 21! Bạn thua.");
                    return;
                }
            }
            else if (action == "stand")
            {
                break;
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập 'hit' hoặc 'stand'.");
            }
        }

        // Lượt chơi của dealer
        while (CalculateScore(dealerHand) < 17)
        {
            dealerHand.Add(DrawCard(deck));
        }

        Console.WriteLine("\nDealer có: " + string.Join(", ", dealerHand) + " (Tổng điểm: " + CalculateScore(dealerHand) + ")");

        // Tính toán kết quả
        int playerScoreFinal = CalculateScore(playerHand);
        int dealerScoreFinal = CalculateScore(dealerHand);

        if (dealerScoreFinal > 21 || playerScoreFinal > dealerScoreFinal)
        {
            Console.WriteLine("\nBạn thắng!");
        }
        else if (playerScoreFinal == dealerScoreFinal)
        {
            Console.WriteLine("\nHòa!");
        }
        else
        {
            Console.WriteLine("\nBạn thua!");
        }
    }

    static List<string> CreateDeck()
    {
        string[] suits = { "♠", "♥", "♦", "♣" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<string> deck = new List<string>();

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                deck.Add(rank + suit);
            }
        }
        return deck;
    }

    static void ShuffleDeck(List<string> deck)
    {
        Random random = new Random();
        for (int i = 0; i < deck.Count; i++)
        {
            int j = random.Next(deck.Count);
            (deck[i], deck[j]) = (deck[j], deck[i]);
        }
    }

    static string DrawCard(List<string> deck)
    {
        string card = deck[0];
        deck.RemoveAt(0);
        return card;
    }

    static int CalculateScore(List<string> hand)
    {
        int score = 0;
        int aceCount = 0;

        foreach (var card in hand)
        {
            string rank = card.Substring(0, card.Length - 1);
            if (rank == "J" || rank == "Q" || rank == "K")
            {
                score += 10;
            }
            else if (rank == "A")
            {
                aceCount++;
                score += 11; // Tạm tính A là 11
            }
            else
            {
                score += int.Parse(rank);
            }
        }

        // Điều chỉnh giá trị của A nếu vượt quá 21
        while (score > 21 && aceCount > 0)
        {
            score -= 10;
            aceCount--;
        }

        return score;
    }
}