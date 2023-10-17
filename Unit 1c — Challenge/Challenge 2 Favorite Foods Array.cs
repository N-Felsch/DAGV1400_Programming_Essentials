using System;
					
public class Program
{
	public static void Main()
	{
		/* Challenge 2: Favorite Foods
  		Create a program that prompts the user to enter their three favorite foods. Use an array to store these food items. 
		Display each item on a new line with a message, such as "I love [food item]!". Use a loop to iterate through the array and print the messages. */
		
		// Prompt user for how many food items they like and convert number to int
		Console.WriteLine("How many favorite foods do you have?: ");
		int numberFavFoods = Convert.ToInt32(Console.ReadLine());
		
		// Create new array named foods and set the amount within the array to number specified above
		string[] foods = new string[numberFavFoods];
		
		// Used for loop to prompt user for input as many times as favorite foods they have
		for(var i = 0; i < numberFavFoods; i++){
			// I'm setting the index to i + 1 because I don't want to the user to start out at 0, I'd rather them start off at 1
			Console.WriteLine("What is your #" + (i + 1) + " favorite food?");
			foods[i] = Console.ReadLine();
		}
		
		// Printing to the console their favorite foods, plus a little message specifying they like them
		for(var i = 0; i < foods.Length; i++) {
			Console.WriteLine("I love these food itesm: " + foods[i] +".");
		}
		
		// Printing how many items they like
		Console.WriteLine("You have " + numberFavFoods + " favorite foods.");
			
	}
		
}