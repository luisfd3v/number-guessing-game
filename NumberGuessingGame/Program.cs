Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("You have some chances to guess the correct number.\n");

Random random = new Random();
int randomNumber = random.Next(1, 101);

int option;
int playerChances;

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
        Console.WriteLine("Easy");
        playerChances = 10;
        Console.WriteLine(playerChances);
        break;
    }
    else if (option == 2)
    {
        Console.WriteLine("Medium");
        playerChances = 5;
        Console.WriteLine(playerChances);
        break;
    }
    else if (option == 3)
    {
        Console.WriteLine("Hard");
        playerChances = 3;
        Console.WriteLine(playerChances);
        break;
    }

    Console.WriteLine("\nInvalid option. Please try again.\n");
}