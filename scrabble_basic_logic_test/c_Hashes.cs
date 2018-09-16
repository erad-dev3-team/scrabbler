using System.Collections.Generic;

namespace scrabble_basic_logic_test.hashes
{
	public interface Ihash { };

	public static class Hashes
	{
		public static Ihash create<Tk, Tv>()
		{
			Ihash h;

			switch (typeof(Tk).Name.ToString())
			{
				case "Int32":
					switch (typeof(Tv).Name.ToString())
					{
						case "Int32":
							h = new ii_hash();
							break;

						case "String":
							h = new is_hash();
							break;

						case "Char":
							h = new ic_hash();
							break;

						default:
							h = null;
							break;
					}
					break;

				case "String":
					switch (typeof(Tv).Name.ToString())
					{
						case "Int32":
							h = new si_hash();
							break;

						case "String":
							h = new ss_hash();
							break;

						case "Char":
							h = new sc_hash();
							break;

						default:
							h = null;
							break;
					}
					break;

				case "Char":
					switch (typeof(Tv).Name.ToString())
					{
						case "Int32":
							h = new ci_hash();
							break;

						case "String":
							h = new cs_hash();
							break;

						case "Char":
							h = new cc_hash();
							break;

						default:
							h = null;
							break;
					}
					break;

				default:
					h = null;
					break;
			}

			return h;
		}

		public struct ii_hash : Ihash
		{
			public ii_hash(int key, int value)
			{
				this.Key = key;
				this.Value = value;
			}

			public int Key;
			public int Value;

			public override string ToString()
			{
				return string.Format("{{ {0} : {1} }}", Key, Value);
			}
		}

		public struct ss_hash : Ihash
		{
			public ss_hash(string key, string value)
			{
				this.Key = key;
				this.Value = value;
			}

			public string Key;
			public string Value;

			public override string ToString()
			{
				return string.Format("{{ \"{0}\" : \"{1}\" }}", Key, Value);
			}
		}

		public struct cc_hash : Ihash
		{
			public cc_hash(char key, char value)
			{
				this.Key = key;
				this.Value = value;
			}

			public char Key;
			public char Value;

			public override string ToString()
			{
				return string.Format("{{ '{0}' : '{1}' }}", Key, Value);
			}
		}

		public struct si_hash : Ihash
		{
			public si_hash(string key, int value)
			{
				this.Key = key;
				this.Value = value;
			}

			public string Key;
			public int Value;

			public override string ToString()
			{
				return string.Format("{{ \"{0}\" : {1} }}", Key, Value);
			}
		}

		public struct is_hash : Ihash
		{
			public is_hash(int key, string value)
			{
				this.Key = key;
				this.Value = value;
			}

			public int Key;
			public string Value;

			public override string ToString()
			{
				return string.Format("{{ {0} : \"{1}\" }}", Key, Value);
			}
		}

		public struct ci_hash : Ihash
		{
			public ci_hash(char key, int value)
			{
				this.Key = key;
				this.Value = value;
			}

			public char Key;
			public int Value;

			public override string ToString()
			{
				return string.Format("{{ '{0}' : {1} }}", Key, Value);
			}
		}

		public struct ic_hash : Ihash
		{
			public ic_hash(int key, char value)
			{
				this.Key = key;
				this.Value = value;
			}

			public int Key;
			public char Value;

			public override string ToString()
			{
				return string.Format("{{ {0} : '{1}' }}", Key, Value);
			}
		}

		public struct cs_hash : Ihash
		{
			public cs_hash(char key, string value)
			{
				this.Key = key;
				this.Value = value;
			}

			public char Key;
			public string Value;

			public override string ToString()
			{
				return string.Format("{{ '{0}' : \"{1}\" }}", Key, Value);
			}
		}

		public struct sc_hash : Ihash
		{
			public sc_hash(string key, char value)
			{
				this.Key = key;
				this.Value = value;
			}

			public string Key;
			public char Value;

			public override string ToString()
			{
				return string.Format("{{ \"{0}\" : '{1}' }}", Key, Value);
			}
		}

		public struct hashContainer
		{
			List<Ihash> hashList = new List<Ihash>();


		}
}

	
}