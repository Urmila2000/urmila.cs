using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urmila.cs
{
	internal class convert
	{
		public string name = " ";
		public string add = "";

		public void input()
		{
			Console.WriteLine("enter the value");
			name=Console.ReadLine();

			
		}
		public void disp()
		{
			for (int i = 0; i < name.Length; i++)
			{
				char c=convert. (name[i]+1);
			}
		}
		

	
	}

	
}
