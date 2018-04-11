using System;
using System.Text;
					
public class Program
{
	
	public static void Main()
	{
		var n = Convert.ToInt32(Console.ReadLine());
		var inputsArray = new string[n*2];
		for(int i = 0; i < n*2; i++) {
			inputsArray[i] = Console.ReadLine();
		}
		
		
		for(int i = 0; i < inputsArray.Length; i=i+2){
			var first = inputsArray[i];
			var second = inputsArray[i+1];
			Console.WriteLine(first);
			Console.WriteLine(second);
			var result = new StringBuilder();
			for(int y = 0; y < first.Length; y++) {
				if(first[y] == second[y]) {
					result.Append(".");
				}
				else {
					result.Append("*");
				}
			}
			Console.WriteLine(result);
			Console.WriteLine();
		}
		
	}
}