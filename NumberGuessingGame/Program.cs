Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("You have some chances to guess the correct number.");

Random random = new Random();
int randomNumber = random.Next(1, 101);