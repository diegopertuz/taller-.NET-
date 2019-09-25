/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 02:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
					int num, sum=0;
					Console.WriteLine("digite el numero");
					num = int.Parse(Console.ReadLine());
					
					for(int i=(num-1); i!=0; i--){
						
						sum=sum+i;
						
					}
					Console.WriteLine("la suma total es: "+sum);
					
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}