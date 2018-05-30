using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharplesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 12;
			int anum = Add1(num);
			Console.WriteLine(anum);
		}
		static int Add1(int number)
		{
			 number++;
			return number;
		}
	}
}
