using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		string text;
		while((text=Console.ReadLine())!=null){
			if(text.ToLower().IndexOf("problem")!=-1){
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}