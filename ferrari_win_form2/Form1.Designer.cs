namespace ferrari_win_form2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.titolo1 = new System.Windows.Forms.Label();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelprezzo = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textprezzo = new System.Windows.Forms.TextBox();
            this.buttonaggiunta = new System.Windows.Forms.Button();
            this.buttoncancella = new System.Windows.Forms.Button();
            this.buttonmod = new System.Windows.Forms.Button();
            this.textmodprezzo = new System.Windows.Forms.TextBox();
            this.textmodnome = new System.Windows.Forms.TextBox();
            this.labelmodprezzo = new System.Windows.Forms.Label();
            this.labelmodnome = new System.Windows.Forms.Label();
            this.buttonsomma = new System.Windows.Forms.Button();
            this.buttonmodprez = new System.Windows.Forms.Button();
            this.textpercprezz = new System.Windows.Forms.TextBox();
            this.labelpercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(442, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(346, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // titolo1
            // 
            this.titolo1.AutoSize = true;
            this.titolo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titolo1.Location = new System.Drawing.Point(12, 12);
            this.titolo1.Name = "titolo1";
            this.titolo1.Size = new System.Drawing.Size(224, 31);
            this.titolo1.TabIndex = 1;
            this.titolo1.Text = "Gestione Prodotti";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(15, 54);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(38, 13);
            this.labelnome.TabIndex = 2;
            this.labelnome.Text = "Nome:";
            // 
            // labelprezzo
            // 
            this.labelprezzo.AutoSize = true;
            this.labelprezzo.Location = new System.Drawing.Point(136, 54);
            this.labelprezzo.Name = "labelprezzo";
            this.labelprezzo.Size = new System.Drawing.Size(42, 13);
            this.labelprezzo.TabIndex = 3;
            this.labelprezzo.Text = "Prezzo:";
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(18, 70);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(100, 20);
            this.textnome.TabIndex = 4;
            // 
            // textprezzo
            // 
            this.textprezzo.Location = new System.Drawing.Point(139, 70);
            this.textprezzo.Name = "textprezzo";
            this.textprezzo.Size = new System.Drawing.Size(100, 20);
            this.textprezzo.TabIndex = 5;
            // 
            // buttonaggiunta
            // 
            this.buttonaggiunta.Location = new System.Drawing.Point(18, 108);
            this.buttonaggiunta.Name = "buttonaggiunta";
            this.buttonaggiunta.Size = new System.Drawing.Size(100, 23);
            this.buttonaggiunta.TabIndex = 6;
            this.buttonaggiunta.Text = "Aggiunta";
            this.buttonaggiunta.UseVisualStyleBackColor = true;
            this.buttonaggiunta.Click += new System.EventHandler(this.buttonaggiunta_Click_1);
            // 
            // buttoncancella
            // 
            this.buttoncancella.Location = new System.Drawing.Point(139, 108);
            this.buttoncancella.Name = "buttoncancella";
            this.buttoncancella.Size = new System.Drawing.Size(100, 23);
            this.buttoncancella.TabIndex = 7;
            this.buttoncancella.Text = "Cancella";
            this.buttoncancella.UseVisualStyleBackColor = true;
            this.buttoncancella.Click += new System.EventHandler(this.buttoncancella_Click_1);
            // 
            // buttonmod
            // 
            this.buttonmod.Location = new System.Drawing.Point(18, 232);
            this.buttonmod.Name = "buttonmod";
            this.buttonmod.Size = new System.Drawing.Size(221, 23);
            this.buttonmod.TabIndex = 12;
            this.buttonmod.Text = "Modifica";
            this.buttonmod.UseVisualStyleBackColor = true;
            this.buttonmod.Click += new System.EventHandler(this.buttonmod_Click);
            // 
            // textmodprezzo
            // 
            this.textmodprezzo.Location = new System.Drawing.Point(139, 194);
            this.textmodprezzo.Name = "textmodprezzo";
            this.textmodprezzo.Size = new System.Drawing.Size(100, 20);
            this.textmodprezzo.TabIndex = 11;
            // 
            // textmodnome
            // 
            this.textmodnome.Location = new System.Drawing.Point(18, 194);
            this.textmodnome.Name = "textmodnome";
            this.textmodnome.Size = new System.Drawing.Size(100, 20);
            this.textmodnome.TabIndex = 10;
            // 
            // labelmodprezzo
            // 
            this.labelmodprezzo.AutoSize = true;
            this.labelmodprezzo.Location = new System.Drawing.Point(136, 178);
            this.labelmodprezzo.Name = "labelmodprezzo";
            this.labelmodprezzo.Size = new System.Drawing.Size(42, 13);
            this.labelmodprezzo.TabIndex = 9;
            this.labelmodprezzo.Text = "Prezzo:";
            // 
            // labelmodnome
            // 
            this.labelmodnome.AutoSize = true;
            this.labelmodnome.Location = new System.Drawing.Point(15, 178);
            this.labelmodnome.Name = "labelmodnome";
            this.labelmodnome.Size = new System.Drawing.Size(38, 13);
            this.labelmodnome.TabIndex = 8;
            this.labelmodnome.Text = "Nome:";
            // 
            // buttonsomma
            // 
            this.buttonsomma.Location = new System.Drawing.Point(139, 343);
            this.buttonsomma.Name = "buttonsomma";
            this.buttonsomma.Size = new System.Drawing.Size(100, 23);
            this.buttonsomma.TabIndex = 16;
            this.buttonsomma.Text = "Somma dei prezzi";
            this.buttonsomma.UseVisualStyleBackColor = true;
            this.buttonsomma.Click += new System.EventHandler(this.buttonsomma_Click);
            // 
            // buttonmodprez
            // 
            this.buttonmodprez.Location = new System.Drawing.Point(18, 343);
            this.buttonmodprez.Name = "buttonmodprez";
            this.buttonmodprez.Size = new System.Drawing.Size(100, 23);
            this.buttonmodprez.TabIndex = 15;
            this.buttonmodprez.Text = "Modifica Prezzo";
            this.buttonmodprez.UseVisualStyleBackColor = true;
            this.buttonmodprez.Click += new System.EventHandler(this.buttonmodprez_Click);
            // 
            // textpercprezz
            // 
            this.textpercprezz.Location = new System.Drawing.Point(18, 305);
            this.textpercprezz.Name = "textpercprezz";
            this.textpercprezz.Size = new System.Drawing.Size(100, 20);
            this.textpercprezz.TabIndex = 14;
            // 
            // labelpercent
            // 
            this.labelpercent.AutoSize = true;
            this.labelpercent.Location = new System.Drawing.Point(15, 289);
            this.labelpercent.Name = "labelpercent";
            this.labelpercent.Size = new System.Drawing.Size(67, 13);
            this.labelpercent.TabIndex = 13;
            this.labelpercent.Text = "Percentuale:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsomma);
            this.Controls.Add(this.buttonmodprez);
            this.Controls.Add(this.textpercprezz);
            this.Controls.Add(this.labelpercent);
            this.Controls.Add(this.buttonmod);
            this.Controls.Add(this.textmodprezzo);
            this.Controls.Add(this.textmodnome);
            this.Controls.Add(this.labelmodprezzo);
            this.Controls.Add(this.labelmodnome);
            this.Controls.Add(this.buttoncancella);
            this.Controls.Add(this.buttonaggiunta);
            this.Controls.Add(this.textprezzo);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.labelprezzo);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.titolo1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label titolo1;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelprezzo;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textprezzo;
        private System.Windows.Forms.Button buttonaggiunta;
        private System.Windows.Forms.Button buttoncancella;
        private System.Windows.Forms.Button buttonmod;
        private System.Windows.Forms.TextBox textmodprezzo;
        private System.Windows.Forms.TextBox textmodnome;
        private System.Windows.Forms.Label labelmodprezzo;
        private System.Windows.Forms.Label labelmodnome;
        private System.Windows.Forms.Button buttonsomma;
        private System.Windows.Forms.Button buttonmodprez;
        private System.Windows.Forms.TextBox textpercprezz;
        private System.Windows.Forms.Label labelpercent;
    }
}

