/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 05:45 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto17
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum=0, i=0;
			
			while(i<5){
				
				int j = 5;
				
				while(i!=j){
					
					sum += j;
					j--;
				}
				i++;
			}
			
			Console.WriteLine(sum);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}