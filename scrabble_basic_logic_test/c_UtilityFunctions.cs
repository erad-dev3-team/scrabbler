using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrabble_basic_logic_test
{
	class c_UtilityFunctions
	{
		private c_ScrabblerBoard _parent;
		public c_UtilityFunctions(c_ScrabblerBoard Parent)
		{
			if(Parent == null) { return; }
			_parent = Parent;
		}

		/// <summary>
		/// Generates the scrabble board as a 15x15 2d array
		/// Generates a secondary array containing the special places on the board
		/// </summary>
		public void generate_board()
		{
			img_2_board(ref _parent.brd.boardUpperLayerMatrix, true);
			img_2_board(ref _parent.brd.boardSpecialLayerMatrix, true);
		}

		/// <summary>
		/// Draws an ascii representation of the board
		/// Takes mode: 0 for empty board 1 for board with words
		/// </summary>
		/// <param name="mode">0 for empty board 1 for board with words</param>
		public void draw_board(int mode)
		{
			int[,] b = null;

			if (mode == 0)
			{
				b = _parent.brd.boardSpecialLayerMatrix;
			}
			else
			{
				b = _parent.brd.boardUpperLayerMatrix;
			}

			Console.Write("|─");
			for (int i = 0; i < 14; i++) { Console.Write("┼─"); }
			Console.WriteLine("|");

			for (int h = 0; h < Math.Sqrt(b.Length); h++)
			{
				
				for (int v = 0; v < Math.Sqrt(b.Length); v++)
				{
					Color c = Color.FromArgb(b[h, v]);
					string ss = " ";
					Console.Write("|");
					if(c.ToArgb() == -1)
					{
						Console.ForegroundColor = ConsoleColor.White;
						ss = "×";
					}
					else if (c.R * c.G > 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						ss = "w";
					}
					else if (c.G * c.B > 0)
					{
						Console.ForegroundColor = ConsoleColor.Cyan;
						ss = "l";
					}
					else if (c.R > 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkMagenta;
						ss = "W";
					}
					else if(c.B > 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						ss = "L";
					}
					Console.Write(ss);
					Console.ForegroundColor = ConsoleColor.Gray;
				}
				Console.WriteLine("|");
				Console.Write("|─");
				for (int i = 0; i < 14; i++) { Console.Write("┼─"); }
				Console.WriteLine("|");

			}
		}

		public void img_2_board(ref int[,] brd, bool empty)
		{
			Bitmap img = null;
			if (empty)
			{
				img = Properties.res.scrabble_empty_board;
			}

			for(int h = 0; h < img.Width; h++)
			{
				for(int v = 0; v < img.Height; v++)
				{
					brd.SetValue(img.GetPixel(h, v).ToArgb(), new int[] { h, v });
				}
			}
		}

		public void board_2_img()
		{

		}
	}
}
