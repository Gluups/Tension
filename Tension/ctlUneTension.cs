using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tension
{
	[DefaultBindingProperty("strValues")]
	public partial class ctlUneTension : UserControl
	{
		public int sys;
		public int dia;
		public int pul;
		public string strValues=";;";

		public ctlUneTension()
		{
			InitializeComponent();
		}

		public void import(string strImport)
		{
			string[] Tbl = strImport.Split(';');
			ctlUnNb1.import(int.Parse(Tbl[0]));
			ctlUnNb2.import(int.Parse(Tbl[1]));
			ctlUnNb3.import(int.Parse(Tbl[2]));

		}

		private void ctlUneTension_Leave(object sender, EventArgs e)
		{
			export();
		}

		private void ctlUnNb2_Validating(object sender, CancelEventArgs e)
		{

		}

		private void export()
		{
			strValues = sys.ToString() + ";" + dia.ToString() + ";" + pul.ToString();
		}

		private void ctlUnNb2_Leave(object sender, EventArgs e)
		{
			dia = this.ctlUnNb2.nb;
			export();
		}

		private void ctlUnNb3_Leave(object sender, EventArgs e)
		{
			pul = ctlUnNb3.nb;
			export();
		}

		private void ctlUnNb1_Leave(object sender, EventArgs e)
		{
			sys = this.ctlUnNb1.nb;
			export();
		}

	}
}
