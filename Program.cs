using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");
    int userGuess = int.Parse(Console.ReadLine());

    int secretNumber = 42;

    Console.WriteLine(secretNumber);

    if (userGuess == secretNumber)
    {
        Console.WriteLine("You got it correct");
    }
    else
    {
        Console.WriteLine("Try Again");
    }

}

Main();
