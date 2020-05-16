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
	[DefaultBindingProperty("nb")]
	public partial class ctlUnNb : UserControl
	{
		public int nb;

		public ctlUnNb()
		{
			InitializeComponent();
		}

		private void btnUp10_Click(object sender, EventArgs e)
		{
			if(numericUpDown1.Value <= (numericUpDown1.Maximum - 10))
			numericUpDown1.Value += 10;
		}

		private void btnDn10_Click(object sender, EventArgs e)
		{
			if(numericUpDown1.Value >= 10)
			numericUpDown1.Value -= 10;
		}

		private void btnUp100_Click(object sender, EventArgs e)
		{
			if (numericUpDown1.Value <= (numericUpDown1.Maximum - 100))
			numericUpDown1.Value += 100;
		}

		private void btnDn100_Click(object sender, EventArgs e)
		{
			if(numericUpDown1.Value >= 100)
			numericUpDown1.Value -= 100;
		}

		private void numericUpDown1_Enter(object sender, EventArgs e)
		{
			numericUpDown1.BackColor = Color.Blue;
			numericUpDown1.ForeColor = Color.White;
		}

		private void numericUpDown1_Leave(object sender, EventArgs e)
		{
			numericUpDown1.BackColor = Color.White;
			numericUpDown1.ForeColor = Color.Black;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.nb = (int)numericUpDown1.Value;
		}

		public void import(int i)
		{
			this.nb = i;
			numericUpDown1.Value = i;

		}
	}
}
