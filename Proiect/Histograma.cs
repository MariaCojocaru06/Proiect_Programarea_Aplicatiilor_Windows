using BibliotecaHistrograma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Histograma : Form
    {
        public Histograma(Coloana[] col)
        {
            InitializeComponent();
            BibliotecaHistrograma.Histograma histograma = new BibliotecaHistrograma.Histograma(col);

            histograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            histograma.Location = new System.Drawing.Point(13, 13);
            histograma.Name = "histograma1";
            histograma.Size = new System.Drawing.Size(775, 425);
            histograma.TabIndex = 0;

            this.Controls.Add(histograma);
        }
    }
}
