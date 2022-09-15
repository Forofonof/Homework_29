using System;

internal class Program
{
    static void Main(string[] args)
    {
        CheckingNumbers();
    }
    static int CheckingNumbers()
    {
        int number = 0;
        string userInput;
        bool isWorking = true;

        while (isWorking)
        {
            Console.WriteLine("Введите число: ");
            userInput = Console.ReadLine();

            if (Int32.TryParse(userInput, out number))
            {
                Console.WriteLine(number);
                isWorking = false;
            }
            else
            {
                Console.WriteLine("Введено неверное значение.");
            }
        }
        return number;
    }
}