using System;
using System.Collections.Generic;

namespace Impressao
{
	public static class Variables
	{
		public static string imprimeCotas, tamanhoFormato, espessuraLayer, impressora,
			diretorioPDF, salvarDesenhos, description;

		public static bool activation;

		public static string[] arquivos;

		public static Dictionary<string, string> pranchaPDF = new Dictionary<string, string>()
		{
			{ "A0", "\"iso full bleed A0 (841.00 x 1189.00 MM)\"" },
			{ "A1", "\"iso full bleed A1 (841.00 x 594.00 MM)\"" },
			{ "A2", "\"iso full bleed A2 (594.00 x 420.00 MM)\"" },
			{ "A3", "\"iso full bleed A3 (420.00 x 297.00 MM)\"" },
			{ "A4-L", "\"iso full bleed A4 (297.00 x 210.00 MM)\"" },
            { "A4-P", "\"iso full bleed A4 (210.00 x 297.00 MM)\"" }
        };

		public static Dictionary<string, string> pranchaPlo = new Dictionary<string, string>()
		{
			{ "A1", "\"ISO A1\"" }, { "A2", "\"ISO A2\"" },
			{ "A3", "\"ISO A3\"" }, { "A4", "\"ISO A4\"" }
		};

		public static Dictionary<string, string> pranchaKy = new Dictionary<string, string>()
		{
			{ "A3", "\"A3\"" },
            { "A4-L", "\"A4-L\"" },
            { "A4-P", "\"A4-P\"" }
		};

		public static Dictionary<string, string> tipoImpressora = new Dictionary<string, string>()
		{
			{ "Plotter-A2", "\"Canon_iPF670-A2\"" },
			{ "Plotter-A1", "\"Canon_iPF670-A1\"" },
			{ "PDF", "\"DWG To PDF\"" },
			{ "Kyocera-A4", "\"Kyocera-A4\"" },
            { "Kyocera-A3", "\"Kyocera-A3\"" }
        };

		public static Dictionary<string, string> espessura = new Dictionary<string, string>()
		{
			{ "100","\"Engetower 100%.ctb\"" },
			{ "87.5","\"Engetower 87.5%.ctb\"" },
			{ "75","\"Engetower 75%.ctb\"" },
			{ "62.5","\"Engetower 62.5%.ctb\"" },
			{ "50","\"Engetower 50%.ctb\"" },
			{ "37.5","\"Engetower 37.5%.ctb\"" },
			{ "25","\"Engetower 25%.ctb\"" }
		};
	}
}
