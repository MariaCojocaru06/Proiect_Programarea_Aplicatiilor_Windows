namespace Proiect
{
    partial class clipboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clipboard));
            this.src = new System.Windows.Forms.PictureBox();
            this.dst = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaPrincipalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // src
            // 
            this.src.BackColor = System.Drawing.Color.Transparent;
            this.src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.src.ErrorImage = null;
            this.src.Location = new System.Drawing.Point(70, 38);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(238, 321);
            this.src.TabIndex = 0;
            this.src.TabStop = false;
            // 
            // dst
            // 
            this.dst.BackColor = System.Drawing.Color.Transparent;
            this.dst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dst.Location = new System.Drawing.Point(579, 38);
            this.dst.Name = "dst";
            this.dst.Size = new System.Drawing.Size(238, 321);
            this.dst.TabIndex = 1;
            this.dst.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(369, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "schimbare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(546, 413);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(112, 27);
            this.copy.TabIndex = 3;
            this.copy.Text = "copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Location = new System.Drawing.Point(546, 448);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(112, 27);
            this.paste.TabIndex = 4;
            this.paste.Text = "paste";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(54, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sursa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(54, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destinatie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaPrincipalaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaPrincipalaToolStripMenuItem
            // 
            this.paginaPrincipalaToolStripMenuItem.Name = "paginaPrincipalaToolStripMenuItem";
            this.paginaPrincipalaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.paginaPrincipalaToolStripMenuItem.Text = "Pagina Principala";
            this.paginaPrincipalaToolStripMenuItem.Click += new System.EventHandler(this.paginaPrincipalaToolStripMenuItem_Click);
            // 
            // clipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 525);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dst);
            this.Controls.Add(this.src);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "clipboard";
            this.Text = "clipboard";
            ((System.ComponentModel.ISupportInitialize)(this.src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox src;
        private System.Windows.Forms.PictureBox dst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaPrincipalaToolStripMenuItem;
    }
}