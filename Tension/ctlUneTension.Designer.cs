namespace Tension
{
	partial class ctlUneTension
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblSys = new System.Windows.Forms.Label();
			this.lblDIA = new System.Windows.Forms.Label();
			this.lblPUL = new System.Windows.Forms.Label();
			this.ctlUnNb3 = new Tension.ctlUnNb();
			this.ctlUnNb2 = new Tension.ctlUnNb();
			this.ctlUnNb1 = new Tension.ctlUnNb();
			this.SuspendLayout();
			// 
			// lblSys
			// 
			this.lblSys.AutoSize = true;
			this.lblSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSys.Location = new System.Drawing.Point(16, 22);
			this.lblSys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSys.Name = "lblSys";
			this.lblSys.Size = new System.Drawing.Size(42, 20);
			this.lblSys.TabIndex = 3;
			this.lblSys.Text = "SYS";
			// 
			// lblDIA
			// 
			this.lblDIA.AutoSize = true;
			this.lblDIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDIA.Location = new System.Drawing.Point(83, 22);
			this.lblDIA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDIA.Name = "lblDIA";
			this.lblDIA.Size = new System.Drawing.Size(37, 20);
			this.lblDIA.TabIndex = 4;
			this.lblDIA.Text = "DIA";
			// 
			// lblPUL
			// 
			this.lblPUL.AutoSize = true;
			this.lblPUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPUL.Location = new System.Drawing.Point(145, 22);
			this.lblPUL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPUL.Name = "lblPUL";
			this.lblPUL.Size = new System.Drawing.Size(40, 20);
			this.lblPUL.TabIndex = 5;
			this.lblPUL.Text = "PUL";
			// 
			// ctlUnNb3
			// 
			this.ctlUnNb3.Location = new System.Drawing.Point(137, 43);
			this.ctlUnNb3.Margin = new System.Windows.Forms.Padding(1);
			this.ctlUnNb3.Name = "ctlUnNb3";
			this.ctlUnNb3.Size = new System.Drawing.Size(59, 70);
			this.ctlUnNb3.TabIndex = 2;
			this.ctlUnNb3.Leave += new System.EventHandler(this.ctlUnNb3_Leave);
			// 
			// ctlUnNb2
			// 
			this.ctlUnNb2.Location = new System.Drawing.Point(73, 43);
			this.ctlUnNb2.Margin = new System.Windows.Forms.Padding(1);
			this.ctlUnNb2.Name = "ctlUnNb2";
			this.ctlUnNb2.Size = new System.Drawing.Size(59, 70);
			this.ctlUnNb2.TabIndex = 1;
			this.ctlUnNb2.Leave += new System.EventHandler(this.ctlUnNb2_Leave);
			this.ctlUnNb2.Validating += new System.ComponentModel.CancelEventHandler(this.ctlUnNb2_Validating);
			// 
			// ctlUnNb1
			// 
			this.ctlUnNb1.Location = new System.Drawing.Point(11, 43);
			this.ctlUnNb1.Margin = new System.Windows.Forms.Padding(1);
			this.ctlUnNb1.Name = "ctlUnNb1";
			this.ctlUnNb1.Size = new System.Drawing.Size(59, 70);
			this.ctlUnNb1.TabIndex = 0;
			this.ctlUnNb1.Leave += new System.EventHandler(this.ctlUnNb1_Leave);
			// 
			// ctlUneTension
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lblPUL);
			this.Controls.Add(this.lblDIA);
			this.Controls.Add(this.lblSys);
			this.Controls.Add(this.ctlUnNb3);
			this.Controls.Add(this.ctlUnNb2);
			this.Controls.Add(this.ctlUnNb1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ctlUneTension";
			this.Size = new System.Drawing.Size(195, 113);
			this.Leave += new System.EventHandler(this.ctlUneTension_Leave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ctlUnNb ctlUnNb1;
		private ctlUnNb ctlUnNb2;
		private ctlUnNb ctlUnNb3;
		private System.Windows.Forms.Label lblSys;
		private System.Windows.Forms.Label lblDIA;
		private System.Windows.Forms.Label lblPUL;
	}
}
