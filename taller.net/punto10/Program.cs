/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 04:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto10
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, mayor=0, menor=0;
			for(int i=1; i<=10; i++){
				Console.WriteLine("digite el numero "+i);
				num = int.Parse(Console.ReadLine());
				if(num>0){
				    mayor++;
				}else if(num<0){
					menor++;
				}
			}
			Console.WriteLine("los mayores son: "+mayor);
			Console.WriteLine("los menores son: " +menor);
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}