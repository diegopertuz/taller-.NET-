/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 02:48 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, sum=0, mult=-1;
			Console.WriteLine("digite 10 numeros");
			for(int i=1;i<=10;i++){
				Console.WriteLine("digite #: "+i);
				num = int.Parse(Console.ReadLine());
				if(num>0){
					sum=sum+num;
				}else if(num<0){
					mult=mult*num;
				}
			}
			
			Console.WriteLine("suma de positivos: "+sum);
			Console.WriteLine("multiplicacion de los negativos: "+mult);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}