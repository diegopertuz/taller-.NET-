/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 05:00 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto13
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			int num, contador=1, positivos=0, negativos=0;
			
			
			do{
				Console.WriteLine("digite numero : "+contador+" (999 para salir)");
				num = int.Parse(Console.ReadLine());
				if(num>0){
					positivos++;
				}else if(num<0){
					negativos++;
				}
				contador++;
			}while(num!=999);
			
			Console.WriteLine("la cantidad de positivos son: "+positivos);
			Console.WriteLine("la cantidad de negativos son: "+negativos);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}