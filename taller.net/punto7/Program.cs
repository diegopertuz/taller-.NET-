/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 03:39 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, result;
			Console.WriteLine("digite un numero");
			num= int.Parse(Console.ReadLine());
			
			for(int i=1; i<=10; i++){
				result=num*i;
				Console.WriteLine(num+"x"+i+" ="+result);
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}