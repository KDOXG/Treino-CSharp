using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveis
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numero1 = 10;
			int numero2 = 20;
			var soma = numero1 + numero2;
			Console.WriteLine("O valor da conta eh " + soma);

			var quadrado1 = new Quadrado();
			quadrado1.lado = 10;
			var quadrado2 = quadrado1;
			quadrado2.lado = 11;
			Console.WriteLine(quadrado1.lado);
			Console.WriteLine(quadrado2.lado);
		}
		class Quadrado
        {
			public int lado;
        }
	}

}