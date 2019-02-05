using System;

namespace flynoob
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			DataMgr dataMgr = new DataMgr ();
			ServNet servNet = new ServNet();
			servNet.proto = new ProtocolBytes ();
			servNet.Start("127.0.0.1",1234);

			while(true)
			{
				string str = Console.ReadLine();
				switch(str)
				{
				case "exit":
					servNet.Close();
					return;
				case "info":
					servNet.Print();
					break;
				}
			}

		}
	}
}
