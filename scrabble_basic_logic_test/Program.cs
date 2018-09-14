using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrabble_basic_logic_test
{
	class Program
	{
		static void Main(string[] args)
		{
			c_ScrabblerBoard brd = new c_ScrabblerBoard();
			brd.initialize();
			Console.SetCursorPosition(0, 2);
			brd.drawBoard();
			Console.Read();
		}

		

	}
}
