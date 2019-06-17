using System;
using Microsoft.Win32;

namespace Impressao
{
	/// <summary>
	/// Description of Activation.
	/// </summary>
	public class Activation
	{
		public Activation()
		{
			string activation = null;
			string autoCadVersion1 = null;
			string codAutoCAD = null;
			string activation1 = null;

			RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\Fuleragem", false);
			try
			{
				activation = rk.GetValue("1").ToString();
			}
			catch (Exception)
			{
				activation = null;
			}

			RegistryKey rk1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD", false);

			try
			{
				autoCadVersion1 = rk1.GetValue("CurVer").ToString();
				rk1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + autoCadVersion1, false);
				codAutoCAD = rk1.GetValue("CurVer").ToString();
			}
			catch (Exception)
			{
				Console.WriteLine("Seu computador não possui o AutoCAD instalado!");
			}

			try
			{
				activation1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + autoCadVersion1 + "\\" +
					codAutoCAD + "\\Applications", false).GetValue("1").ToString();
			}
			catch (Exception)
			{
				activation1 = null;
			}

			if (activation == "1" || activation1 == "1")
			{
				Variables.activation = true;
			}
			else
			{
				Variables.activation = false;
				Console.WriteLine("Esta API não está ativada. Procure o desenvolvedor!");
			}
		}
	}
}
