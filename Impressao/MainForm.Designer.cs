
namespace Impressao
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BtnSelectDesenho;
		private System.Windows.Forms.Button BtnImprimir;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.ComboBox cbEspessuraLayer;
		private System.Windows.Forms.ComboBox cbImpressora;
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSelectDesenho = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.cbEspessuraLayer = new System.Windows.Forms.ComboBox();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.cbSalvarDesenhos = new System.Windows.Forms.ComboBox();
            this.cbImprimeCotas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDescricaoPDF = new System.Windows.Forms.ComboBox();
            this.cbTamanhoFormato = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho do Formato";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Espessura do Layer";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impressora";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salvar desenhos?";
            // 
            // BtnSelectDesenho
            // 
            this.BtnSelectDesenho.AllowDrop = true;
            this.BtnSelectDesenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectDesenho.Location = new System.Drawing.Point(13, 206);
            this.BtnSelectDesenho.Name = "BtnSelectDesenho";
            this.BtnSelectDesenho.Size = new System.Drawing.Size(207, 25);
            this.BtnSelectDesenho.TabIndex = 7;
            this.BtnSelectDesenho.Text = "Selecionar desenhos";
            this.BtnSelectDesenho.UseVisualStyleBackColor = true;
            this.BtnSelectDesenho.Click += new System.EventHandler(this.BtnSelectDesenhoClick);
            this.BtnSelectDesenho.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSelectDesenho_DragDrop);
            this.BtnSelectDesenho.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnSelectDesenho_DragOver);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(119, 237);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(100, 25);
            this.BtnImprimir.TabIndex = 8;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(12, 237);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 25);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
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
            this.cbEspessuraLayer.Location = new System.Drawing.Point(134, 53);
            this.cbEspessuraLayer.Name = "cbEspessuraLayer";
            this.cbEspessuraLayer.Size = new System.Drawing.Size(85, 21);
            this.cbEspessuraLayer.TabIndex = 2;
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
            "Xerox"});
            this.cbImpressora.Location = new System.Drawing.Point(134, 82);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(85, 21);
            this.cbImpressora.TabIndex = 3;
            this.cbImpressora.SelectedValueChanged += new System.EventHandler(this.cbImpressoraSelectedValueChanged);
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
            this.cbSalvarDesenhos.Location = new System.Drawing.Point(134, 111);
            this.cbSalvarDesenhos.Name = "cbSalvarDesenhos";
            this.cbSalvarDesenhos.Size = new System.Drawing.Size(85, 21);
            this.cbSalvarDesenhos.TabIndex = 4;
            // 
            // cbImprimeCotas
            // 
            this.cbImprimeCotas.FormattingEnabled = true;
            this.cbImprimeCotas.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbImprimeCotas.Location = new System.Drawing.Point(134, 138);
            this.cbImprimeCotas.Name = "cbImprimeCotas";
            this.cbImprimeCotas.Size = new System.Drawing.Size(85, 21);
            this.cbImprimeCotas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Imprimir cotas?";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descrição nos PDFs?";
            // 
            // cbDescricaoPDF
            // 
            this.cbDescricaoPDF.FormattingEnabled = true;
            this.cbDescricaoPDF.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbDescricaoPDF.Location = new System.Drawing.Point(134, 168);
            this.cbDescricaoPDF.Name = "cbDescricaoPDF";
            this.cbDescricaoPDF.Size = new System.Drawing.Size(85, 21);
            this.cbDescricaoPDF.TabIndex = 6;
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
            "A1",
            "A2",
            "A4-L",
            "A4-P"});
            this.cbTamanhoFormato.Location = new System.Drawing.Point(133, 22);
            this.cbTamanhoFormato.Name = "cbTamanhoFormato";
            this.cbTamanhoFormato.Size = new System.Drawing.Size(85, 21);
            this.cbTamanhoFormato.TabIndex = 1;
            this.cbTamanhoFormato.SelectedValueChanged += new System.EventHandler(this.cbTamanhoFormatoSelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(230, 274);
            this.Controls.Add(this.cbTamanhoFormato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDescricaoPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbImprimeCotas);
            this.Controls.Add(this.cbSalvarDesenhos);
            this.Controls.Add(this.cbImpressora);
            this.Controls.Add(this.cbEspessuraLayer);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnSelectDesenho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.ComboBox cbImprimeCotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDescricaoPDF;
        private System.Windows.Forms.ComboBox cbTamanhoFormato;
    }
}
