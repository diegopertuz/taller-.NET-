/*
 * Created by SharpDevelop.
 * User: user7
 * Date: 22/09/2019
 * Time: 03:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto8
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			int sexo, sueldo, contadorm=0, contadorf=0;
			for(int i=1; i<=10; i++){
				Console.WriteLine("digite su sexo (1=femenino 2=masculino)");
				sexo=int.Parse(Console.ReadLine());
				Console.WriteLine("digite su sueldo");
				sueldo=int.Parse(Console.ReadLine());
				Console.WriteLine("digite su nombre");
				nombre = Console.ReadLine();
				
				if(sueldo>500 && sexo==1){
					contadorf++;
				}else if(sueldo<400 && sexo==2){
					contadorm++;
				}
			}
			
			Console.WriteLine("las mujeres que ganan mas de 500 son: "+contadorf);
			Console.WriteLine("los hombres que ganan menos de 400 son: "+contadorm);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}