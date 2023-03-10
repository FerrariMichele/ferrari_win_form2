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
            this.components = new System.ComponentModel.Container();
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
            this.buttonpush = new System.Windows.Forms.Button();
            this.buttonpull = new System.Windows.Forms.Button();
            this.buttondellist = new System.Windows.Forms.Button();
            this.toolsipsalva = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonminmax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(254, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // titolo1
            // 
            this.titolo1.AutoSize = true;
            this.titolo1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo1.Location = new System.Drawing.Point(12, 22);
            this.titolo1.Name = "titolo1";
            this.titolo1.Size = new System.Drawing.Size(235, 30);
            this.titolo1.TabIndex = 1;
            this.titolo1.Text = "Gestione Prodotti";
            this.titolo1.Click += new System.EventHandler(this.titolo1_Click);
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelnome.Location = new System.Drawing.Point(15, 87);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(38, 13);
            this.labelnome.TabIndex = 2;
            this.labelnome.Text = "Nome:";
            this.labelnome.Click += new System.EventHandler(this.labelnome_Click);
            // 
            // labelprezzo
            // 
            this.labelprezzo.AutoSize = true;
            this.labelprezzo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelprezzo.Location = new System.Drawing.Point(136, 87);
            this.labelprezzo.Name = "labelprezzo";
            this.labelprezzo.Size = new System.Drawing.Size(42, 13);
            this.labelprezzo.TabIndex = 3;
            this.labelprezzo.Text = "Prezzo:";
            this.labelprezzo.Click += new System.EventHandler(this.labelprezzo_Click);
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(18, 103);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(100, 20);
            this.textnome.TabIndex = 4;
            // 
            // textprezzo
            // 
            this.textprezzo.Location = new System.Drawing.Point(139, 103);
            this.textprezzo.Name = "textprezzo";
            this.textprezzo.Size = new System.Drawing.Size(100, 20);
            this.textprezzo.TabIndex = 5;
            // 
            // buttonaggiunta
            // 
            this.buttonaggiunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonaggiunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaggiunta.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonaggiunta.Location = new System.Drawing.Point(18, 129);
            this.buttonaggiunta.Name = "buttonaggiunta";
            this.buttonaggiunta.Size = new System.Drawing.Size(100, 23);
            this.buttonaggiunta.TabIndex = 6;
            this.buttonaggiunta.Text = "Aggiunta";
            this.buttonaggiunta.UseVisualStyleBackColor = true;
            this.buttonaggiunta.Click += new System.EventHandler(this.buttonaggiunta_Click_1);
            // 
            // buttoncancella
            // 
            this.buttoncancella.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.buttoncancella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttoncancella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncancella.Location = new System.Drawing.Point(139, 129);
            this.buttoncancella.Name = "buttoncancella";
            this.buttoncancella.Size = new System.Drawing.Size(100, 23);
            this.buttoncancella.TabIndex = 7;
            this.buttoncancella.Text = "Cancella";
            this.buttoncancella.UseVisualStyleBackColor = true;
            this.buttoncancella.Click += new System.EventHandler(this.buttoncancella_Click_1);
            // 
            // buttonmod
            // 
            this.buttonmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmod.Location = new System.Drawing.Point(18, 219);
            this.buttonmod.Name = "buttonmod";
            this.buttonmod.Size = new System.Drawing.Size(221, 23);
            this.buttonmod.TabIndex = 12;
            this.buttonmod.Text = "Modifica";
            this.buttonmod.UseVisualStyleBackColor = true;
            this.buttonmod.Click += new System.EventHandler(this.buttonmod_Click);
            // 
            // textmodprezzo
            // 
            this.textmodprezzo.Location = new System.Drawing.Point(139, 193);
            this.textmodprezzo.Name = "textmodprezzo";
            this.textmodprezzo.Size = new System.Drawing.Size(100, 20);
            this.textmodprezzo.TabIndex = 11;
            // 
            // textmodnome
            // 
            this.textmodnome.Location = new System.Drawing.Point(18, 193);
            this.textmodnome.Name = "textmodnome";
            this.textmodnome.Size = new System.Drawing.Size(100, 20);
            this.textmodnome.TabIndex = 10;
            // 
            // labelmodprezzo
            // 
            this.labelmodprezzo.AutoSize = true;
            this.labelmodprezzo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelmodprezzo.Location = new System.Drawing.Point(136, 177);
            this.labelmodprezzo.Name = "labelmodprezzo";
            this.labelmodprezzo.Size = new System.Drawing.Size(42, 13);
            this.labelmodprezzo.TabIndex = 9;
            this.labelmodprezzo.Text = "Prezzo:";
            // 
            // labelmodnome
            // 
            this.labelmodnome.AutoSize = true;
            this.labelmodnome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelmodnome.Location = new System.Drawing.Point(15, 177);
            this.labelmodnome.Name = "labelmodnome";
            this.labelmodnome.Size = new System.Drawing.Size(38, 13);
            this.labelmodnome.TabIndex = 8;
            this.labelmodnome.Text = "Nome:";
            // 
            // buttonsomma
            // 
            this.buttonsomma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsomma.Location = new System.Drawing.Point(139, 315);
            this.buttonsomma.Name = "buttonsomma";
            this.buttonsomma.Size = new System.Drawing.Size(100, 23);
            this.buttonsomma.TabIndex = 16;
            this.buttonsomma.Text = "Somma dei prezzi";
            this.buttonsomma.UseVisualStyleBackColor = true;
            this.buttonsomma.Click += new System.EventHandler(this.buttonsomma_Click);
            // 
            // buttonmodprez
            // 
            this.buttonmodprez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmodprez.Location = new System.Drawing.Point(18, 315);
            this.buttonmodprez.Name = "buttonmodprez";
            this.buttonmodprez.Size = new System.Drawing.Size(100, 23);
            this.buttonmodprez.TabIndex = 15;
            this.buttonmodprez.Text = "Modifica prezzo";
            this.buttonmodprez.UseVisualStyleBackColor = true;
            this.buttonmodprez.Click += new System.EventHandler(this.buttonmodprez_Click);
            // 
            // textpercprezz
            // 
            this.textpercprezz.Location = new System.Drawing.Point(18, 289);
            this.textpercprezz.Name = "textpercprezz";
            this.textpercprezz.Size = new System.Drawing.Size(100, 20);
            this.textpercprezz.TabIndex = 14;
            // 
            // labelpercent
            // 
            this.labelpercent.AutoSize = true;
            this.labelpercent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelpercent.Location = new System.Drawing.Point(15, 273);
            this.labelpercent.Name = "labelpercent";
            this.labelpercent.Size = new System.Drawing.Size(67, 13);
            this.labelpercent.TabIndex = 13;
            this.labelpercent.Text = "Percentuale:";
            this.labelpercent.Click += new System.EventHandler(this.labelpercent_Click);
            // 
            // buttonpush
            // 
            this.buttonpush.Location = new System.Drawing.Point(139, 386);
            this.buttonpush.Name = "buttonpush";
            this.buttonpush.Size = new System.Drawing.Size(100, 23);
            this.buttonpush.TabIndex = 18;
            this.buttonpush.Text = "Salva su file";
            this.buttonpush.UseVisualStyleBackColor = true;
            this.buttonpush.Click += new System.EventHandler(this.buttonpush_Click);
            // 
            // buttonpull
            // 
            this.buttonpull.Location = new System.Drawing.Point(18, 386);
            this.buttonpull.Name = "buttonpull";
            this.buttonpull.Size = new System.Drawing.Size(100, 23);
            this.buttonpull.TabIndex = 17;
            this.buttonpull.Text = "Recupera da file";
            this.buttonpull.UseVisualStyleBackColor = true;
            this.buttonpull.Click += new System.EventHandler(this.buttonpull_Click);
            // 
            // buttondellist
            // 
            this.buttondellist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondellist.Location = new System.Drawing.Point(78, 415);
            this.buttondellist.Name = "buttondellist";
            this.buttondellist.Size = new System.Drawing.Size(100, 23);
            this.buttondellist.TabIndex = 19;
            this.buttondellist.Text = "Uscita";
            this.buttondellist.UseVisualStyleBackColor = true;
            this.buttondellist.Click += new System.EventHandler(this.buttondellist_Click);
            // 
            // toolsipsalva
            // 
            this.toolsipsalva.Popup += new System.Windows.Forms.PopupEventHandler(this.toolsipsalva_Popup);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 100);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(789, 100);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 253);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(789, 100);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // buttonminmax
            // 
            this.buttonminmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonminmax.Location = new System.Drawing.Point(139, 286);
            this.buttonminmax.Name = "buttonminmax";
            this.buttonminmax.Size = new System.Drawing.Size(100, 23);
            this.buttonminmax.TabIndex = 23;
            this.buttonminmax.Text = "Massimo/Minimo";
            this.buttonminmax.UseVisualStyleBackColor = true;
            this.buttonminmax.Click += new System.EventHandler(this.buttonminmax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonminmax);
            this.Controls.Add(this.labelpercent);
            this.Controls.Add(this.textpercprezz);
            this.Controls.Add(this.buttonsomma);
            this.Controls.Add(this.buttonmodprez);
            this.Controls.Add(this.buttondellist);
            this.Controls.Add(this.buttonpush);
            this.Controls.Add(this.buttonpull);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button buttonpush;
        private System.Windows.Forms.Button buttonpull;
        private System.Windows.Forms.Button buttondellist;
        private System.Windows.Forms.ToolTip toolsipsalva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonminmax;
    }
}

