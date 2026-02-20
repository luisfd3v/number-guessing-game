Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("You have some chances to guess the correct number.\n");

Random random = new Random();
int randomNumber = random.Next(1, 101);

int option;
int playerChances;
int playerAttempts = 0;
int playerGuess;

while (true)
{
    Console.WriteLine("Please select the difficulty level: ");
    Console.WriteLine("1. Easy (10 chances)");
    Console.WriteLine("2. Medium (5 chances)");
    Console.WriteLine("3. Hard (3 chances)");

    Console.Write("\nEnter your choice: ");
    int.TryParse(Console.ReadLine(), out option);

    if (option == 1)
    {
        Console.WriteLine("Great! You have selected the Easy difficulty level.\r\nLet's start the game!\n");
        playerChances = 10;
        break;
    }
    else if (option == 2)
    {
        Console.WriteLine("Great! You have selected the Medium difficulty level.\r\nLet's start the game!\n");
        playerChances = 5;
        break;
    }
    else if (option == 3)
    {
        Console.WriteLine("Great! You have selected the Hard difficulty level.\r\nLet's start the game!\n");
        playerChances = 3;
        break;
    }

    Console.WriteLine("\nInvalid option. Please try again.\n");
}

while (playerAttempts < playerChances)
{
    Console.Write("Enter your guess: ");
    
    bool isValid = int.TryParse(Console.ReadLine(), out playerGuess);

    if (!isValid)
    {
        Console.WriteLine("Invalid input! Please enter a number.");
        continue;
    }

    playerAttempts++;

    if (playerGuess == randomNumber)
    {
        Console.WriteLine($"Congratulations! You guessed the correct number in {playerAttempts} attempts!");
        break;
    }
    else if (playerGuess > randomNumber)
    {
        Console.WriteLine($"Incorrect! The number is less than {playerGuess}");
    }
    else if (playerGuess < randomNumber)
    {
        Console.WriteLine($"Incorrect! The number is greater than {playerGuess}");
    }
}

if (playerAttempts == playerChances)
{
    Console.WriteLine($"\nYou loose :( the correct number was {randomNumber}.");
}