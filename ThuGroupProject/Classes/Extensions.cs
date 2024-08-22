using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes
{
	public static class Extensions
	{

		public static string upperCase(this string s)
		{

		return s.ToUpper(); 
		}

		public static bool isInteger(this int s, string str, out int sss) {
			bool isint = int.TryParse(str, out sss);
			return isint;
		}
	}
}
