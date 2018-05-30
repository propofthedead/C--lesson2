using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharplesson2
{
	class Program
	{
		static int add(int num, int inc)
		{
			num += inc;
			return num;
		}
		static int add(int number)
		{
			return add(number, 1);
		}
		static void Main(string[] args)
		{
			int num = 12;
			int anum = add(num);
			int rnum = add(num, anum);
			Console.WriteLine("{0} plus i is {1}, but add them together to get {2}",num,anum,rnum);
		}
	
	}
}
