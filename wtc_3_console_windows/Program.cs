using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using wtc_3_classes.console;

namespace wtc_3_console_windows
{
	class Program
	{
		public static System.Windows.Forms.Timer tim = new System.Windows.Forms.Timer();
		public static cursor_pos cp = new cursor_pos();
		public static Thread t = new Thread(() => loadData());
		public static bool insert = false;

		static void Main(string[] args)
		{
			tim.Interval = 500;
			tim.Tick += Tim_Tick;
			Semaphore s = new Semaphore(0, 10);
			
			t.Start();

			while(t != null)
			{
				Console.Title = DateTime.Now.ToLongTimeString();
				s.WaitOne(100);
			}

			Console.WriteLine("Program End");
			Console.Read();
		}

		private static void Tim_Tick(object sender, EventArgs e)
		{
			insert = false;
		}

		public static void loadData()
		{
			string s = "";
			ConsoleKeyInfo k;
			insert = true;
			while (insert && !File.Exists(s))
			{
				insert = true;
				tim.Start();
				
				s += k.KeyChar;
			}

			
			Console.WriteLine("||" + s + "||");

			try
			{
				t = null;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
