namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.chMembru = new System.Windows.Forms.CheckBox();
            this.chCadou = new System.Windows.Forms.CheckBox();
            this.chAudio = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCuratare = new System.Windows.Forms.Button();
            this.brAdaugare = new System.Windows.Forms.Button();
            this.cbLivrare = new System.Windows.Forms.ComboBox();
            this.tbeditura = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apPret = new System.Windows.Forms.ErrorProvider(this.components);
            this.erTitlu = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erLivrare = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnEditare = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operatiiBinareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteArticoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.apPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTitlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erLivrare)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare carte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Optiuni pentru achizitie";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(26, 88);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(267, 22);
            this.tbTitlu.TabIndex = 6;
            this.tbTitlu.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitlu_Validating);
            this.tbTitlu.Validated += new System.EventHandler(this.tbTitlu_Validated);
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(26, 182);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(267, 22);
            this.tbPret.TabIndex = 8;
            this.tbPret.Validating += new System.ComponentModel.CancelEventHandler(this.tbPret_Validating);
            this.tbPret.Validated += new System.EventHandler(this.tbPret_Validated);
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(25, 132);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(268, 22);
            this.tbAutor.TabIndex = 9;
            // 
            // chMembru
            // 
            this.chMembru.AutoSize = true;
            this.chMembru.Location = new System.Drawing.Point(26, 350);
            this.chMembru.Name = "chMembru";
            this.chMembru.Size = new System.Drawing.Size(114, 21);
            this.chMembru.TabIndex = 11;
            this.chMembru.Text = "Membru activ";
            this.chMembru.UseVisualStyleBackColor = true;
            // 
            // chCadou
            // 
            this.chCadou.AutoSize = true;
            this.chCadou.Location = new System.Drawing.Point(25, 377);
            this.chCadou.Name = "chCadou";
            this.chCadou.Size = new System.Drawing.Size(131, 21);
            this.chCadou.TabIndex = 13;
            this.chCadou.Text = "+Ambalaj cadou";
            this.chCadou.UseVisualStyleBackColor = true;
            // 
            // chAudio
            // 
            this.chAudio.AutoSize = true;
            this.chAudio.Location = new System.Drawing.Point(178, 377);
            this.chAudio.Name = "chAudio";
            this.chAudio.Size = new System.Drawing.Size(105, 21);
            this.chAudio.TabIndex = 14;
            this.chAudio.Text = "+Audiobook";
            this.chAudio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lista carti";
            // 
            // btCuratare
            // 
            this.btCuratare.Location = new System.Drawing.Point(192, 404);
            this.btCuratare.Name = "btCuratare";
            this.btCuratare.Size = new System.Drawing.Size(101, 41);
            this.btCuratare.TabIndex = 17;
            this.btCuratare.Text = "Curatare";
            this.btCuratare.UseVisualStyleBackColor = true;
            this.btCuratare.Click += new System.EventHandler(this.btCuratare_Click);
            // 
            // brAdaugare
            // 
            this.brAdaugare.Location = new System.Drawing.Point(27, 404);
            this.brAdaugare.Name = "brAdaugare";
            this.brAdaugare.Size = new System.Drawing.Size(101, 41);
            this.brAdaugare.TabIndex = 18;
            this.brAdaugare.Text = "Adaugare";
            this.brAdaugare.UseVisualStyleBackColor = true;
            this.brAdaugare.Click += new System.EventHandler(this.brAdaugare_Click);
            // 
            // cbLivrare
            // 
            this.cbLivrare.FormattingEnabled = true;
            this.cbLivrare.Items.AddRange(new object[] {
            "Livrare prin Fan Courier",
            "Livrare prin posta"});
            this.cbLivrare.Location = new System.Drawing.Point(25, 320);
            this.cbLivrare.Name = "cbLivrare";
            this.cbLivrare.Size = new System.Drawing.Size(268, 24);
            this.cbLivrare.TabIndex = 20;
            this.cbLivrare.Validating += new System.ComponentModel.CancelEventHandler(this.cbLivrare_Validating);
            this.cbLivrare.Validated += new System.EventHandler(this.cbLivrare_Validated);
            // 
            // tbeditura
            // 
            this.tbeditura.Location = new System.Drawing.Point(25, 227);
            this.tbeditura.Name = "tbeditura";
            this.tbeditura.Size = new System.Drawing.Size(265, 22);
            this.tbeditura.TabIndex = 21;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PeachPuff;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titlu,
            this.Autor,
            this.Valoare,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(360, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 256);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Titlu
            // 
            this.Titlu.Text = "Titlul";
            this.Titlu.Width = 70;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            // 
            // Valoare
            // 
            this.Valoare.Text = "Pret";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valoare totala";
            this.columnHeader1.Width = 102;
            // 
            // apPret
            // 
            this.apPret.ContainerControl = this;
            // 
            // erTitlu
            // 
            this.erTitlu.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // erLivrare
            // 
            this.erLivrare.ContainerControl = this;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(664, 386);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 41);
            this.btnStergere.TabIndex = 23;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditare
            // 
            this.btnEditare.Location = new System.Drawing.Point(511, 386);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(98, 41);
            this.btnEditare.TabIndex = 24;
            this.btnEditare.Text = "Editare";
            this.btnEditare.UseVisualStyleBackColor = true;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiBinareToolStripMenuItem,
            this.fisiereTextToolStripMenuItem,
            this.alteArticoleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operatiiBinareToolStripMenuItem
            // 
            this.operatiiBinareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.operatiiBinareToolStripMenuItem.Name = "operatiiBinareToolStripMenuItem";
            this.operatiiBinareToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.operatiiBinareToolStripMenuItem.Text = "Operatii binare";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // fisiereTextToolStripMenuItem
            // 
            this.fisiereTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fisiereTextToolStripMenuItem.Name = "fisiereTextToolStripMenuItem";
            this.fisiereTextToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.fisiereTextToolStripMenuItem.Text = "Fisiere text";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(110, 28);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // alteArticoleToolStripMenuItem
            // 
            this.alteArticoleToolStripMenuItem.Name = "alteArticoleToolStripMenuItem";
            this.alteArticoleToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.alteArticoleToolStripMenuItem.Text = "Alte articole";
            this.alteArticoleToolStripMenuItem.Click += new System.EventHandler(this.alteArticoleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbeditura);
            this.Controls.Add(this.cbLivrare);
            this.Controls.Add(this.brAdaugare);
            this.Controls.Add(this.btCuratare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chAudio);
            this.Controls.Add(this.chCadou);
            this.Controls.Add(this.chMembru);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.apPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTitlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erLivrare)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.CheckBox chMembru;
        private System.Windows.Forms.CheckBox chCadou;
        private System.Windows.Forms.CheckBox chAudio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCuratare;
        private System.Windows.Forms.Button brAdaugare;
        private System.Windows.Forms.ComboBox cbLivrare;
        private System.Windows.Forms.TextBox tbeditura;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Titlu;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Valoare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ErrorProvider apPret;
        private System.Windows.Forms.ErrorProvider erTitlu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider erLivrare;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operatiiBinareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteArticoleToolStripMenuItem;
    }
}

