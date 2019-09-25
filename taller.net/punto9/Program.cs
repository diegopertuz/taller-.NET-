/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 03:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, suma=0;
			for(int i=1; i<=5; i++){
				
			Console.WriteLine("digite el numero #"+i);
			num = int.Parse(Console.ReadLine());
			suma = suma+num;
			}
			
			Console.WriteLine("el promedio de los numeros es: "+(suma/5));
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}