namespace Tension
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataSet11 = new Tension.DataSet1();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblMatin1 = new System.Windows.Forms.Label();
			this.lblMatin2 = new System.Windows.Forms.Label();
			this.lblMatin3 = new System.Windows.Forms.Label();
			this.lblSoir1 = new System.Windows.Forms.Label();
			this.lblSoir2 = new System.Windows.Forms.Label();
			this.lblSoir3 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.txbRec = new System.Windows.Forms.TextBox();
			this.ctlUneTension3 = new Tension.ctlUneTension();
			this.ctlUneTension2 = new Tension.ctlUneTension();
			this.ctlUneTension1 = new Tension.ctlUneTension();
			this.ctlUneTension6 = new Tension.ctlUneTension();
			this.ctlUneTension5 = new Tension.ctlUneTension();
			this.ctlUneTension4 = new Tension.ctlUneTension();
			this.btnAjout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(431, 33);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(309, 35);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// lblMatin1
			// 
			this.lblMatin1.AutoSize = true;
			this.lblMatin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatin1.Location = new System.Drawing.Point(65, 71);
			this.lblMatin1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblMatin1.Name = "lblMatin1";
			this.lblMatin1.Size = new System.Drawing.Size(90, 29);
			this.lblMatin1.TabIndex = 1;
			this.lblMatin1.Text = "Matin 1";
			// 
			// lblMatin2
			// 
			this.lblMatin2.AutoSize = true;
			this.lblMatin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatin2.Location = new System.Drawing.Point(384, 71);
			this.lblMatin2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblMatin2.Name = "lblMatin2";
			this.lblMatin2.Size = new System.Drawing.Size(90, 29);
			this.lblMatin2.TabIndex = 3;
			this.lblMatin2.Text = "Matin 2";
			// 
			// lblMatin3
			// 
			this.lblMatin3.AutoSize = true;
			this.lblMatin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatin3.Location = new System.Drawing.Point(679, 71);
			this.lblMatin3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblMatin3.Name = "lblMatin3";
			this.lblMatin3.Size = new System.Drawing.Size(90, 29);
			this.lblMatin3.TabIndex = 5;
			this.lblMatin3.Text = "Matin 3";
			// 
			// lblSoir1
			// 
			this.lblSoir1.AutoSize = true;
			this.lblSoir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoir1.Location = new System.Drawing.Point(77, 347);
			this.lblSoir1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblSoir1.Name = "lblSoir1";
			this.lblSoir1.Size = new System.Drawing.Size(76, 29);
			this.lblSoir1.TabIndex = 7;
			this.lblSoir1.Text = "Soir 1";
			// 
			// lblSoir2
			// 
			this.lblSoir2.AutoSize = true;
			this.lblSoir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoir2.Location = new System.Drawing.Point(384, 347);
			this.lblSoir2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblSoir2.Name = "lblSoir2";
			this.lblSoir2.Size = new System.Drawing.Size(76, 29);
			this.lblSoir2.TabIndex = 9;
			this.lblSoir2.Text = "Soir 2";
			// 
			// lblSoir3
			// 
			this.lblSoir3.AutoSize = true;
			this.lblSoir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoir3.Location = new System.Drawing.Point(679, 347);
			this.lblSoir3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblSoir3.Name = "lblSoir3";
			this.lblSoir3.Size = new System.Drawing.Size(76, 29);
			this.lblSoir3.TabIndex = 11;
			this.lblSoir3.Text = "Soir 3";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(1097, 12);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 28);
			this.btnOK.TabIndex = 13;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.CausesValidation = false;
			this.hScrollBar1.LargeChange = 1;
			this.hScrollBar1.Location = new System.Drawing.Point(12, 595);
			this.hScrollBar1.Maximum = 2;
			this.hScrollBar1.Minimum = 1;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(937, 26);
			this.hScrollBar1.TabIndex = 14;
			this.hScrollBar1.Value = 1;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// txbRec
			// 
			this.txbRec.Location = new System.Drawing.Point(328, 624);
			this.txbRec.Name = "txbRec";
			this.txbRec.Size = new System.Drawing.Size(100, 35);
			this.txbRec.TabIndex = 15;
			this.txbRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ctlUneTension3
			// 
			this.ctlUneTension3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlUneTension3.Location = new System.Drawing.Point(629, 93);
			this.ctlUneTension3.Margin = new System.Windows.Forms.Padding(2);
			this.ctlUneTension3.Name = "ctlUneTension3";
			this.ctlUneTension3.Size = new System.Drawing.Size(306, 193);
			this.ctlUneTension3.TabIndex = 6;
			this.ctlUneTension3.Leave += new System.EventHandler(this.ctlUneTension6_Leave);
			// 
			// ctlUneTension2
			// 
			this.ctlUneTension2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlUneTension2.Location = new System.Drawing.Point(319, 93);
			this.ctlUneTension2.Margin = new System.Windows.Forms.Padding(2);
			this.ctlUneTension2.Name = "ctlUneTension2";
			this.ctlUneTension2.Size = new System.Drawing.Size(305, 193);
			this.ctlUneTension2.TabIndex = 4;
			// 
			// ctlUneTension1
			// 
			this.ctlUneTension1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlUneTension1.Location = new System.Drawing.Point(12, 93);
			this.ctlUneTension1.Margin = new System.Windows.Forms.Padding(2);
			this.ctlUneTension1.Name = "ctlUneTension1";
			this.ctlUneTension1.Size = new System.Drawing.Size(302, 193);
			this.ctlUneTension1.TabIndex = 2;
			this.ctlUneTension1.Leave += new System.EventHandler(this.ctlUneTension4_Leave);
			// 
			// ctlUneTension6
			// 
			this.ctlUneTension6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlUneTension6.Location = new System.Drawing.Point(629, 369);
			this.ctlUneTension6.Margin = new System.Windows.Forms.Padding(2);
			this.ctlUneTension6.Name = "ctlUneTension6";
			this.ctlUneTension6.Size = new System.Drawing.Size(306, 187);
			this.ctlUneTension6.TabIndex = 12;
			// 
			// ctlUneTension5
			// 
			this.ctlUneTension5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlUneTension5.Location = new System.Drawing.Point(319, 369);
			this.ctlUneTension5.Margin = new System.Windows.Forms.Padding(2);
			this.ctlUneTension5.Name = "ctlUneTension5";
			this.ctlUneTension5.Size = new System.Drawing.Size(305, 187);
			this.ctlUneTension5.TabIndex = 10;
			// 
			// ctlUneTension4
			// 
			this.ctlUneTension4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlUneTension4.Location = new System.Drawing.Point(11, 369);
			this.ctlUneTension4.Margin = new System.Windows.Forms.Padding(2);
			this.ctlUneTension4.Name = "ctlUneTension4";
			this.ctlUneTension4.Size = new System.Drawing.Size(303, 187);
			this.ctlUneTension4.TabIndex = 8;
			// 
			// btnAjout
			// 
			this.btnAjout.Image = ((System.Drawing.Image)(resources.GetObject("btnAjout.Image")));
			this.btnAjout.Location = new System.Drawing.Point(1034, 235);
			this.btnAjout.Name = "btnAjout";
			this.btnAjout.Size = new System.Drawing.Size(127, 98);
			this.btnAjout.TabIndex = 16;
			this.btnAjout.Text = "Nouveau";
			this.btnAjout.UseVisualStyleBackColor = true;
			this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 660);
			this.Controls.Add(this.btnAjout);
			this.Controls.Add(this.txbRec);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.ctlUneTension3);
			this.Controls.Add(this.ctlUneTension2);
			this.Controls.Add(this.ctlUneTension1);
			this.Controls.Add(this.ctlUneTension6);
			this.Controls.Add(this.ctlUneTension5);
			this.Controls.Add(this.ctlUneTension4);
			this.Controls.Add(this.lblSoir3);
			this.Controls.Add(this.lblSoir2);
			this.Controls.Add(this.lblSoir1);
			this.Controls.Add(this.lblMatin3);
			this.Controls.Add(this.lblMatin2);
			this.Controls.Add(this.lblMatin1);
			this.Controls.Add(this.dateTimePicker1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.Text = "Tension artérielle";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet1 dataSet11;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lblMatin1;
		private System.Windows.Forms.Label lblMatin2;
		private System.Windows.Forms.Label lblMatin3;
		private System.Windows.Forms.Label lblSoir1;
		private System.Windows.Forms.Label lblSoir2;
		private System.Windows.Forms.Label lblSoir3;
		private ctlUneTension ctlUneTension4;
		private ctlUneTension ctlUneTension5;
		private ctlUneTension ctlUneTension6;
		private ctlUneTension ctlUneTension1;
		private ctlUneTension ctlUneTension2;
		private ctlUneTension ctlUneTension3;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.TextBox txbRec;
		private System.Windows.Forms.Button btnAjout;
	}
}

