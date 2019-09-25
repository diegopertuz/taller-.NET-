/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 02:48 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n, contador=0;
			Console.WriteLine("digite numero");
			n = int.Parse(Console.ReadLine());
			
			for(int i=0; i<=n; i++){
				
				if(i%5==0){
					
					contador++;
				}
			}
			
			Console.WriteLine("los cantidad de multiplos de 5 que hay del uno hasta "+n+" son: "+contador);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}