/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 04:38 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto11
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n, num, pares=0, impares=0;
			Console.WriteLine("digite la cantidad de numeros por ingresar ");
			n = int.Parse(Console.ReadLine());
				
			for(int i=1; i<=n; i++){
				Console.WriteLine("digite el numero "+i);
				num = int.Parse(Console.ReadLine());
				if(num%2==0){
				    pares++;
				}else if(num%2!=0){
					impares++;
				}
			}
			Console.WriteLine("los pares son: "+pares);
			Console.WriteLine("los impares son: " +impares);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}