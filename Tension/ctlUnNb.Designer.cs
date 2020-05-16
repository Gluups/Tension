namespace Tension
{
	partial class ctlUnNb
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
			this.btnUp10 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btnDn10 = new System.Windows.Forms.Button();
			this.btnUp100 = new System.Windows.Forms.Button();
			this.btnDn100 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUp10
			// 
			this.btnUp10.Location = new System.Drawing.Point(11, 10);
			this.btnUp10.Margin = new System.Windows.Forms.Padding(2);
			this.btnUp10.Name = "btnUp10";
			this.btnUp10.Size = new System.Drawing.Size(30, 10);
			this.btnUp10.TabIndex = 2;
			this.btnUp10.TabStop = false;
			this.btnUp10.Text = "&e";
			this.btnUp10.UseVisualStyleBackColor = true;
			this.btnUp10.Click += new System.EventHandler(this.btnUp10_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(-1, 20);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(56, 32);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
			this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
			// 
			// btnDn10
			// 
			this.btnDn10.Location = new System.Drawing.Point(11, 39);
			this.btnDn10.Margin = new System.Windows.Forms.Padding(2);
			this.btnDn10.Name = "btnDn10";
			this.btnDn10.Size = new System.Drawing.Size(30, 12);
			this.btnDn10.TabIndex = 4;
			this.btnDn10.TabStop = false;
			this.btnDn10.Text = "&d";
			this.btnDn10.UseVisualStyleBackColor = true;
			this.btnDn10.Click += new System.EventHandler(this.btnDn10_Click);
			// 
			// btnUp100
			// 
			this.btnUp100.Location = new System.Drawing.Point(3, 0);
			this.btnUp100.Name = "btnUp100";
			this.btnUp100.Size = new System.Drawing.Size(50, 10);
			this.btnUp100.TabIndex = 5;
			this.btnUp100.TabStop = false;
			this.btnUp100.Text = "&p";
			this.btnUp100.UseVisualStyleBackColor = true;
			this.btnUp100.Click += new System.EventHandler(this.btnUp100_Click);
			// 
			// btnDn100
			// 
			this.btnDn100.Location = new System.Drawing.Point(2, 51);
			this.btnDn100.Name = "btnDn100";
			this.btnDn100.Size = new System.Drawing.Size(50, 10);
			this.btnDn100.TabIndex = 6;
			this.btnDn100.TabStop = false;
			this.btnDn100.Text = "&m";
			this.btnDn100.UseVisualStyleBackColor = true;
			this.btnDn100.Click += new System.EventHandler(this.btnDn100_Click);
			// 
			// ctlUnNb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnDn100);
			this.Controls.Add(this.btnUp100);
			this.Controls.Add(this.btnDn10);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.btnUp10);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ctlUnNb";
			this.Size = new System.Drawing.Size(63, 76);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUp10;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnDn10;
		private System.Windows.Forms.Button btnUp100;
		private System.Windows.Forms.Button btnDn100;
	}
}
