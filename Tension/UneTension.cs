using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tension
{
	public class UneTension
	{
		public UneTension()
		{

		}

		public UneTension(string strImport)
		{
			string[] tab = strImport.Split(';');
			sys = int.Parse("0" + tab[0]);
			dia = int.Parse("0" + tab[1]);
			pul = int.Parse("0" + tab[2]);

		}
		public int sys { get; set; }

		public int dia { get; set; }

		public int pul { get; set; }
	}
}
