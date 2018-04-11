using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		string input;
		while((input=Console.ReadLine())!=null){
			int n = Convert.ToInt32(input);	
			string[] files = new string[n];
			for(int i=0;i<n;i++){
				files[i]=Console.ReadLine();
			}
			
			int collisions=0;
			for(int i=0;i<n;i++){
				for(int j=i+1;j<n;j++){
					if(files[i].GetHashCode()==files[j].GetHashCode()){
						collisions++;
					}
				}
			}
			Console.WriteLine(collisions);
		}
				
	}
}