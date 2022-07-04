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
    public partial class FormEditare : Form
    { carte carte;
        public FormEditare(carte c)
        {//preluarea cartii actuale
            InitializeComponent();
            carte = c;
            //tbAutor.Text = c.autor;
            //tbeditura.Text = c.editura;
        

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // carte.titlu= tbTitlu.Text;
            int.TryParse(tbPret.Text, out int p);
            carte.pret = p;
            carte.valoare=carte.pret;
         carte.autor = tbAutor.Text;
            carte.titlu = tbTitlu.Text;

           
            carte.editura = tbeditura.Text;
            List<String> tip_achizitie = new List<string>();

            if (chCadou.Checked)
            {
                tip_achizitie.Add("Ambalaj cadou");
                carte.valoare += 10;
              

            }
            if (chAudio.Checked)
            {
                tip_achizitie.Add(" Versiune audio adaugata");
                carte.valoare += 7;

            }
            if (chMembru.Checked)
            {
                tip_achizitie.Add("Membru club de carte");
               carte. valoare -= carte.pret/10;

            }
            Livrare liv;
            int indexLiv = cbLivrare.SelectedIndex;
            if (indexLiv == 0)
            {
                liv = Livrare.Livrare_Curier;
                carte.valoare += 12;
            }
            else
            {liv = Livrare.Livrare_Posta;
                carte.valoare += 10;
            }
            carte.livrare = liv;
           /* float valoare = carte.pret;
            if (chAudio.Checked)
            {
                valoare += 7;
            }
            if (chCadou.Checked)
            {
                valoare += 10;
            }
            if (chMembru.Checked)
            {
                valoare -= carte.pret / 10;
            }
            if (cbLivrare.SelectedIndex.Equals(0))
            {
                valoare += 12;
            }
            if (cbLivrare.SelectedIndex.Equals(1))
            {
                valoare += 8;
            }*/


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditare_Load(object sender, EventArgs e)
        {
            //preluare info in formular editare
            tbPret.Text = carte.pret.ToString();
            tbeditura.Text = carte.editura;
            tbAutor.Text = carte.autor;
            tbTitlu.Text = carte.titlu;
            Livrare lic = carte.livrare;
            if(lic==Livrare.Livrare_Curier)
            {
                cbLivrare.SelectedIndex = 0;
            }
            if(lic==Livrare.Livrare_Posta)
            {
                cbLivrare.SelectedIndex = 1;
            }
            List<String> tip_achizitie = carte.tip_achizitie;
            //verificam selectiile

            if (tip_achizitie.Contains("Ambalaj cadou"))
            {
                chCadou.Checked=true;

            }
            if (tip_achizitie.Contains(" Versiune audio adaugata"))
            {
                chAudio.Checked = true;
               

            }
            if (tip_achizitie.Contains("Membru club de carte"))
            {
                chMembru.Checked = true;
              

            }

        }

        private void FormEditare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "x") 
            this.Close();
        }
    }
}
