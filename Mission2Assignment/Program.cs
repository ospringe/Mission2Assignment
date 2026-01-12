// See https://aka.ms/new-console-template for more information

using Mission2Assignment;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        
        int numberOfRolls = int.Parse(Console.ReadLine());
        
        // Create the DiceRoll object
        DiceRoll diceRoller = new DiceRoll();
        // Calling the RollDice method, in the DiceRoll class, and storing the count of each possible dice total (2-12) in an array
        int[] results = diceRoller.RollDice(numberOfRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numberOfRolls + ".");

        for (int i = 0; i < results.Length; i++)
        {
            int score = i + 2; 
            int count = results[i]; // Getting the count for the associated score

            // Calculating the percentage of that score's rolls
            double percentage = ((double)count / numberOfRolls) * 100; // (double)count is called 'casting.' It tells C#, "Treat this int like a decimal number."
            // The percentage is basically the number of stars, so round to remove decimal and turn it into an integer
            int stars = (int)Math.Round(percentage);
            
            Console.Write(score + ": ");
            // For each number of stars
            for (int j = 0; j < stars; j++)
            {
                // print a star
                Console.Write("*");
            }
            // Print that whole line of stars we created
            Console.WriteLine();
        }  
        
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}