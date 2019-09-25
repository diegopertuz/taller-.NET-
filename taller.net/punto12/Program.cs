/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 04:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto12
{
	class Program
	{
		public static void Main(string[] args)
		{
			double mult = 1;
			for(int i=10; i<=20; i++){
				Console.WriteLine(i);
			mult=mult*i;
			} 
			Console.WriteLine("el resultado es: "+mult);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}