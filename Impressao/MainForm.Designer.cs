
namespace Impressao
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cbImprimeCotas;
		private System.Windows.Forms.ComboBox cbTamanhoFormato;
		private System.Windows.Forms.ComboBox cbEspessuraLayer;
		private System.Windows.Forms.ComboBox cbImpressora;
		private System.Windows.Forms.ComboBox cbDescricaoPDF;
		private System.Windows.Forms.ComboBox cbSalvarDesenhos;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.cbImprimeCotas = new System.Windows.Forms.ComboBox();
			this.cbTamanhoFormato = new System.Windows.Forms.ComboBox();
			this.cbEspessuraLayer = new System.Windows.Forms.ComboBox();
			this.cbImpressora = new System.Windows.Forms.ComboBox();
			this.cbDescricaoPDF = new System.Windows.Forms.ComboBox();
			this.cbSalvarDesenhos = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Imprimir \'cotas\'?";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tamanho do Formato";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Espessura do Layer";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Impressora";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Descrição nos PDFs?";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Salvar desenhos?";
			// 
			// button1
			// 
			this.button1.AllowDrop = true;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 196);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(207, 25);
			this.button1.TabIndex = 6;
			this.button1.Text = "Selecionar desenhos";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button1_DragDrop);
			this.button1.DragOver += new System.Windows.Forms.DragEventHandler(this.Button1_DragOver);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(119, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 25);
			this.button2.TabIndex = 8;
			this.button2.Text = "Imprimir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(12, 237);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 25);
			this.button3.TabIndex = 9;
			this.button3.Text = "Cancelar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// cbImprimeCotas
			// 
			this.cbImprimeCotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbImprimeCotas.DropDownHeight = 100;
			this.cbImprimeCotas.DropDownWidth = 60;
			this.cbImprimeCotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbImprimeCotas.FormattingEnabled = true;
			this.cbImprimeCotas.ImeMode = System.Windows.Forms.ImeMode.On;
			this.cbImprimeCotas.IntegralHeight = false;
			this.cbImprimeCotas.Items.AddRange(new object[] {
			"Sim",
			"Não"});
			this.cbImprimeCotas.Location = new System.Drawing.Point(134, 10);
			this.cbImprimeCotas.Name = "cbImprimeCotas";
			this.cbImprimeCotas.Size = new System.Drawing.Size(85, 21);
			this.cbImprimeCotas.TabIndex = 10;
			// 
			// cbTamanhoFormato
			// 
			this.cbTamanhoFormato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbTamanhoFormato.DropDownHeight = 100;
			this.cbTamanhoFormato.DropDownWidth = 60;
			this.cbTamanhoFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTamanhoFormato.FormattingEnabled = true;
			this.cbTamanhoFormato.ImeMode = System.Windows.Forms.ImeMode.On;
			this.cbTamanhoFormato.IntegralHeight = false;
			this.cbTamanhoFormato.Items.AddRange(new object[] {
			"A0",
			"A1",
			"A2",
			"A3",
			"A4"});
			this.cbTamanhoFormato.Location = new System.Drawing.Point(134, 40);
			this.cbTamanhoFormato.Name = "cbTamanhoFormato";
			this.cbTamanhoFormato.Size = new System.Drawing.Size(85, 21);
			this.cbTamanhoFormato.TabIndex = 11;
            this.cbTamanhoFormato.SelectedValueChanged += new System.EventHandler(this.cbTamanhoFormatoSelectedValueChanged);
            // 
            // cbEspessuraLayer
            // 
            this.cbEspessuraLayer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbEspessuraLayer.DropDownHeight = 100;
			this.cbEspessuraLayer.DropDownWidth = 60;
			this.cbEspessuraLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEspessuraLayer.FormattingEnabled = true;
			this.cbEspessuraLayer.ImeMode = System.Windows.Forms.ImeMode.On;
			this.cbEspessuraLayer.IntegralHeight = false;
			this.cbEspessuraLayer.Items.AddRange(new object[] {
			"100",
			"87.5",
			"75",
			"62.5",
			"50",
			"37.5",
			"25"});
			this.cbEspessuraLayer.Location = new System.Drawing.Point(134, 70);
			this.cbEspessuraLayer.Name = "cbEspessuraLayer";
			this.cbEspessuraLayer.Size = new System.Drawing.Size(85, 21);
			this.cbEspessuraLayer.TabIndex = 12;
			// 
			// cbImpressora
			// 
			this.cbImpressora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbImpressora.DropDownHeight = 100;
			this.cbImpressora.DropDownWidth = 60;
			this.cbImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbImpressora.FormattingEnabled = true;
			this.cbImpressora.ImeMode = System.Windows.Forms.ImeMode.On;
			this.cbImpressora.IntegralHeight = false;
			this.cbImpressora.Items.AddRange(new object[] {
			"Plotter-A2",
			"Plotter-A1",
			"PDF",
			"Kyocera-A4",
            "Kyocera-A3"});
            this.cbImpressora.Location = new System.Drawing.Point(134, 100);
			this.cbImpressora.Name = "cbImpressora";
			this.cbImpressora.Size = new System.Drawing.Size(85, 21);
			this.cbImpressora.TabIndex = 13;
			this.cbImpressora.SelectedValueChanged += new System.EventHandler(this.cbImpressoraSelectedValueChanged);
			// 
			// cbDescricaoPDF
			// 
			this.cbDescricaoPDF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbDescricaoPDF.DropDownHeight = 100;
			this.cbDescricaoPDF.DropDownWidth = 60;
			this.cbDescricaoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDescricaoPDF.FormattingEnabled = true;
			this.cbDescricaoPDF.ImeMode = System.Windows.Forms.ImeMode.On;
			this.cbDescricaoPDF.IntegralHeight = false;
			this.cbDescricaoPDF.Items.AddRange(new object[] {
			"Sim",
			"Não"});
			this.cbDescricaoPDF.Location = new System.Drawing.Point(134, 130);
			this.cbDescricaoPDF.Name = "cbDescricaoPDF";
			this.cbDescricaoPDF.Size = new System.Drawing.Size(85, 21);
			this.cbDescricaoPDF.TabIndex = 14;
			// 
			// cbSalvarDesenhos
			// 
			this.cbSalvarDesenhos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbSalvarDesenhos.DropDownHeight = 100;
			this.cbSalvarDesenhos.DropDownWidth = 55;
			this.cbSalvarDesenhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSalvarDesenhos.FormattingEnabled = true;
			this.cbSalvarDesenhos.ImeMode = System.Windows.Forms.ImeMode.On;
			this.cbSalvarDesenhos.IntegralHeight = false;
			this.cbSalvarDesenhos.ItemHeight = 13;
			this.cbSalvarDesenhos.Items.AddRange(new object[] {
			"Sim",
			"Não"});
			this.cbSalvarDesenhos.Location = new System.Drawing.Point(134, 160);
			this.cbSalvarDesenhos.Name = "cbSalvarDesenhos";
			this.cbSalvarDesenhos.Size = new System.Drawing.Size(85, 21);
			this.cbSalvarDesenhos.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button3;
			this.ClientSize = new System.Drawing.Size(230, 274);
			this.Controls.Add(this.cbSalvarDesenhos);
			this.Controls.Add(this.cbDescricaoPDF);
			this.Controls.Add(this.cbImpressora);
			this.Controls.Add(this.cbEspessuraLayer);
			this.Controls.Add(this.cbTamanhoFormato);
			this.Controls.Add(this.cbImprimeCotas);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Impressao";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResumeLayout(false);

		}
	}
}
