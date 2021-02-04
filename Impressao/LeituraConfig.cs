using System;
using System.Configuration;

namespace Impressao
{
	public class LeituraConfig
	{
		public string descricaoNoPDF { get; set; }
		public string espessuraLayer { get; set; }
		public string impressora { get; set; }
		public string salvarDesenhos { get; set; }
		public string tamanhoFormato { get; set; }

		public LeituraConfig()
		{
			this.descricaoNoPDF = ConfigurationManager.ConnectionStrings["DescricaoNoPDF"].ConnectionString;
			this.espessuraLayer = ConfigurationManager.ConnectionStrings["EspessuraLayer"].ConnectionString;
			this.impressora = ConfigurationManager.ConnectionStrings["Impressora"].ConnectionString;
			this.salvarDesenhos = ConfigurationManager.ConnectionStrings["SalvarDesenhos"].ConnectionString;
			this.tamanhoFormato = ConfigurationManager.ConnectionStrings["TamanhoFormato"].ConnectionString;
		}
		
		public LeituraConfig(string _descricaoNoPDF, string _espessuraLayer, string _impressora, string _salvarDesenhos, string _tamanhoFormato)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.ConnectionStrings.ConnectionStrings["DescricaoNoPDF"].ConnectionString = _descricaoNoPDF;
			config.ConnectionStrings.ConnectionStrings["EspessuraLayer"].ConnectionString = _espessuraLayer;
			config.ConnectionStrings.ConnectionStrings["Impressora"].ConnectionString = _impressora;
			config.ConnectionStrings.ConnectionStrings["SalvarDesenhos"].ConnectionString = _salvarDesenhos;
			config.ConnectionStrings.ConnectionStrings["TamanhoFormato"].ConnectionString = _tamanhoFormato;

			config.Save(ConfigurationSaveMode.Modified);
		}
	}
}
