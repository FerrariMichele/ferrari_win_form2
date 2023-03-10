using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ferrari_win_form2
{
    public partial class Form1 : Form
    {
        #region Dichiarazioni
        public struct prodotto
        {
            public string nome;
            public float prezzo;
            public int quantita;
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
            toolsipsalva.SetToolTip(buttonpush, "Salva in coda al file se pre-esistente, altrimenti ne crea uno nuovo");
        }
        private void buttonaggiunta_Click_1(object sender, EventArgs e)
        {
            if (dim < prod.Length)
            {
                bool presente = false;
                int pos = 0;
                for (int i = 0; i < prod.Length; i++)
                {
                    if (textnome.Text == prod[i].nome)
                    {
                        presente = true;
                        pos = i;
                    }
                }
                if (!presente)
                {
                    prod[dim].nome = textnome.Text;
                    prod[dim].prezzo = float.Parse(textprezzo.Text);
                    prod[dim].quantita = 1;
                    dim++;
                }
                else
                {
                    prod[pos].quantita++;
                }
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
            SommaProdotti(dim);
            textnome.Text = "";
            textprezzo.Text = "";
            textmodnome.Text = "";
            textmodprezzo.Text = "";
        }
        private void buttonmodprez_Click(object sender, EventArgs e)
        {
            VariazionePrezzo(dim, float.Parse(textpercprezz.Text));
        }
        private void buttonsomma_Click(object sender, EventArgs e)
        {
            SommaProdotti(dim);
        }
        private void buttonpull_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;

                if (!File.Exists(path))
                {
                    MessageBox.Show("Nessun file trovato");
                }
                else
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] dati = s.Split(';');
                        prod[dim].nome = dati[0];
                        prod[dim].prezzo = float.Parse(dati[1]);
                        dim++;
                        Visualizza(prod);
                    }
                }
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
                using (StreamWriter sw = new StreamWriter(path,append:false))
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
            var rispExt = MessageBox.Show("Chiudere l'applicazione?", "Uscita programma", MessageBoxButtons.YesNo);
            if (rispExt == DialogResult.Yes)
            {
                var savefile = MessageBox.Show("Salvare la lista?", "Salvataggio lista", MessageBoxButtons.YesNo);
                if (savefile == DialogResult.No)
                {
                    File.Delete(path);
                }
                Application.Exit();
            }
        }
        private void toolsipsalva_Popup(object sender, PopupEventArgs e)
        {
        }
        private void labelpercent_Click(object sender, EventArgs e)
        {
        }
        private void labelnome_Click(object sender, EventArgs e)
        {
        }
        private void labelprezzo_Click(object sender, EventArgs e)
        {
        }
        private void titolo1_Click(object sender, EventArgs e)
        {
        }
        private void buttonminmax_Click(object sender, EventArgs e)
        {
            MinMax(dim, prod);
        }
        #endregion
        #region Funzioni servizio
        public string prodString(prodotto prod)
        {
            return "Nome: " + prod.nome + " prezzo: " + prod.prezzo.ToString("0.00") + "€ quantità: " + prod.quantita;
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
            int risultatoricerca = -1;
            for (int i = 0; i < prod.Length; i++)
            {
                if (prod[i].nome == e)
                {
                    risultatoricerca = i;
                    break;
                }
            }
            return risultatoricerca;
        }
        public void CancellaS(string e, prodotto[] prod, ref int dim)
        {
            var rispCanc = MessageBox.Show("È sicuro di voler eliminare l'elemento?", "Conferma rimozione elemento", MessageBoxButtons.YesNo);
            int ricerca = RicercaS(textnome.Text, prod);
            if (rispCanc == DialogResult.Yes)
            {
                if (ricerca == -1)
                {
                    MessageBox.Show("Elemento non trovato!", "Errore!");
                }
                else
                {
                    for (int j = ricerca; j < dim - 1; j++)
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
                if (psx == -1)
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
        public void SommaProdotti(int dim)
        {
            somma = 0;
            for (int i = 0; i < dim; i++)
            {
                somma += prod[i].prezzo;
            }
            MessageBox.Show($"La somma dei prezzi dei prodotti è di {somma.ToString("0.00")}€", "Somma prodotti");
        }
        public void VariazionePrezzo(int dim, float perc)
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
        public void MinMax(int dim, prodotto[] prod)
        {
            int min = 0, max = 0;
            for (int i = 0; i < dim; i++)
            {
                if (prod[min].prezzo > prod[i].prezzo)
                    min = i;
                if (prod[max].prezzo < prod[i].prezzo)
                    max = i;
            }
            MessageBox.Show($"Prezzo Maggiore: {prod[max].nome} ({prod[max].prezzo.ToString("0.00")}€)\nPrezzo Minore: {prod[min].nome} ({prod[min].prezzo.ToString("0.00")}€)");
        }
        #endregion
    }
}