using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tension
{
	public class UnJour
	{
		public UnJour()
		{
			matin1 = new UneTension();
			matin2 = new UneTension();
			matin3 = new UneTension();
			soir1 = new UneTension();
			soir2 = new UneTension();
			soir3 = new UneTension();
			jour = DateTime.Now.Day;
			mois = DateTime.Now.Month;
			annee = DateTime.Now.Year;
		}

		public int Id { get; set; }

		public int annee { get; set; }

		public int mois { get; set; }

		public int jour { get; set; }

		public UneTension matin1 { get; set; }

		public UneTension matin2 { get; set; }

		public UneTension matin3 { get; set; }

		public UneTension moyMatin { get; set; }


		public UneTension soir1 { get; set; }

		public UneTension soir2 { get; set; }

		public UneTension soir3 { get; set; }

		public UneTension moySoir { get; set; }
	}
}
