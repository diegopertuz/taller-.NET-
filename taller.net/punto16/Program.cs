/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 05:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto16
{
	class Program
	{
		public static void Main(string[] args)
		{
			double f=0,e=0;
			int a=0,d=0,c=1,b=0,ca=0;
			for(int i=1; i<=100; i++){
				a=a+i;
					
			}for(int i=1; i<=50; i++){
				if(i%5==0){
					b=b+i;
				}
			}for(int i=0; i<=10; i++){
				c+=i;
			}for(int i=1; i<=15; i++){
				int uno = 1;
				for(int j=2; j<=i; j++){
					d=uno+(uno/j);
					
				}
			}for(int i=1; i<=20; i++){
				
				e+=i;
				
			}for(int i=1; i<=(Math.Pow(2,20)-(1)); i++){
				if(i%2==0){
					
					f+=i;
					
				}
				
			}
			Console.WriteLine("punto A respuesta: "+a);
			Console.WriteLine("punto B respuesta: "+b);
			Console.WriteLine("punto C respuesta: "+c);
			Console.WriteLine("punto D respuesta: "+d);
			Console.WriteLine("punto E respuesta: "+e);
			Console.WriteLine("punto F respuesta: "+f);
			//Console.WriteLine();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}