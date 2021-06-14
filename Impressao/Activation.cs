using System;
using Microsoft.Win32;

namespace Impressao
{
	/// <summary>
	/// Description of Activation.
	/// </summary>
	public class Activation
	{
        public static bool Ativacao()
        {
            bool ativacao = true;
            object autocadAtiv;

            try
            {
                RegistryKey autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\");
                object autocadCurver = autocad.GetValue("CurVer");
                autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + autocadCurver + @"\");
                object autocadLang = autocad.GetValue("CurVer");
                autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + autocadCurver +
                    @"\" + autocadLang + @"\Applications\");
                autocadAtiv = autocad.GetValue("1");

            }
            catch (System.Exception)
            {
                ativacao = false;
                throw;
            }

            if (autocadAtiv == null)
            {
                ativacao = false;
            }

            return ativacao;
        }
    }
}
