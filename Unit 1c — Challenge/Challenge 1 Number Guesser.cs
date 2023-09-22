using System;
					
public class Program
{
	public static void Main()
	{
		/* Challenge 1: Number Guesser
 		Create a game where the program generates a random number between 1 and 10. Prompt the user to guess the number. 
		Use a loop to give the user multiple chances to guess. Provide feedback after each guess, indicating if the guess is too high or too low. 
		When the user assumes the correct number, display a congratulatory message and the number of attempts made. */
		
		// Import random
		Random random = new Random();
		
		// Initialize the guess int
		int guess;
		
		// Generate random number
		int answer = random.Next(0,11);
		
		// Explain the game and get user input
		Console.WriteLine("This is a Guessing Game, pick a number between 1 - 10: ");
		guess = Convert.ToInt32(Console.ReadLine());
		
		// Create while loop to continually ask for answer until user guess is the answer
		while(true){
			
			// If statement comparing guess to answer and looping to ask again if incorrect
			if (guess != answer) {
				Console.WriteLine("That is not correct, try again:");
				guess = Convert.ToInt32(Console.ReadLine());
			} else {
				Console.WriteLine("Congratulations you guessed correctly with the number " + guess + ".");
				// Break is used to break out of loop and stop
				break;
			}
		
		}
	}
}