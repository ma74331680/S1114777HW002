using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int maxValue = 99;
        int minValue = 1;
        int guessNum;
        int randNum = random.Next(minValue, maxValue);
        int guessTimes = 1;
        bool gameState = true;

        Console.WriteLine("==== 猜數字遊戲 ====\n");

        while (gameState)
        {
            Console.Write($"{guessTimes}. 猜數字範圍 {minValue} < ? < {maxValue} :");
            guessNum = Convert.ToInt32(Console.ReadLine());
            if (guessNum > minValue && guessNum < maxValue)
            {
                if (guessNum == randNum)
                {
                    Console.WriteLine($"^=^ 賓果!! 猜對了就是{randNum},共猜 {guessTimes} 次....");
                    gameState = false;
                }
                else if (guessNum != randNum)
                {
                    if (guessNum < randNum)
                    {
                        minValue = guessNum;
                        Console.WriteLine($"再大一點, 您已猜了 {guessTimes} 次\n");
                        guessTimes++;
                    }
                    else
                    {
                        maxValue = guessNum;
                        Console.WriteLine($"再小一點, 您已猜了 {guessTimes} 次\n");
                        guessTimes++;
                    }
                }
            } 
            else 
            {
                Console.WriteLine($"請輸入 {minValue} ~ {maxValue} 的數字\n");
            }
        }

    }
}