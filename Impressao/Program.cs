using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Impressao
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			List<string> arq = new List<string>();
			bool format = true;

			for (int i = 0; i < args.Length; i++)
			{
				if (Path.GetExtension(args[i]) == ".dwg")
				{
					arq.Add(args[i]);
				}
				else
					format = false;
			}
			
			if (!format)
		    	MessageBox.Show("Apenas arquivos 'DWG' serão impressos!");

			arq.Sort();
			Variables.arquivos = arq.ToArray();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

			LeituraConfig escrita = new LeituraConfig(Variables.description, Variables.espessuraLayer, Variables.impressora,
				                                      Variables.imprimeCotas, Variables.salvarDesenhos, Variables.tamanhoFormato);
		}
	}
}
