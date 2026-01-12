namespace Mission2Assignment;

public class DiceRoll
{
    public int[] RollDice(int numberOfRolls)
    {
        // Creating a new array to keep track of the counts for each possible dice total
        int[] rollCounts = new int[11];
        // Creating the random number generator (only need one of these, that's why it is not in the loop)
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int total = die1 + die2;

            int index = total - 2;
            rollCounts[index]++; // (AKA rollCounts[index] = rollCounts[index] + 1 )
        }

        return rollCounts; // Returns the entire array
    }
}