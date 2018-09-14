using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrabble_basic_logic_test.hashes;

namespace scrabble_basic_logic_test
{

	/// <summary>
	/// TokenBag object
	/// Holds tokens for the board
	/// Serves as a container and enumerator for the c_Token class
	/// </summary>
	class c_TokenBag
	{
		private c_ScrabblerBoard _parent;
		public c_TokenBag(c_ScrabblerBoard Parent)
		{
			if (Parent == null) { return; }
			this._parent = Parent;
		}

		/// <summary>
		/// How many tokens are in the bag at the start of the game
		/// </summary>
		public int maxTokensInBag { get; set; }
		/// <summary>
		/// <para>Letter - number pairs for tokens</para>
		/// <para>tokenLetters{Key : Value} => { TokenLetter : TokenInt }</para>
		/// <EG>E.g.: ... {'Á':2}, {'B':3}, ... {'H':11}, ...</EG>
		/// </summary>
		public Hashtable tokenLetters { get; set; }
		/// <summary>
		/// <para>How much each token is worth</para>
		/// <para>tokenValues{Key : Value} => { TokenInt : TokenValue }</para>
		/// <EG>E.g.: {1:1}, {2:4}, ... {11:2}, ...</EG>
		/// </summary>
		public Hashtable tokenValues { get; set; }
		/// <summary>
		/// <para>How many there is of each token</para>
		/// <para>tokenAmount{Key : Value} => { TokenInt : NumOfTokens }</para>
		/// <EG>E.g.: {1:6}, {2:2}, ... {6:6}, ...</EG>
		/// </summary>
		public Hashtable tokenAmount { get; set; }

		private StringBuilder allTokenLetters = new StringBuilder();

		IEnumerable<c_Token> tokenContainer = new List<c_Token>();

		public void InitializeAndFill(int maxTokens, Hashtable Letters, Hashtable Values, Hashtable Amount)
		{
			InitializeBag(maxTokens, Letters, Values, Amount);
			FillBag();
		}

		public void InitializeBag(int maxTokens, Hashtable Letters, Hashtable Values, Hashtable Amount)
		{
			this.maxTokensInBag = maxTokens;
			this.tokenLetters = Letters;
			this.tokenValues = Values;
			this.tokenAmount = Amount;

			foreach (object v in Values)
			{

			}
		}

		public void FillBag(int num)
		{
			while (num > 0)
			{

			}
		}

		public void FillBag()
		{
			if (maxTokensInBag > 0)
			{ FillBag(maxTokensInBag); }
			else { FillBag(100); }
		}

		public c_Token TakeRandomToken()
		{
			c_Token ret = null;

			//TODO:

			return ret;
		}

		public c_Token PutRandomToken()
		{
			c_Token ret = null;

			//TODO:

			return ret;
		}
	}

	class c_Token
	{
		public int ID { get; set; }
		public string Letter { get; set; }
		public int Value { get; set; }
		public int WhoPlaced { get; set; }
	}

	
}


