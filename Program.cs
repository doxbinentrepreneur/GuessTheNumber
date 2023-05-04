
bool guessed = false;
Random random = new Random();
int needed = random.Next(0, 100);
while (!guessed)
{
    Console.WriteLine("Guess a number (1-100): ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == needed)
    {
        Console.WriteLine("You guessed it!");
        guessed = true;
        break;
    }
    else if (guess > needed)
    {
        Console.WriteLine("Too high!");
    }
    else if (guess < needed)
    {
        Console.WriteLine("Too low!");
    }


}
