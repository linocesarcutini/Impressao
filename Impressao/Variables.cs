using System;
using System.Collections.Generic;

namespace Impressao
{
	public static class Variables
	{
		public static string  tamanhoFormato, espessuraLayer, impressora, salvarDesenhos;

		public static bool activation;

		public static string[] arquivos;

		public static Dictionary<string, string> pranchaPlo = new Dictionary<string, string>()
		{
			{ "A1", "\"ISO A1\"" },
			{ "A2", "\"ISO A2\"" }
		};

		public static Dictionary<string, string> pranchaXerox = new Dictionary<string, string>()
		{
            { "A4-L", "A4-L" },
            { "A4-P", "A4-P" }
		};

		public static Dictionary<string, string> tipoImpressora = new Dictionary<string, string>()
		{
			{ "Plotter-A2", "\"Canon_iPF670-A2\"" },
			{ "Plotter-A1", "\"Canon_iPF670-A1\"" },
			{ "Xerox", "\"Xerox\"" }
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
