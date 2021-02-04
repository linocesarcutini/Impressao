using System;
using System.IO;
using System.Windows.Forms;
using Autodesk.AutoCAD.Interop;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Interop.Common;

namespace Impressao
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			LeituraConfig leitura = new LeituraConfig();
			
			cbEspessuraLayer.SelectedItem = leitura.espessuraLayer;
			cbImpressora.SelectedItem = leitura.impressora;
			cbSalvarDesenhos.SelectedItem = leitura.salvarDesenhos;
			cbTamanhoFormato.SelectedItem = leitura.tamanhoFormato;

			Variables.espessuraLayer = leitura.espessuraLayer;
			Variables.impressora = leitura.impressora;
			Variables.salvarDesenhos = leitura.salvarDesenhos;
			Variables.tamanhoFormato = leitura.tamanhoFormato;
		}

		private void Button1Click(object sender, EventArgs e)
		{
			// Selecionar os arquivos a serem impressos
			OpenFileDialog openFileDialog1 = new OpenFileDialog()
			{
				Filter = "AutoCAD Files|*.dwg",
				Title = "Selecione os arquivos a serem impressos",
				Multiselect = true,
				RestoreDirectory = true
			};

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Guarda a lista dos caminhos completos dos arquivos selecionados
				Variables.arquivos = openFileDialog1.FileNames;
			}
			else
			{
				MessageBox.Show("Os desenhos não foram selecionados!");
			}
		}
		
		private void Button1_DragOver(object sender, DragEventArgs e)
		{
		    if (e.Data.GetDataPresent(DataFormats.FileDrop))
		        e.Effect = DragDropEffects.Link;
		    else
		        e.Effect = DragDropEffects.None;
		}
		
		private void Button1_DragDrop(object sender, DragEventArgs e)
		{
		    string[] arquivos = e.Data.GetData(DataFormats.FileDrop) as string[];
		    
			bool format = true;
		    List<string> arq = new List<string>();
		    foreach (var element in arquivos)
		    {
		    	if (Path.GetExtension(element).ToLower() == ".dwg")
                {
					arq.Add(element);
                }
		    	else
		    	{
					format = false;
		    	}
		    }
		    
		    if (!format)
		    	MessageBox.Show("Apenas arquivos 'DWG' serão impressos!");

			Variables.arquivos = arq.ToArray();
		}

		private void Button2Click(object sender, EventArgs e)
		{
			if (Variables.arquivos == null)
			{
				SetVariables();

				MessageBox.Show("Os documentos não foram selecionados!");
			}
			else
			{
				SetVariables();

				string progId = "AutoCAD.Application";
				dynamic acApp = null;
	
				try
				{
					acApp = Marshal.GetActiveObject(progId);
				}
				catch
				{
					try
					{
						Type t = Type.GetTypeFromProgID(progId);
						acApp = Activator.CreateInstance(t);
	
						if (acApp != null)
							acApp.Visible = true;
					}
					catch
					{
						MessageBox.Show("Não possível abrir o AutoCAD!");
					}
				}
	 
				int contDesenho = 1;

				foreach (var element in Variables.arquivos)
				{
					System.Threading.Thread.Sleep(2500);

					AcadDocument doc = null;
					doc = acApp.Documents.Open(element);
					AcadModelSpace modelSpace = doc.ModelSpace;

                    // For saiving PDF with or without description
                        // Criando a pasta ImpressaoEmPDF caso não exista
                    if (!Directory.Exists("C:/Users/" + Environment.UserName + "/Documents/ImpressaoEmPDF/"))
                    {
                        Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Documents/ImpressaoEmPDF/");
                    }

                    string fileName = Path.GetFileName(element);
					string newFullNameWithoutExtension = "C:/Users/" + Environment.UserName + "/Documents/ImpressaoEmPDF/" +
					                                     fileName.Substring(0, fileName.Length - 4);
					string newFullNameWithoutDescription = "C:/Users/" + Environment.UserName + "/Documents/ImpressaoEmPDF/" +
					                                       fileName.Split(new string[] { "..." }, StringSplitOptions.None)[0];
	
					if (Variables.impressora == "PDF")
					{
						MessageBox.Show("PDF feito com sucesso");
					}
					else
					{
						try
						{
							string teste = Utils.Imp(Variables.impressora);
							doc.SendCommand("(command \"-plot\"" +
								" \"Y\" \"model\" " + teste + " " +
								Utils.TamanhoPrancha() +
								" \"m\" \"l\" \"n\" \"e\" \"f\" \"c\" \"y\" " +
								Utils.Screening(Variables.espessuraLayer) + " \"y\" \"a\" \"n\" \"n\" \"y\" princ)\n"
							);
						}
						catch (Exception)
						{
							MessageBox.Show("Não foi possível enviar o comando de plotar na Impressora (PL/KM)!");
						}
					}
	
					if (Variables.salvarDesenhos == "Sim")
					{
						try
						{
							doc.SendCommand("(command \"-layer\" \"on\" \"COTAS\" \"\" princ)\n");
							doc.SendCommand("(command \"-layer\" \"on\" \"L.D.\" \"\" princ)\n");
							doc.SendCommand("(command \"-layer\" \"set\" \"0\" \"\" princ)\n");
							doc.SendCommand("(command \"-purge\" \"r\" \"*\" \"n\" princ)\n");
							doc.SendCommand("(command \"-purge\" \"e\" princ)\n");
							doc.SendCommand("(command \"-purge\" \"o\" princ)\n");
							acApp.ZoomExtents();
							doc.PurgeAll();
							doc.Save();
							doc.Close();
						}
						catch (Exception)
						{
							MessageBox.Show("Não foi possível enviar os comandos de purge e ativar Layer!");
						}
					}
					else
						doc.Close(null);
	
					contDesenho++;
				}
			}
		}

		private void Button3Click(object sender, EventArgs e)
		{
			SetVariables();

			Close();
			Application.Exit();
		}

		private void MainForm_FormClosing(object sender, EventArgs e)
		{
			SetVariables();
		}
		
		private void SetVariables()
		{
			Variables.espessuraLayer = this.cbEspessuraLayer.SelectedItem.ToString();
			Variables.impressora = this.cbImpressora.SelectedItem.ToString();
			Variables.tamanhoFormato = this.cbTamanhoFormato.SelectedItem.ToString();
		}

		private void cbImpressoraSelectedValueChanged(object sender, EventArgs e)
		{
			switch (cbImpressora.Text)
			{
				case "Plotter-A2":
					cbTamanhoFormato.SelectedItem = "A2";
					break;
				case "Plotter-A1":
					cbTamanhoFormato.SelectedItem = "A1";
					break;
                case "Kyocera-A4-P":
                    cbTamanhoFormato.SelectedItem = "A4-P";
                    break;
                case "Kyocera-A4-L":
                    cbTamanhoFormato.SelectedItem = "A4-L";
                    break;
                case "Kyocera-A3":
                    cbTamanhoFormato.SelectedItem = "A3";
                    break;
            }
		}

        private void cbTamanhoFormatoSelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbTamanhoFormato.Text)
            {
                case "A2":
                    cbImpressora.SelectedItem = "Plotter-A2";
                    break;
                case "A1":
                    cbImpressora.SelectedItem = "Plotter-A1";
                    break;
                case "Kyocera-A4-P":
                    cbTamanhoFormato.SelectedItem = "A4-P";
                    break;
                case "Kyocera-A4-L":
                    cbTamanhoFormato.SelectedItem = "A4-L";
                    break;
                case "A3":
                    cbImpressora.SelectedItem = "Kyocera-A3";
                    break;
            }
        }
    }
}
