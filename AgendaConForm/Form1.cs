using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace AgendaConForm
{
    

    // Struct TipoAppuntamenti
    public struct TipoAppuntamenti
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string IndirizzoCivico { get; set; }
        public string CodiceFiscale { get; set; }
        public string Telefono { get; set; }
        public decimal Tariffa { get; set; }
        public DateTime OrarioAppuntamento { get; set; }
        public DateTime OrarioInserimento { get; set; }
    }

    

    public partial class Form1 : Form
    {

        // Dichiarazione Lista
        List<TipoAppuntamenti> Agenda = new List<TipoAppuntamenti>
        {
            new TipoAppuntamenti() { Nome = "Dominic", Cognome = "Kilfether", IndirizzoCivico = "Via Salita del Dosso, 27", CodiceFiscale = "ABCDEFGHI1234567", Telefono = "3484013591", OrarioAppuntamento = new DateTime(2017, 8, 10, 10, 00, 00), OrarioInserimento = new DateTime(2016, 10, 10, 12, 30, 00), Tariffa = 200 },
            new TipoAppuntamenti() { Nome = "Marinna", Cognome = "McKeighen", IndirizzoCivico = "Corso Verona, 132", CodiceFiscale = "1234567890123456", Telefono = "3474406723", OrarioAppuntamento = new DateTime(2016, 10, 9, 11, 30, 00), OrarioInserimento = new DateTime(2016, 10, 11, 12, 30, 00), Tariffa = 95 },
            new TipoAppuntamenti() { Nome = "Emil", Cognome = "Chansonne", IndirizzoCivico = "Via Roma, 29", CodiceFiscale = "0987654321654321", Telefono = "3246277339", OrarioAppuntamento = new DateTime(2017, 1, 12, 14, 30, 00), OrarioInserimento = new DateTime(2016, 10, 12, 12, 30, 00), Tariffa = 75 },
            new TipoAppuntamenti() { Nome = "Danika", Cognome = "Gannaway", IndirizzoCivico = "Via San Marcello, 1", CodiceFiscale = "POIUYTREWQLKJHGF", Telefono = "3484014791", OrarioAppuntamento = new DateTime(2017, 12, 13, 18, 30, 00), OrarioInserimento = new DateTime(2016, 10, 10, 12, 30, 00), Tariffa = 330 },
            new TipoAppuntamenti() { Nome = "Federico", Cognome = "Lugton", IndirizzoCivico = "Via dei poveri, 12", CodiceFiscale = "ZXCVBNMASDFGHJKL", Telefono = "3484014755", OrarioAppuntamento = new DateTime(2016, 4, 14, 9, 00, 00), OrarioInserimento = new DateTime(2016, 10, 13, 12, 30, 00), Tariffa = 120 },
            new TipoAppuntamenti() { Nome = "Michal", Cognome = "McCraw", IndirizzoCivico = "Corso del popolo, 22", CodiceFiscale = "QAZWSXEDCRFVTGBY", Telefono = "3484014712", OrarioAppuntamento = new DateTime(2017, 7, 5, 11, 45, 00), OrarioInserimento = new DateTime(2016, 10, 14, 12, 30, 00), Tariffa = 50 },
            new TipoAppuntamenti() { Nome = "Chic", Cognome = "Connop", IndirizzoCivico = "Via delle carote, 69", CodiceFiscale = "A1B2C3F4G6H9K5L0", Telefono = "3482314792", OrarioAppuntamento = new DateTime(2016, 11, 11, 13, 30, 00), OrarioInserimento = new DateTime(2016, 10, 15, 12, 30, 00), Tariffa = 250 },
            new TipoAppuntamenti() { Nome = "Manuel", Cognome = "Willshear", IndirizzoCivico = "Via Furli, 77", CodiceFiscale = "GETREKTCODDDICEE", Telefono = "3484464791", OrarioAppuntamento = new DateTime(2017, 12, 3, 15, 15, 00), OrarioInserimento = new DateTime(2016, 10, 15, 12, 30, 00), Tariffa = 100 }
        };


        // Lista di Appoggio per visualizzazione
        List<TipoAppuntamenti> Appoggio = new List<TipoAppuntamenti>();


        public Form1()
        {
            
            // Inizializza Componenti
            InitializeComponent();
            

            //Codice
            DgvAppuntamenti.DataSource = Agenda;
            DgvAppuntamenti.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque;
            DgvAppuntamenti.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige;
            DgvAppuntamenti.ColumnHeaderMouseClick += DgvAppuntamenti_ColumnHeaderMouseClick;

            // Eventi Per PlaceHolder:
            TxtGiorno.GotFocus += TxtGiorno_GotFocus;
            TxtGiorno.LostFocus += TxtGiorno_LostFocus;
            TxtEliminaNome.GotFocus += TxtEliminaNome_GotFocus;
            TxtEliminaNome.LostFocus += TxtEliminaNome_LostFocus;
            TxtNome.GotFocus += TxtNome_GotFocus;
            TxtNome.LostFocus += TxtNome_LostFocus;
            TxtModificaNome.GotFocus += TxtModificaNome_GotFocus;
            TxtModificaNome.LostFocus += TxtModificaNome_LostFocus;

        }

        // Place Holder TxtModificaNome
        private void TxtModificaNome_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtModificaNome.Text))
            {
                TxtModificaNome.ForeColor = System.Drawing.Color.LightGray;
                TxtModificaNome.Text = "Enter name...";

            }
        }
        private void TxtModificaNome_GotFocus(object sender, EventArgs e)
        {
            TxtModificaNome.ForeColor = System.Drawing.Color.Black;
            TxtModificaNome.Text = "";
        }

        // Place Holder TxtEliminaNome
        private void TxtEliminaNome_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtEliminaNome.Text))
            {
                TxtEliminaNome.ForeColor = System.Drawing.Color.LightGray;
                TxtEliminaNome.Text = "Enter name...";

            }
        }
        private void TxtEliminaNome_GotFocus(object sender, EventArgs e)
        {
            TxtEliminaNome.ForeColor = System.Drawing.Color.Black;
            TxtEliminaNome.Text = "";
        }

        // Place Holder TxtGiorno
        private void TxtGiorno_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtGiorno.Text))
            {
                TxtGiorno.ForeColor = System.Drawing.Color.LightGray;
                TxtGiorno.Text = "GG/MM/AAAA";

            }

        }
        private void TxtGiorno_GotFocus(object sender, EventArgs e)
        {
            TxtGiorno.ForeColor = System.Drawing.Color.Black;
            TxtGiorno.Text = "";
            
        }

        // Place Holder TxtNome
        private void TxtNome_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtNome.Text))
            {
                TxtNome.ForeColor = System.Drawing.Color.LightGray;
                TxtNome.Text = "Enter name...";
            }
        }
        private void TxtNome_GotFocus(object sender, EventArgs e)
        {
            TxtNome.ForeColor = System.Drawing.Color.Black;
            TxtNome.Text = "";
        }

        // Gestione Invio su TxtGiorno
        private void TxtGiorno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CercaGiorno();
                BtnVisualizzaTutto.Focus();
            }
        }

        // Gestione Invio su TxtEliminaNome
        private void TxtEliminaNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Elimina();
                BtnVisualizzaTutto.Focus();
            }
        }

        // Gestione Invio su TxtModificaNome
        private void TxtModificaNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ModificaNome();
                BtnVisualizzaTutto.Focus();
            }
        }

        // Gestione Invio su TxtNome
        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CercaNome();
                BtnVisualizzaTutto.Focus();
            }
        }


        // --------------------------------------------------- METODI ------------------------------------------------------------------------ \\

        // Bottone Visualizza Tutto
        private void BtnVisualizzaTutto_Click(object sender, EventArgs e)
        {
            DgvAppuntamenti.DataSource = null;
            DgvAppuntamenti.DataSource = Agenda;
        }

        // Riordina in colonna:
        private void DgvAppuntamenti_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.ColumnIndex;
            switch(indice)
            {
                // Ordina Nome
                case 0:
                    Agenda.Sort((s1, s2) => s1.Nome.CompareTo(s2.Nome));
                    break;

                // Ordina Cognome
                case 1:
                    Agenda.Sort((s1, s2) => s1.Cognome.CompareTo(s2.Cognome));
                    break;

                // Ordina OrarioAppuntamento
                case 6:
                    Agenda.Sort((s1, s2) => s1.OrarioAppuntamento.CompareTo(s2.OrarioAppuntamento));
                    break;

                // Ordina OrarioInserimento
                case 7:
                    Agenda.Sort((s1, s2) => s1.OrarioInserimento.CompareTo(s2.OrarioInserimento));
                    break;

                default:
                    break;
            }

            DgvAppuntamenti.DataSource = null;
            DgvAppuntamenti.DataSource = Agenda;
        }

        // Bottone Salva JSON
        private void BtnSalvaJson_Click(object sender, EventArgs e)
        {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SaveFileDialog.FilterIndex == 0)
                    {
                        File.WriteAllText(SaveFileDialog.FileName, JsonConvert.SerializeObject(Agenda));
                    }
                    else
                    { 
                         //sorgente c# per salvare la matrice m nel file “dati.csv”
                         StringBuilder csv = new StringBuilder();
                         string newLine = "";
                         //in your loop

                         for (int r = 0; r < Agenda.Count; r++)
                         {
                             newLine += string.Format("{0};{1};{2};{3};{4};{5};{6};{7}", Agenda[r].Nome, Agenda[r].Cognome, Agenda[r].IndirizzoCivico, Agenda[r].CodiceFiscale, Agenda[r].Telefono, Agenda[r].Tariffa.ToString(), Agenda[r].OrarioAppuntamento.ToString(), Agenda[r].OrarioInserimento.ToString());
                             csv.AppendLine(newLine.Remove(newLine.Length - 1, 1));
                             newLine = "";
                         }
                         File.WriteAllText(SaveFileDialog.FileName, csv.ToString());
                   }
               }                      
        }

        // Bottone Apri JSON
        private void BtnApriJson_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.FilterIndex == 0)
            {
                if ((OpenFileDialog.ShowDialog() == DialogResult.OK)) //dialogresult enumerativo
                {
                    Agenda = JsonConvert.DeserializeObject<List<TipoAppuntamenti>>(File.ReadAllText(OpenFileDialog.FileName));
                    DgvAppuntamenti.DataSource = null;
                    DgvAppuntamenti.DataSource = Agenda;
                }
            }
            else
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK) //dialogresult enumerativo
                {
                    Agenda.Clear();
                    string whole_file = System.IO.File.ReadAllText(OpenFileDialog.FileName);
                    whole_file = whole_file.Replace('\n', '\r');
                    string[] lines = whole_file.Split(new char[] { '\r' },
                        StringSplitOptions.RemoveEmptyEntries);
                    for (int r = 0; r < lines.Length; r++)
                    {
                            string[] result = lines[r].Split(';');
                            TipoAppuntamenti Appuntamento = new TipoAppuntamenti() { Nome = result[0], Cognome = result[1], IndirizzoCivico = result[2], CodiceFiscale = result[3], Telefono = result[4],Tariffa=decimal.Parse(result[5]), OrarioAppuntamento = DateTime.Parse(result[6]), OrarioInserimento = DateTime.Parse(result[7]) };
                            Agenda.Add(Appuntamento);
                    }
                    DgvAppuntamenti.DataSource = null;
                    DgvAppuntamenti.DataSource = Agenda;
                }
            }
        }

        // Bottone Salva CSV
        private void BtnSalvaCsv_Click(object sender, EventArgs e)
        {
            
        }

        // Bottone Apri CSV
        private void BtnApriCsv_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    sorgente c# per salvare la matrice m nel file “dati.csv”
            //    StringBuilder csv = new StringBuilder();
            //    string newLine = "";
            //    in your loop

            //    for (int r = 0; r < componenti; r++)
            //    {
            //        newLine += string.Format("{0};", vettore[r]);
            //        csv.AppendLine(newLine.Remove(newLine.Length - 1, 1));
            //        newLine = "";
            //    }
            //    File.WriteAllText("dati.csv", csv.ToString());
            //}
        }

        // Bottone Aggiungi Appuntamento
        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(Agenda);
            frm.ShowDialog();

            DgvAppuntamenti.DataSource = null;
            DgvAppuntamenti.DataSource = Agenda;
        }

        // Bottone Elimina Appuntamento
        private void BtnElimina_Click(object sender, EventArgs e)
        {
            EliminaAppuntamento();
        }
        public void EliminaAppuntamento()
        {
            if (Agenda.Count > 0)
            {
                int index = DgvAppuntamenti.SelectedRows[0].Index;
                Agenda.RemoveAt(index);


                DgvAppuntamenti.DataSource = null;
                DgvAppuntamenti.DataSource = Agenda;
            }
            else
            {
                MessageBox.Show("Impossibile Eliminare: L'agenda è vuota!", "Attenzione!");
            }
        }

        // Bottone Modifica Appuntamento
        private void BtnModifica_Click(object sender, EventArgs e)
        {
            if (Agenda.Count > 0)
            {
                int index = DgvAppuntamenti.SelectedRows[0].Index;
                Form3 frm = new Form3(Agenda, index);
                frm.ShowDialog();

                DgvAppuntamenti.DataSource = null;
                DgvAppuntamenti.DataSource = Agenda;
            }
            else
            {
                MessageBox.Show("Impossibile modificare: la lista è vuota!", "Attenzione");
            }
        }

        // Bottone Cerca e visualizza Giorno
        private void BtnCercaGiorno_Click(object sender, EventArgs e)
        {
            CercaGiorno();
        }
        public void CercaGiorno()
        {
            DateTime GiornoCercato;
            bool corretto = DateTime.TryParse(TxtGiorno.Text, out GiornoCercato);
            if (corretto == true)
            {
                Appoggio = Agenda.FindAll(item => item.OrarioAppuntamento.ToShortDateString() == GiornoCercato.ToShortDateString());
                if (Appoggio.Count > 0)
                {
                    DgvAppuntamenti.DataSource = null;
                    DgvAppuntamenti.DataSource = Appoggio;
                    TxtGiorno.ForeColor = Color.Gray;
                    TxtGiorno.Text = "GG/MM/AAAA";
                }
                else
                {
                    MessageBox.Show("Nessun appuntamento trovato nel giorno " + GiornoCercato.ToShortDateString(), "Ricerca fallita");
                    TxtGiorno.ForeColor = Color.Gray;
                    TxtGiorno.Text = "GG/MM/AAAA";
                }
            }
            else
            {
                MessageBox.Show("Formato scorretto: Inserire il formato GG/MM/AAAA", "Attenzione!");
                TxtGiorno.ForeColor = Color.Gray;
                TxtGiorno.Text = "GG/MM/AAAA";
            }
        }

        // Bottone Cerca e visualizza Nome
        private void BtnCercaNome_Click(object sender, EventArgs e)
        {
            CercaNome();
        }
        public void CercaNome()
        {
            Appoggio = Agenda.FindAll(item => item.Nome.ToUpper() == TxtNome.Text.ToUpper());
            if (Appoggio.Count > 0)
            {
                DgvAppuntamenti.DataSource = null;
                DgvAppuntamenti.DataSource = Appoggio;
                TxtNome.ForeColor = Color.Gray;
                TxtNome.Text = "Enter name...";
            }
            else
            {
                MessageBox.Show("Il nome inserito è scoretto o non è presente nella lista", "Attenzione!");
                TxtNome.ForeColor = Color.Gray;
                TxtNome.Text = "Enter name...";
            }
        }

        // Bottone Modifica Nome
        private void BtnModificaNome_Click(object sender, EventArgs e)
        {
            ModificaNome();
        }
        private void ModificaNome()
        {
            int index = Agenda.FindIndex(item => item.Cognome.ToUpper() == TxtModificaNome.Text.ToUpper());
            if (index >= 0)
            {
                Form3 frm = new Form3(Agenda, index);
                frm.ShowDialog();

                DgvAppuntamenti.DataSource = null;
                DgvAppuntamenti.DataSource = Agenda;
                TxtModificaNome.ForeColor = Color.Gray;
                TxtModificaNome.Text = "Enter name...";
            }
            else
            {
                MessageBox.Show("Il cognome inserito è scoretto o non è presente nella lista", "Attenzione!");
                TxtModificaNome.ForeColor = Color.Gray;
                TxtModificaNome.Text = "Enter name...";
            }
        }

        // Bottone Elimina Nome
        private void BtnEliminaNome_Click(object sender, EventArgs e)
        {
            Elimina();
        }
        public void Elimina()
        {
            int pos = Agenda.FindIndex(item => (item.Cognome).ToUpper() == TxtEliminaNome.Text.ToUpper());
            if (pos >= 0)
            {
                Agenda.RemoveAt(pos);
                DgvAppuntamenti.DataSource = null;
                DgvAppuntamenti.DataSource = Agenda;
                TxtEliminaNome.ForeColor = Color.Gray;
                TxtEliminaNome.Text = "Enter name...";
            }
            else
            {
                MessageBox.Show("Il nome inserito è scorretto o non è presente nella lista", "Attenzione!");
                TxtEliminaNome.ForeColor = Color.Gray;
                TxtEliminaNome.Text = "Enter name...";
            }
        }

 
        
    }
}
