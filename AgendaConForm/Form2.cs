using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaConForm
{


    public partial class Form2 : Form
    {
        List<TipoAppuntamenti> agenda;


        public Form2(List<TipoAppuntamenti> supporto)
        {

            // Inizializzazione
            InitializeComponent();
            button1.Focus();
            agenda = supporto;
            
        }
  
        // Bottone Aggiungi
        public void button1_Click(object sender, EventArgs e)
        {
            TipoAppuntamenti NuovoAppuntamento = new TipoAppuntamenti();
            decimal tariffa;
            DateTime Orario;

            bool giusto = ControllaVuoti(ref NuovoAppuntamento);

            if (giusto == true)
            {
                NuovoAppuntamento.OrarioInserimento = DateTime.Now;
                bool Convertito = Decimal.TryParse(TxtTariffa.Text, out tariffa);
                if (Convertito == true)
                {
                    NuovoAppuntamento.Tariffa = tariffa;
                    Convertito = DateTime.TryParse(TxtOrarioApp.Text, out Orario);
                    if (Convertito == true)
                    {
                        NuovoAppuntamento.OrarioAppuntamento = Orario;
                        agenda.Add(NuovoAppuntamento);
                        this.Close();
                        this.Dispose();


                    }
                    else
                    {
                        MessageBox.Show("Formato errato: orario appuntamento deve avere un formato GG/MM/AAAA HH/mm", "Attenzione!");
                        TxtOrarioApp.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Formato errato: tariffa deve contenere un numero maggiore di 0", "Attenzione!");
                    TxtTariffa.Focus();
                }
            }
            
        }
        public bool ControllaVuoti(ref TipoAppuntamenti NuovoAppuntamento)
        {
            if (TxtNome.Text != "")
            {
                NuovoAppuntamento.Nome = TxtNome.Text;
                if (TxtCognome.Text != "")
                {
                    NuovoAppuntamento.Cognome = TxtCognome.Text;
                    if (TxtCodiceFis.Text != "")
                    {
                        NuovoAppuntamento.CodiceFiscale = TxtCodiceFis.Text;
                        if (TxtIndirizzo.Text != "")
                        {
                            NuovoAppuntamento.IndirizzoCivico = TxtIndirizzo.Text;
                            if (TxtTelefono.Text != "")
                            {
                                NuovoAppuntamento.Telefono = TxtTelefono.Text;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Il campo \"Telefono\" non può essere vuoto", "Attenzione");
                                TxtTelefono.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Il campo \"Indirizzo civico\" non può essere vuoto", "Attenzione");
                            TxtIndirizzo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Il campo \"Codice Fiscale\" non può essere vuoto", "Attenzione");
                        TxtCodiceFis.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Il campo \"cognome\" non può essere vuoto", "Attenzione");
                    TxtCognome.Focus();
                }
            }
            else
            {
                MessageBox.Show("Il campo \"nome\" non può essere vuoto", "Attenzione");
                TxtNome.Focus();
            }
            return false;
        }

        // ---------------------------------------------------------- Tutti keyPress --------------------------------------------------------------- \\

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCognome.Focus();
                TxtCognome.Clear();
                TxtCognome.ForeColor = Color.Black;
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtCognome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtIndirizzo.Focus();
                TxtIndirizzo.Clear();
                TxtIndirizzo.ForeColor = Color.Black;
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtIndirizzo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCodiceFis.Focus();
                TxtCodiceFis.Clear();
                TxtCodiceFis.ForeColor = Color.Black;
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtCodiceFis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtTelefono.Focus();
                TxtTelefono.Clear();
                TxtTelefono.ForeColor = Color.Black;
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtTariffa.Focus();
                TxtTariffa.Clear();
                TxtTariffa.ForeColor = Color.Black;
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtTariffa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtOrarioApp.Focus();
                TxtOrarioApp.Clear();
                TxtOrarioApp.ForeColor = Color.Black;
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtOrarioApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void TxtCognome_Click(object sender, EventArgs e)
        {
            TxtCognome.Clear();
            TxtCognome.ForeColor = Color.Black;
        }

        private void TxtIndirizzo_Click(object sender, EventArgs e)
        {
            TxtIndirizzo.Clear();
            TxtIndirizzo.ForeColor = Color.Black;
        }

        private void TxtCodiceFis_Click(object sender, EventArgs e)
        {
            TxtCodiceFis.Clear();
            TxtCodiceFis.ForeColor = Color.Black;
        }

        private void TxtTelefono_Click(object sender, EventArgs e)
        {
            TxtTelefono.Clear();
            TxtTelefono.ForeColor = Color.Black;
        }

        private void TxtTariffa_Click(object sender, EventArgs e)
        {
            TxtTariffa.Clear();
            TxtTariffa.ForeColor = Color.Black;
        }

        private void TxtOrarioApp_Click(object sender, EventArgs e)
        {
            TxtOrarioApp.Clear();
            TxtOrarioApp.ForeColor = Color.Black;
        }
    }
}
