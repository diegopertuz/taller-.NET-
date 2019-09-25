/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 03:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int personas, peso, mayor=0, menor=0;
			Console.WriteLine("ingrese el numero de personas que va a digitar el peso !");
			personas = int.Parse(Console.ReadLine());
			for(int i=1; i<=personas; i++){
				Console.WriteLine("digite el peso de la persona #: "+i);
			    peso = int.Parse(Console.ReadLine());
				if(peso>=80){
					mayor++;
				}else if(peso<=79){
					menor++;
				}
			}
			
				Console.WriteLine("mayores de 80kg son: "+mayor);
				Console.WriteLine("menor de 80kg son: "+menor);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}