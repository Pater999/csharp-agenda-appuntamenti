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


    public partial class Form3 : Form
    {
        List<TipoAppuntamenti> agenda;
        int pos;

        public Form3(List<TipoAppuntamenti> supporto, int posizione)
        {
            pos = posizione;

            // Inizializzazione
            InitializeComponent();

            agenda = supporto;

            TipoAppuntamenti Appuntamento = agenda[posizione];

            TxtNome.Text = Appuntamento.Nome;
            TxtCognome.Text = Appuntamento.Cognome;
            TxtIndirizzo.Text = Appuntamento.IndirizzoCivico;
            TxtCodiceFis.Text = Appuntamento.CodiceFiscale;
            TxtTariffa.Text = Appuntamento.Tariffa.ToString();
            TxtOrarioApp.Text = (Appuntamento.OrarioAppuntamento).ToString();
            TxtTelefono.Text = Appuntamento.Telefono;

            

            

        }

        // Bottone Modifica
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
                        agenda.RemoveAt(pos);
                        agenda.Insert(pos,NuovoAppuntamento);
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
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtCognome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtIndirizzo.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtIndirizzo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCodiceFis.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtCodiceFis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtTelefono.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtTariffa.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtTariffa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtOrarioApp.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void TxtOrarioApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnModifica.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }




    }
}
