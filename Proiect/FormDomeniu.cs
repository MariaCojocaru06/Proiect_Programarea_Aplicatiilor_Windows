using BibliotecaHistrograma;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormDomeniu : Form
    {
        DomContextcs dom = new DomContextcs();
        List<carte> listaCarti = new List<carte>();
        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;

        const int marg = 10;

        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Func<ChartPoint, string> label = chartpo => string.Format("{0} ({1:P)", chartpo.Y, chartpo.Participation);
        public FormDomeniu()
        {
            InitializeComponent();
        }

        private void FormDomeniu_Load(object sender, EventArgs e)
        {
            domeniuBindingSource.DataSource = dom.Domenii.ToList();
            //pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void brAdaugare_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                //editare
                Domeniu domeniu = domeniuBindingSource.Current as Domeniu;
                domeniu.Denumire = tbDenumire.Text;
                domeniu.Descriere = tbDescriere.Text;
                domeniu.nrCarti = int.Parse(tbnr.Text);
                dom.Domenii.Update(domeniu);

            }
            else
            {//adaugare 
                Domeniu domeniu = new Domeniu();
                domeniu.Denumire = tbDenumire.Text;
                domeniu.Descriere = tbDescriere.Text;
                domeniu.nrCarti = int.Parse(tbnr.Text);
                dom.Domenii.Add(domeniu);

            }
            dom.SaveChanges();
            domeniuBindingSource.DataSource = dom.Domenii.ToList();
        }

        private void btCuratare_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi? ", "stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    dom.Domenii.Remove(domeniuBindingSource.Current as Domeniu);
                    dom.SaveChanges();
                    domeniuBindingSource.DataSource = dom.Domenii.ToList();
                }
            }
        }
        #region Printare
        private void toolStripPrintare_Click(object sender, EventArgs e)
        {

            pageSetupDialog1.Document = printDocument1;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics grafic = e.Graphics;
            Font font = new Font("Arial", 20);

            Brush brush = Brushes.DarkOrchid; //clasa abstracta fara constructor
            Pen pen = new Pen(brush);
            PageSettings pageSettings = printDocument1.DefaultPageSettings;
            //suprafata desenabila
            var latime = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            var inaltime = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;

            if (pageSettings.Landscape)
            {
                var temp = inaltime;
                inaltime = latime;
                latime = inaltime;
            }

            int celulaL = latime / 2;
            int celulaI = 40;
            int x = pageSettings.Margins.Left;
            int y = 100;

            grafic.DrawString("Lista domenii", font, brush, x, y);

            //generare tabel
            grafic.DrawRectangle(pen, x, y, celulaL, celulaI);
            grafic.DrawRectangle(pen, x + celulaL, y, celulaL, celulaI);

            grafic.DrawString("Denumire: ", font, brush, x, y);
            grafic.DrawString(" Numar carti: ", font, brush, x + celulaL, y);
            y += celulaI;


            //preluare departamente lista 
            List<Domeniu> domenii = dom.Domenii.ToList();
            foreach (Domeniu d in domenii)
            {
                grafic.DrawRectangle(pen, x, y, celulaL, celulaI);
                grafic.DrawRectangle(pen, x + celulaL, y, celulaL, celulaI);

                grafic.DrawString(d.Denumire, font, brush, x, y);
                grafic.DrawString(d.nrCarti.ToString(), font, brush, x + celulaL, y);
                y += celulaI;
            }

        }
        #endregion

        private void toolStripGrafic_Click(object sender, EventArgs e)
        {
           
        }
    
    

        //private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        //{

        //}

        private void Adauga_carti_Click(object sender, EventArgs e)
        {
            Form1 formularCarti = new Form1(listaCarti);
            int i = 0;
            if(formularCarti.ShowDialog()==DialogResult.Cancel)
            { //alocare mem
                String[] denumire = new string[listaCarti.Count];
            foreach(carte c in listaCarti)
                {
                    denumire[i] = c.titlu;
                    i++;
                }
                listBox1.DataSource = denumire;
                tbnr.Text = listaCarti.Count.ToString();
                comboBox1.DataSource = denumire;
            }
        }

        private void btnStatistica_Click(object sender, EventArgs e)
        {
            Coloana[] hist = new Coloana[listaCarti.Count];
            int index = 0;
            string[] culori = { "blue", "white", "red", "green", "purple", "black" };
            foreach(carte c in listaCarti)
            {
                hist[index] = new Coloana(c.autor, c.pret, culori[index]);
                index++;

            }
            Histograma his = new Histograma(hist);
            his.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Intermediar d = new Intermediar();
            this.Hide();
            d.ShowDialog();
        }
    } 
}
