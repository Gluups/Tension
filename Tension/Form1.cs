using ChoETL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tension
{
	public partial class Form1 : Form
	{
		// Commentaire 1

		string strTension1 = "";
		string strTension2 = "";
		string strTension3 = "";
		string strTension4 = "";
		string strTension5 = "";
		string strTension6 = "";

		List<UnJour> LJ = new List<UnJour>();


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UnJourTransfert ujt = new UnJourTransfert();
			using (ChoCSVReader<UnJourTransfert> reader = new ChoCSVReader<UnJourTransfert>("Tension.csv"))
			{
				while((ujt = reader.Read()) != null)
				{
					UneTension tension1 = new UneTension(ujt.sys1.ToString() + ";" + ujt.dia1.ToString() + ";" + ujt.pul1.ToString());
					UneTension tension2 = new UneTension(ujt.sys2.ToString() + ";" + ujt.dia2.ToString() + ";" + ujt.pul2.ToString());
					UneTension tension3 = new UneTension(ujt.sys3.ToString() + ";" + ujt.dia3.ToString() + ";" + ujt.pul3.ToString());
					UneTension tension4 = new UneTension(ujt.sys4.ToString() + ";" + ujt.dia4.ToString() + ";" + ujt.pul4.ToString());
					UneTension tension5 = new UneTension(ujt.sys5.ToString() + ";" + ujt.dia5.ToString() + ";" + ujt.pul5.ToString());
					UneTension tension6 = new UneTension(ujt.sys6.ToString() + ";" + ujt.dia6.ToString() + ";" + ujt.pul6.ToString());
					UnJour uj = new UnJour();
					uj.matin1 = tension1;
					uj.matin2 = tension2;
					uj.matin3 = tension3;
					uj.soir1 = tension4;
					uj.soir2 = tension5;
					uj.soir3 = tension6;
					this.dateTimePicker1.Value = DateTime.Parse(ujt.LaDate);
					uj.annee = dateTimePicker1.Value.Year;
					uj.mois = dateTimePicker1.Value.Month;
					uj.jour = dateTimePicker1.Value.Month;
					LJ.Add(uj);
					ctlUneTension1.import(tension1.sys.ToString() + ";" + tension1.dia.ToString() + ";" + tension1.pul.ToString());
					ctlUneTension2.import(tension2.sys.ToString() + ";" + tension2.dia.ToString() + ";" + tension2.pul.ToString());
					ctlUneTension3.import(tension3.sys.ToString() + ";" + tension3.dia.ToString() + ";" + tension3.pul.ToString());
					ctlUneTension4.import(tension4.sys.ToString() + ";" + tension4.dia.ToString() + ";" + tension4.pul.ToString());
					ctlUneTension5.import(tension5.sys.ToString() + ";" + tension5.dia.ToString() + ";" + tension5.pul.ToString());
					ctlUneTension6.import(tension6.sys.ToString() + ";" + tension6.dia.ToString() + ";" + tension6.pul.ToString());
				}
			}
			//foreach(UnJourTransfert ujt in ChoCSVReader<UnJourTransfert>("Tension.csv"))
			//{

			//}
			//cutMatin2.Left = cutMatin1.Left + 350;
			//cutMatin3.Left = cutMatin2.Left + 350;

			//cutSoir2.Left = cutSoir1.Left + 350;
			//cutSoir3.Left = cutSoir2.Left + 350;

			//lblMatin2.Left = cutMatin2.Left + 30;
			//lblMatin3.Left = cutMatin3.Left = 30;

			//lblSoir2.Left = lblMatin2.Left;
			//lblMatin3.Left = lblSoir3.Left;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			btnOK.Focus();
			MessageBox.Show(ctlUneTension1.strValues, "Matin1");
			MessageBox.Show(ctlUneTension2.strValues, "Matin2");
			MessageBox.Show(ctlUneTension3.strValues, "Matin3");
			MessageBox.Show(ctlUneTension4.strValues, "Soir1");
			MessageBox.Show(ctlUneTension5.strValues, "Soir2");
			MessageBox.Show(ctlUneTension6.strValues, "Soir3");
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.InitialDirectory = Application.StartupPath;
			sfd.ShowDialog();
			using (ChoETL.ChoCSVWriter<UnJourTransfert> writer = new ChoCSVWriter<UnJourTransfert>(sfd.FileName))
			{
				UnJour unJour = new UnJour();
				UnJourTransfert ujt = new UnJourTransfert();
				unJour.Id = 1;
				unJour.annee = this.dateTimePicker1.Value.Year;
				unJour.mois = this.dateTimePicker1.Value.Month;
				unJour.jour = this.dateTimePicker1.Value.Day;
				ujt.LaDate = DateTime.Parse(this.dateTimePicker1.Text).ToString("yyyy-MM-dd");
				unJour.matin1 = new UneTension();
				unJour.matin2 = new UneTension();
				unJour.matin3 = new UneTension();
				unJour.soir1 = new UneTension();
				unJour.soir2 = new UneTension();
				unJour.soir3 = new UneTension();
				try
				{
					unJour.matin1.sys = int.Parse("0" + ctlUneTension1.strValues.Split(';')[0]);
					unJour.matin1.dia = int.Parse("0" + ctlUneTension1.strValues.Split(';')[1]);
					unJour.matin1.pul = int.Parse("0" + ctlUneTension1.strValues.Split(';')[2]);


					unJour.matin2.sys = int.Parse("0" + ctlUneTension2.strValues.Split(';')[0]);
					unJour.matin2.dia = int.Parse("0" + ctlUneTension2.strValues.Split(';')[1]);
					unJour.matin2.pul = int.Parse("0" + ctlUneTension2.strValues.Split(';')[2]);

					unJour.matin3.sys = int.Parse("0" + ctlUneTension3.strValues.Split(';')[0]);
					unJour.matin3.dia = int.Parse("0" + ctlUneTension3.strValues.Split(';')[1]);
					unJour.matin3.pul = int.Parse("0" + ctlUneTension3.strValues.Split(';')[2]);

					unJour.soir1.sys = int.Parse("0" + ctlUneTension4.strValues.Split(';')[0]);
					unJour.soir1.dia = int.Parse("0" + ctlUneTension4.strValues.Split(';')[1]);
					unJour.soir1.pul = int.Parse("0" + ctlUneTension4.strValues.Split(';')[2]);

					unJour.soir2.sys = int.Parse("0" + ctlUneTension5.strValues.Split(';')[0]);
					unJour.soir2.dia = int.Parse("0" + ctlUneTension5.strValues.Split(';')[1]);
					unJour.soir2.pul = int.Parse("0" + ctlUneTension5.strValues.Split(';')[2]);

					unJour.soir3.sys = int.Parse("0" + ctlUneTension6.strValues.Split(';')[0]);
					unJour.soir3.dia = int.Parse("0" + ctlUneTension6.strValues.Split(';')[1]);
					unJour.soir3.pul = int.Parse("0" + ctlUneTension6.strValues.Split(';')[2]);
					ujt.sys1 = unJour.matin1.sys;
					ujt.dia1 = unJour.matin1.dia;
					ujt.pul1 = unJour.matin1.pul;
					ujt.moy1 = unJour.matin1.pul;

					ujt.sys2 = unJour.matin2.sys;
					ujt.dia2 = unJour.matin2.dia;
					ujt.pul2 = unJour.matin2.pul;
					ujt.moy2 = unJour.matin2.pul;

					ujt.sys3 = unJour.matin3.sys;
					ujt.dia3 = unJour.matin3.dia;
					ujt.pul3 = unJour.matin3.pul;
					ujt.moy3 = unJour.matin3.pul;

					ujt.sys4 = unJour.soir1.sys;
					ujt.dia4 = unJour.soir1.dia;
					ujt.pul4 = unJour.soir1.pul;
					ujt.moy4 = unJour.soir1.pul;

					ujt.sys5 = unJour.soir2.sys;
					ujt.dia5 = unJour.soir2.dia;
					ujt.pul5 = unJour.soir2.pul;
					ujt.moy5 = unJour.soir2.pul;

					ujt.sys6 = unJour.soir3.sys;
					ujt.dia6 = unJour.soir3.dia;
					ujt.pul6 = unJour.soir3.pul;
					ujt.moy6 = unJour.soir3.pul;

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				try
				{
					writer.Write(ujt);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void ctlUneTension4_Leave(object sender, EventArgs e)
		{
			strTension4 = ctlUneTension1.strValues;
		}

		private void ctlUneTension6_Leave(object sender, EventArgs e)
		{
			strTension6 = ctlUneTension3.strValues;
		}
	}
}
