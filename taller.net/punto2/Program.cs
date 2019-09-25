/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 02:48 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.WriteLine("digite un numero");
			num = int.Parse(Console.ReadLine());
			for(int i=0; i<=num; i++){
				Console.WriteLine(i);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}