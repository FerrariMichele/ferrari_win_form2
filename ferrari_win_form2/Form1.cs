using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferrari_win_form2
{
    public partial class Form1 : Form
    {
        #region Dichiarazioni
        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p;
        public int dim;
        public float somma;
        #endregion
        #region Funzioni evento
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }
        private void buttonaggiunta_Click_1(object sender, EventArgs e)
        {
            if (dim < p.Length)
            {
                p[dim].nome = textnome.Text;
                p[dim].prezzo = float.Parse(textprezzo.Text);
                dim++;
                Visualizza(p);
            }
            else
            {
                MessageBox.Show("Array pieno!", "Errore!");
            }
            textnome.Text = "";
            textprezzo.Text = "";
            textmodnome.Text = "";
            textmodprezzo.Text = "";
        }
        private void buttoncancella_Click_1(object sender, EventArgs e)
        {
            CancellaS(textnome.Text, p, ref dim);
            textnome.Text = "";
            textprezzo.Text = "";
            textmodnome.Text = "";
            textmodprezzo.Text = "";
        }
        private void buttonmod_Click(object sender, EventArgs e)
        {
            Modifica(textmodnome.Text, float.Parse(textmodprezzo.Text), p);
            textnome.Text = "";
            textprezzo.Text = "";
            textmodnome.Text = "";
            textmodprezzo.Text = "";
        }
        private void buttonsomma_Click_1(object sender, EventArgs e)
        {
            SommaProdotti(ref dim);
            textnome.Text = "";
            textprezzo.Text = "";
            textmodnome.Text = "";
            textmodprezzo.Text = "";
        }
        private void buttonmodprez_Click(object sender, EventArgs e)
        {
            VariazionePrezzo(ref dim, float.Parse(textpercprezz.Text));
        }
        private void buttonsomma_Click(object sender, EventArgs e)
        {
            SommaProdotti(ref dim);
        }
        #endregion
        #region Funzioni servizio
        public string prodString(prodotto p)
        {
            return "Nome: " + p.nome + " prezzo: " + p.prezzo.ToString("0.00");
        }
        public void Visualizza(prodotto[] p)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }
        public int RicercaS(string e, prodotto[] p)
        {
            int risultatoricerca = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].nome == e)
                {
                    risultatoricerca = i;
                    break;
                }
                else
                {
                    risultatoricerca = -1;
                }
            }
            return risultatoricerca;
        }
        public void CancellaS(string e, prodotto[] p, ref int dim)
        {
            var rispCanc = MessageBox.Show("È sicuro di voler eliminare l'elemento?", "Conferma rimozione elemento", MessageBoxButtons.YesNo);
            if (rispCanc == DialogResult.Yes)
            {
                if (RicercaS(textnome.Text, p) == -1)
                {
                    MessageBox.Show("Elemento non trovato!", "Errore!");
                }
                else
                {
                    for (int j = RicercaS(textnome.Text, p); j < dim - 1; j++)
                    {
                        p[j] = p[j + 1];
                    }
                    dim--;
                    listView1.Clear();
                    Visualizza(p);
                    MessageBox.Show("Elemento eliminato correttamente!");
                }
            }
        }
        public void Modifica(string e, float pos, prodotto[] p)
        {
            int psx = RicercaS(textnome.Text, p);
            var rispMod = MessageBox.Show("È sicuro di voler modificare l'elemento?", "Conferma modifica elemento", MessageBoxButtons.YesNo);
            if (rispMod == DialogResult.Yes)
            {
                if (RicercaS(textnome.Text, p) == -1)
                {
                    MessageBox.Show("Elemento non trovato!", "Errore!");
                }
                else
                {
                    p[psx].nome = e;
                    p[psx].prezzo = pos;
                    listView1.Clear();
                    Visualizza(p);
                    MessageBox.Show("Elemento modificato correttamente!");
                }
            }
        }
        public void SommaProdotti(ref int dim)
        {
            somma = 0;
            for (int i = 0; i < dim; i++)
            {
                somma += p[i].prezzo;
            }
            MessageBox.Show($"La somma dei prezzi dei prodotti è di {somma.ToString("0.00")}€", "Somma prodotti");
        }
        public void VariazionePrezzo(ref int dim, float perc)
        {
            var modPr = MessageBox.Show("È sicuro di voler modificare il prezzo dell'elemento (in base alla percentuale)?", "Conferma modifica prezzo elemento", MessageBoxButtons.YesNo);
            if (modPr == DialogResult.Yes)
            {
                float modprod = 0;
                for (int i = 0; i < dim; i++)
                {
                    modprod = p[i].prezzo + (p[i].prezzo * perc / 100);
                    p[i].prezzo = modprod;
                }
                listView1.Clear();
                Visualizza(p);
                MessageBox.Show("Prezzo dell'elemento modificato correttamente!");
            }
        }
        #endregion
    }
}