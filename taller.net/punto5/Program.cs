/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 03:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto5
{
	class Program
	{
		public static void Main(string[] args)
		{
			for(int i=1; i<=10; i++){
				
				Console.WriteLine("el cudrado de "+i+" es:"+(Math.Pow(i,2)));
				Console.WriteLine("el cubo de "+i+" es:"+(Math.Pow(i,3)));
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}