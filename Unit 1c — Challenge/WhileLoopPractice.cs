using System;
					
public class Program
{
	public static void Main()
	{
		int index = 1;
		int eleven = 11;
		var ind = index * eleven;
		while (index <= 5) {
			Console.WriteLine(index + ind);
			index++;
		}
	}
}