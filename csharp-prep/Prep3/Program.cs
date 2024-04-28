using System;

class Program
{
    static void Main(string[] args)
    {   
        Random generateRandom = new Random();
        int magicNumberInNummber = generateRandom.Next(1, 100);
        // Console.Write("what is the magic number: ");
        // string magicNumberInString = Console.ReadLine();
        // int magicNumberInNummber = int.Parse(magicNumberInString);
        int guessInNumber = 0;

        while (guessInNumber != magicNumberInNummber)
        {
            Console.Write("what is your guess: ");
            string guessInString = Console.ReadLine();
            guessInNumber = int.Parse(guessInString);
        
            if (guessInNumber < magicNumberInNummber)
            {
                Console.WriteLine("guess higher");
            }
            else if (guessInNumber > magicNumberInNummber)
            {
                Console.WriteLine("guess lower");
            }
            else
            {
                Console.WriteLine($"Congratulations, you guessed the right figure");
            }                    
        }

    }
}