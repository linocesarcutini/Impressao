using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Win32;

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
            RegistryKey autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD");
            string autocadCurver = null;
            string[] VersoesAutocad = { "R22.0" , "R23.0", "R23.1" };
            object autocadLang = autocad.GetValue("CurVer");
            int versao = 0; 

            for (int i = 0; i < VersoesAutocad.Length; i++)
            {
                autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + VersoesAutocad[i] + @"\", false);
                if (autocad != null)
                {
                    autocadCurver = VersoesAutocad[i];
                    autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + autocadCurver + @"\");
                    autocadLang = autocad.GetValue("CurVer");

                    switch (autocadLang)
                    {
                        case "ACAD-1001:409":
                            versao = 2018;
                            autocadCurver = "R22.0";
                            break;
                        case "ACAD-2001:409":
                            versao = 2019;
                            autocadCurver = "R23.0";
                            break;
                        case "ACAD-3026:409":
                            versao = 2020;
                            autocadCurver = "R23.1";
                            break;
                        default:
                            MessageBox.Show("Versão incompatível com o software");
                            Application.Exit();
                            break;
                    }
                    autocad = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD\" + autocadCurver + @"\");
                    if (autocadLang.Equals(autocad.GetValue("CurVer")))
                    {
                        break;
                    }
                    else { }
                }
                else
                {
                }
            }




            MessageBox.Show(autocadLang + "; versão: " + versao);

            List<string> arq = new List<string>();
            bool format = true;

            for (int i = 0; i < args.Length; i++)
            {
                if (Path.GetExtension(args[i]).ToLower() == ".dwg")
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

            LeituraConfig escrita = new LeituraConfig(Variables.espessuraLayer, Variables.impressora, Variables.salvarDesenhos, Variables.tamanhoFormato);
        }
    }
}
