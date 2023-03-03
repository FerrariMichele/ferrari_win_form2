using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public prodotto[] prod;
        public int dim;
        public float somma;
        string path = @"list.csv";
        #endregion
        #region Funzioni evento
        public Form1()
        {
            InitializeComponent();
            prod = new prodotto[100];
            dim = 0;
            toolsipsalva.SetToolTip(buttonpush, "Salva in coda al file pre-esistente o ne crea uno nuovo");
        }
        private void buttonaggiunta_Click_1(object sender, EventArgs e)
        {
            if (dim < prod.Length)
            {
                prod[dim].nome = textnome.Text;
                prod[dim].prezzo = float.Parse(textprezzo.Text);
                dim++;
                Visualizza(prod);
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
            CancellaS(textnome.Text, prod, ref dim);
            textnome.Text = "";
            textprezzo.Text = "";
            textmodnome.Text = "";
            textmodprezzo.Text = "";
        }
        private void buttonmod_Click(object sender, EventArgs e)
        {
            Modifica(textmodnome.Text, float.Parse(textmodprezzo.Text), prod);
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
        private void buttonpull_Click(object sender, EventArgs e)
        {
            using (StreamReader sw = new StreamReader(path))
            {
             
            }
        }
        private void buttonpush_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    for (int i = 0; i < dim; i++)
                    {
                        sw.WriteLine($"{prod[i].nome};{prod[i].prezzo}");
                    }
                }    
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path,append:true))
                {
                    for (int i = 0; i < dim; i++)
                    {
                        sw.WriteLine($"{prod[i].nome};{prod[i].prezzo}");
                    }
                }
            }
            
        }
        private void buttondellist_Click(object sender, EventArgs e)
        {
            File.Delete(path);
        }
        private void toolsipsalva_Popup(object sender, PopupEventArgs e)
        {

        }
        #endregion
        #region Funzioni servizio
        public string prodString(prodotto prod)
        {
            return "Nome: " + prod.nome + " prezzo: " + prod.prezzo.ToString("0.00");
        }
        public void Visualizza(prodotto[] prod)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(prod[i]));
            }
        }
        public int RicercaS(string e, prodotto[] prod)
        {
            int risultatoricerca = 0;
            for (int i = 0; i < prod.Length; i++)
            {
                if (prod[i].nome == e)
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
        public void CancellaS(string e, prodotto[] prod, ref int dim)
        {
            var rispCanc = MessageBox.Show("È sicuro di voler eliminare l'elemento?", "Conferma rimozione elemento", MessageBoxButtons.YesNo);
            if (rispCanc == DialogResult.Yes)
            {
                if (RicercaS(textnome.Text, prod) == -1)
                {
                    MessageBox.Show("Elemento non trovato!", "Errore!");
                }
                else
                {
                    for (int j = RicercaS(textnome.Text, prod); j < dim - 1; j++)
                    {
                        prod[j] = prod[j + 1];
                    }
                    dim--;
                    listView1.Clear();
                    Visualizza(prod);
                    MessageBox.Show("Elemento eliminato correttamente!");
                }
            }
        }
        public void Modifica(string e, float pos, prodotto[] prod)
        {
            int psx = RicercaS(textnome.Text, prod);
            var rispMod = MessageBox.Show("È sicuro di voler modificare l'elemento?", "Conferma modifica elemento", MessageBoxButtons.YesNo);
            if (rispMod == DialogResult.Yes)
            {
                if (RicercaS(textnome.Text, prod) == -1)
                {
                    MessageBox.Show("Elemento non trovato!", "Errore!");
                }
                else
                {
                    prod[psx].nome = e;
                    prod[psx].prezzo = pos;
                    listView1.Clear();
                    Visualizza(prod);
                    MessageBox.Show("Elemento modificato correttamente!");
                }
            }
        }
        public void SommaProdotti(ref int dim)
        {
            somma = 0;
            for (int i = 0; i < dim; i++)
            {
                somma += prod[i].prezzo;
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
                    modprod = prod[i].prezzo + (prod[i].prezzo * perc / 100);
                    prod[i].prezzo = modprod;
                }
                listView1.Clear();
                Visualizza(prod);
                MessageBox.Show("Prezzo dell'elemento modificato correttamente!");
            }
        }
        #endregion
    }
}