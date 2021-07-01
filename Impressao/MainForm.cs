using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;


namespace Impressao
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LeituraConfig leitura = new LeituraConfig();

            cbDescricaoPDF.SelectedItem = leitura.descricaoNoPDF;
            cbEspessuraLayer.SelectedItem = leitura.espessuraLayer;
            cbImpressora.SelectedItem = leitura.impressora;
            cbImprimeCotas.SelectedItem = leitura.imprimeCotas;
            cbSalvarDesenhos.SelectedItem = leitura.salvarDesenhos;
            cbTamanhoFormato.SelectedItem = leitura.tamanhoFormato;


            if (leitura.tagPadrao.ToLower() == "mineiro")
            {
                leitura.tagPadrao = "Mineiro";
                rdBtnMineiro.Checked = true;
            }
            else
            {
                leitura.tagPadrao = "Brametal";
                rdBtnBrametal.Checked = true;
            }

            Variables.description = leitura.descricaoNoPDF;
            Variables.espessuraLayer = leitura.espessuraLayer;
            Variables.impressora = leitura.impressora;
            Variables.imprimeCotas = leitura.imprimeCotas;
            Variables.salvarDesenhos = leitura.salvarDesenhos;
            Variables.tamanhoFormato = leitura.tamanhoFormato;
            Variables.tagPadrao = leitura.tagPadrao;
        }

        private void BtnSelectDesenhoClick(object sender, EventArgs e)
        {
            // Selecionar os arquivos a serem impressos
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "AutoCAD Files|*.dwg",
                Title = "Selecione os arquivos a serem impressos",
                Multiselect = true,
                RestoreDirectory = true
            };

            Variables.arquivos = null;

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

        private void BtnSelectDesenho_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void BtnSelectDesenho_DragDrop(object sender, DragEventArgs e)
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

        private void BtnImprimirClick(object sender, EventArgs e)
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
                                                         fileName.Substring(0, fileName.LastIndexOf("."));
                    string newFullNameWithoutDescription = "C:/Users/" + Environment.UserName + "/Documents/ImpressaoEmPDF/" +
                                                           newFullNameWithoutExtension.Split(new string[] { "..." }, StringSplitOptions.None)[0];

                    if (Variables.impressora == "PDF")
                    {
                        if (Variables.description == "Sim")
                        {
                            if (Variables.tamanhoFormato == "A4-P")
                            {
                                try
                                {
                                    doc.SendCommand("(command \"-plot\"" +
                                        " \"Y\" \"model\" " + Utils.Imp(Variables.impressora) + " " +
                                        Utils.TamanhoPrancha() +
                                        " \"m\" \"p\" \"n\" \"e\" \"f\" \"c\" \"y\" " +
                                        Utils.Screening(Variables.espessuraLayer) + " \"y\" \"As displayed\" " +
                                        "\"" + newFullNameWithoutExtension + "\"" +
                                        " \"n\" \"y\")\n"
                                    );
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Não foi possível enviar o comando de plotar em PDF!");
                                }
                            }
                            else
                            {
                                try
                                {
                                    doc.SendCommand("(command \"-plot\"" +
                                        " \"Y\" \"model\" " + Utils.Imp(Variables.impressora) + " " +
                                        Utils.TamanhoPrancha() +
                                        " \"m\" \"l\" \"n\" \"e\" \"f\" \"c\" \"y\" " +
                                        Utils.Screening(Variables.espessuraLayer) + " \"y\" \"As displayed\" " +
                                        "\"" + newFullNameWithoutExtension + "\"" +
                                        " \"n\" \"y\")\n"
                                    );
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Não foi possível enviar o comando de plotar em PDF!");
                                }
                            }
                        }
                        else
                        {
                            if (Variables.tamanhoFormato == "A4-P")
                            {
                                try
                                {
                                    doc.SendCommand("(command \"-plot\"" +
                                        " \"Y\" \"model\" " + Utils.Imp(Variables.impressora) + " " +
                                        Utils.TamanhoPrancha() +
                                        " \"m\" \"p\" \"n\" \"e\" \"f\" \"c\" \"y\" " +
                                        Utils.Screening(Variables.espessuraLayer) + " \"y\" \"As displayed\" " +
                                        "\"" + newFullNameWithoutDescription + "\"" +
                                        " \"n\" \"y\")\n"
                                    );
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Não foi possível enviar o comando de plotar em PDF!");
                                }
                            }
                            else
                            {
                                try
                                {
                                    doc.SendCommand("(command \"-plot\"" +
                                        " \"Y\" \"model\" " + Utils.Imp(Variables.impressora) + " " +
                                        Utils.TamanhoPrancha() +
                                        " \"m\" \"l\" \"n\" \"e\" \"f\" \"c\" \"y\" " +
                                        Utils.Screening(Variables.espessuraLayer) + " \"y\" \"As displayed\" " +
                                        "\"" + newFullNameWithoutDescription + " \"" +
                                        " \"n\" \"y\")\n"
                                    );
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Não foi possível enviar o comando de plotar em PDF!");
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            string impressora = Utils.Imp(Variables.impressora);
                            string TamanhoPrancha = Utils.TamanhoPrancha();
                            string formato, Folha = "\"A4\"";

                            switch (TamanhoPrancha)
                            {
                                case "A4-L":
                                    Folha = "\"A4\"";
                                    formato = "\"l\"";
                                    break;

                                case "A4-P":
                                    Folha = "\"A4\"";
                                    formato = "\"p\"";
                                    break;

                                case "\"ISO A1\"":
                                    Folha = "\"ISO A1\"";
                                    formato = "\"l\"";
                                    break;
                                default:
                                    Folha = "\"ISO A2\"";
                                    formato = "\"l\"";
                                    break;
                            }
                            doc.SendCommand("(command \"-plot\"" +
                                " \"Y\" \"model\" " + impressora + " " +
                                Folha +
                                " \"m\" " + formato + " \"n\" \"e\" \"f\" \"c\" \"y\" " +
                                Utils.Screening(Variables.espessuraLayer) + " \"y\" \"a\" \"n\" \"n\" \"y\" princ)\n"
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível enviar o comando de plotar na Impressora (PL/KM)!");
                        }
                    }

                    if (Variables.salvarDesenhos == "Sim")
                    {
                        try
                        {
                            foreach (AcadLayer item in doc.Layers)
                            {
                                string NomeItem = item.Name;
                                if (NomeItem.ToLower() == "cotas")
                                {
                                            doc.SendCommand("(command \"-layer\" \"on\" \"COTAS\" \"\" princ)\n");
                                }
                                if (NomeItem.ToLower() == "l.d.")
                                {
                                            doc.SendCommand("(command \"-layer\" \"on\" \"L.D.\" \"\" princ)\n");
                                }
                            }
                            doc.SendCommand("(command \"-layer\" \"set\" \"0\" \"\" princ)\n");
                            doc.SendCommand("(command \"-purge\" \"r\" \"*\" \"n\" princ)\n");
                            doc.SendCommand("(command \"-purge\" \"e\" princ)\n");
                            doc.SendCommand("(command \"-purge\" \"o\" princ)\n");
                            acApp.ZoomExtents();
                            doc.PurgeAll();
                            doc.Save();
                            doc.Close();
                        }
                        catch (Exception ex)
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

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            SetVariables();

            Close();
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            SetVariables();
        }

        private void SetVariables()
        {
            Variables.description = this.cbDescricaoPDF.SelectedItem.ToString();
            Variables.espessuraLayer = this.cbEspessuraLayer.SelectedItem.ToString();
            Variables.impressora = this.cbImpressora.SelectedItem.ToString();
            Variables.imprimeCotas = this.cbImprimeCotas.SelectedItem.ToString();
            Variables.tamanhoFormato = this.cbTamanhoFormato.Text;
            Variables.salvarDesenhos = this.cbSalvarDesenhos.SelectedItem.ToString();
            Variables.tagPadrao = this.rdBtnMineiro.Checked == true ? "Mineiro" : "Brametal";
        }

        private void cbImpressoraSelectedValueChanged(object sender, EventArgs e)
        {
            if (cbImpressora.Text == "PDF")
            {
                CarregarCbTamanho();
            }
            else
            {
                    RemoverItemsCbTamanho();
            }

            switch (cbImpressora.Text)
            {
                case "Plotter-A2":
                    cbTamanhoFormato.SelectedItem = "A2";
                    break;
                case "Plotter-A1":
                    cbTamanhoFormato.SelectedItem = "A1";
                    break;
                case "Xerox":
                    cbTamanhoFormato.SelectedItem = "A4-L";
                    break;
                case "PDF":
                    if (cbTamanhoFormato.Text == "A0" || cbTamanhoFormato.Text == "A4-P")
                    {
                        cbTamanhoFormato.SelectedItem = cbTamanhoFormato.Text;
                    }
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
                case "A4-P":
                    cbImpressora.SelectedItem = "PDF";
                    break;
                case "A4-L":
                    cbImpressora.SelectedItem = "Xerox";
                    break;
            }
        }

        private void RemoverItemsCbTamanho()
        {
            for (int i = 0; i < cbTamanhoFormato.Items.Count; i++)
            {
                if (cbTamanhoFormato.Items[i].ToString() == "A0" || cbTamanhoFormato.Items[i].ToString() == "A3")
                {
                    cbTamanhoFormato.Items.RemoveAt(i);
                }
            }
        }

        private void CarregarCbTamanho()
        {

            cbTamanhoFormato.Items.Clear();

            if (cbImpressora.Text == "PDF")
            {
                cbTamanhoFormato.Items.Add("A0");
            }
            cbTamanhoFormato.Items.Add("A1");
            cbTamanhoFormato.Items.Add("A2");
            if (cbImpressora.Text == "PDF")
            {
                cbTamanhoFormato.Items.Add("A3");
            }
            cbTamanhoFormato.Items.Add("A4-L");
            cbTamanhoFormato.Items.Add("A4-P");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!Activation.Ativacao())
            {
                MessageBox.Show("SEM PERMISSÃO PARA ACESSAR A ROTINA!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
