using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes.PersonsFolder
{
	public class CairoEmployee : Employee
	{
		private string _insurance;


		public string insurance { get { return _insurance; } set { _insurance = value; } }

	
    }
}
