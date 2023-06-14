using System;

class Program
{
    static void Main()
    {
        int remainingAttempts = 3;
        int generatedNumber = Caphta();

        while (remainingAttempts > 0)
        {
            if (CevapAl(generatedNumber))
            {
                Console.WriteLine("Siz robot değilsiniz!");
                return;
            }

            remainingAttempts--;
            Console.WriteLine("Yanlış cevap! Kalan hakkınız: " + remainingAttempts);
        }

        Console.WriteLine("Siz robotsunuz!");
    }

    static int Caphta()
    {
        Random random = new Random();
        int number = random.Next(1000, 10000);
        Console.WriteLine("Lütfen aşağıdaki sayıyı doğrulayın: " + number);
        return number;
    }

    static bool CevapAl(int generatedNumber)
    {
        Console.Write("Sayıyı giriniz: ");
        int input = Convert.ToInt32(Console.ReadLine());
        return input == generatedNumber;
    }
}
