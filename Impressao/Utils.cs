using System;

namespace Impressao
{
	/// <summary>
	/// Description of Utils.
	/// </summary>
	public static class Utils
	{
		public static string TamanhoPrancha()
		{
			if (Variables.impressora == "PDF")
			{
				switch (Variables.tamanhoFormato)
				{
					case "A0":
						return Variables.pranchaPDF["A0"];
					case "A1":
						return Variables.pranchaPDF["A1"];
					case "A2":
						return Variables.pranchaPDF["A2"];
					case "A3":
						return Variables.pranchaPDF["A3"];
					case "A4-L":
						return Variables.pranchaPDF["A4-L"];
                    case "A4-P":
                        return Variables.pranchaPDF["A4-P"];
				}
			}
			else if (Variables.impressora == "Plotter-A2" || Variables.impressora == "Plotter-A1")
			{
			    switch (Variables.tamanhoFormato)
				{
					case "A1":
						return Variables.pranchaPlo["A1"];
					case "A2":
						return Variables.pranchaPlo["A2"];
				}
			}
			else
			{
			    switch (Variables.tamanhoFormato)
				{
					case "A4-L":
						return Variables.pranchaXerox["A4-L"];
					case "A4-P":
						return Variables.pranchaXerox["A4-P"];
				}
			}

			return string.Empty;
		}
		
		public static string Imp(string impress)
		{
			switch (impress)
			{
				case "Plotter-A2":
					return Variables.tipoImpressora["Plotter-A2"];
				case "Plotter-A1":
					return Variables.tipoImpressora["Plotter-A1"];
				case "PDF":
					return Variables.tipoImpressora["PDF"];
                default:
					return Variables.tipoImpressora["Xerox"];
			}
		}

		public static string Screening(string esp)
		{
			switch (esp)
			{
				case "100":
					return Variables.espessura["100"];
				case "87.5":
					return Variables.espessura["87.5"];
				case "75":
					return Variables.espessura["75"];
				case "62.5":
					return Variables.espessura["62.5"];
				case "50":
					return Variables.espessura["50"];
				case "37.5":
					return Variables.espessura["37.5"];
				case "25":
					return Variables.espessura["25"];
				default:
					return string.Empty;
			}
		}
	}
}
