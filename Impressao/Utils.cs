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
					case "A4":
						return Variables.pranchaPDF["A4"];
				}
			}
			else if (Variables.impressora == "Plotter-A2" || Variables.impressora == "Plotter-A1")
			{
			    switch (Variables.tamanhoFormato)
				{
					case "A0":
						return Variables.pranchaPlo["A0"];
					case "A1":
						return Variables.pranchaPlo["A1"];
					case "A2":
						return Variables.pranchaPlo["A2"];
					case "A3":
						return Variables.pranchaPlo["A3"];
					case "A4":
						return Variables.pranchaPlo["A4"];
				}
			}
			else
			{
			    switch (Variables.tamanhoFormato)
				{
					case "A3":
						return Variables.pranchaKy["A3"];
					case "A4":
						return Variables.pranchaKy["A4"];
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
                case "Kyocera-A4":
                    return Variables.tipoImpressora["Kyocera-A4"];
                default:
					return Variables.tipoImpressora["Kyocera-A3"];
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
