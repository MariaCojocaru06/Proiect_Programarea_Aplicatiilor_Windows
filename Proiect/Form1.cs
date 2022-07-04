using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        List<carte> listaCarti = null;
        public Form1()
        {
            InitializeComponent();
            listaCarti = new List<carte>();
        }
        public Form1(List<carte> lista)
        {
            InitializeComponent();
            listaCarti = lista;

        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
        }

        private void btCuratare_Click(object sender, EventArgs e)
        {
            tbAutor.Clear();
            tbPret.Clear();
            tbTitlu.Clear();
            tbeditura.Clear();
            cbLivrare.SelectedIndex = -1;
            //checkurile iau valoarea fals ca fiind nebifate
            chAudio.Checked = false;
            chCadou.Checked = false;
            chMembru.Checked = false;

        }

        private void brAdaugare_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string titlu = tbTitlu.Text;
            if (String.IsNullOrEmpty(titlu) || titlu.Length < 3)
                valid = false;
            try
            {
                int _pret = int.Parse(tbPret.Text);
            }
            catch (Exception)
            {
                valid = false;
            }
            int.TryParse(tbPret.Text, out int pret);
            { if (pret < 1)
                    valid = false;

            }
            string autor = tbAutor.Text;

            if (String.IsNullOrEmpty(autor) || autor.Length < 3)
                valid = false;

            string editura = tbeditura.Text;
            List<String> tip_achizitie = new List<string>();

            if (chCadou.Checked)
            {
                tip_achizitie.Add("Ambalaj cadou");

            }
            if (chAudio.Checked)
            {
                tip_achizitie.Add(" Versiune audio adaugata");

            }
            if (chMembru.Checked)
            {
                tip_achizitie.Add("Membru club de carte");

            }
            Livrare liv;
            int indexLiv = cbLivrare.SelectedIndex;
            if (indexLiv == 0)
            {
                liv = Livrare.Livrare_Curier;
            }
            else
            { liv = Livrare.Livrare_Posta; }
            if (valid)
            {
                carte c = new carte(tip_achizitie, editura, titlu, autor, pret);
                c.livrare = liv;
                //adaugare obiect in lista generala
                listaCarti.Add(c);

                populeazaListView();
                btCuratare_Click(sender, e);
                MessageBox.Show("Instanta creata cu succes!", "Succes",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                // mesaj de eroare
                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }


        }
        private void PopuleazaListView()
        {

        }

        private void populeazaListView()
        {
            //curatam
            listView1.Items.Clear();
            // adaugare
            foreach (carte c in listaCarti)
            {
                c.valoare = c.pret;
                if (chAudio.Checked)
                {
                    c.valoare += 7;
                }
                if (chCadou.Checked)
                {
                    c.valoare += 10;
                }
                if (chMembru.Checked)
                {
                    c.valoare -= c.pret / 10;
                }
                if (cbLivrare.SelectedIndex.Equals(0))
                {
                    c.valoare += 12;
                }
                if (cbLivrare.SelectedIndex.Equals(1))
                {
                    c.valoare += 8;
                }
                ListViewItem lv1 = new ListViewItem(new String[] { c.titlu, c.autor, c.pret.ToString(), c.valoare.ToString() });
                lv1.Tag = c;
                listView1.Items.Add(lv1);

            }
        }

        private void populeazaListView1()
        {
            //curatam
            listView1.Items.Clear();
            // adaugare
            foreach (carte c in listaCarti)
            {

                ListViewItem lv1 = new ListViewItem(new String[] { c.titlu, c.autor, c.pret.ToString(), c.valoare.ToString() });
                lv1.Tag = c;
                listView1.Items.Add(lv1);

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region valitatori
        private void tbPret_Validated(object sender, EventArgs e)
        {
            apPret.Clear();
        }

        private void tbPret_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int _pret = int.Parse(tbPret.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ero");
            }
            int.TryParse(tbPret.Text, out int pret);
            
            if (pret < 1)
            {
                apPret.SetError(tbPret, "Pretul trebuie sa fie mai mare de 1 leu");

                e.Cancel = true;
            }

        }

        private void tbTitlu_Validated(object sender, EventArgs e)
        {
            erTitlu.Clear();
        }

        private void tbTitlu_Validating(object sender, CancelEventArgs e)
        {
            string titlu = tbTitlu.Text;
            if (String.IsNullOrEmpty(titlu) || titlu.Length < 3)
            {
                erTitlu.SetError(tbTitlu, "Titlul trebuie sa aiba mai mult de 3 caractere")
           ;
                e.Cancel = true;
            }
        }

        private void cbLivrare_Validated(object sender, EventArgs e)
        {
            erLivrare.Clear();

        }

        private void cbLivrare_Validating(object sender, CancelEventArgs e)
        {
            if (cbLivrare.SelectedIndex.CompareTo(1) == 0 && cbLivrare.SelectedIndex.CompareTo(0) == 0)
            {
                erLivrare.SetError(cbLivrare, "Trebuie selectata  o modalitate de livrare");
                e.Cancel = true;

            }
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {//
            if (listView1.SelectedItems.Count != 0)
            {
                MessageBox.Show("Doresti sa stergi cartea?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
;
                carte c = listView1.SelectedItems[0].Tag as carte;
                listaCarti.Remove(c);

                populeazaListView1();
            }
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            //testam selectie
            if (listView1.SelectedItems.Count != 0)
            {//poxitionare in lista
                carte c = listaCarti.ElementAt(listView1.SelectedIndices[0]);
                //adaugam noul formular
                //transmitere ob actual ca parametru
                FormEditare editare = new FormEditare(c);
                DialogResult dialog = editare.ShowDialog();
                //  if(dialog==DialogResult.OK)
                {

                    /// listView1.Items( valoare.ToString());


                    populeazaListView1();

                }

            }



        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                listView1.FocusedItem.Bounds.Contains(e.Location))

            {
                btnEditare_Click(sender, e);
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        { if (listaCarti == null)
            {
                MessageBox.Show("invalid");

            }
            else { 
            BinaryFormatter format = new BinaryFormatter();
            FileStream stream = new FileStream("binar.dat", FileMode.Create);
            format.Serialize(stream, listaCarti);
            stream.Close();
            MessageBox.Show("Fisierul binar a fost salvat");
        } }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter format = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul binar";
            ofd.Filter= "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                listaCarti = format.Deserialize(stream) as List<carte>;
                stream.Close();
                populeazaListView1();

            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control&&e.KeyCode.ToString()=="X")
            {
                MessageBox.Show("inchidere");
                this.Close();


            }
           
                if (e.Control && e.KeyCode.ToString() == "D")
                {
                if (listView1.SelectedItems.Count != 0)
                {
                    MessageBox.Show("Doresti sa stergi cartea?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    ;
                    carte c = listView1.SelectedItems[0].Tag as carte;
                    listaCarti.Remove(c);

                    populeazaListView1();
                }

            }
            
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);

                writer.WriteLine("Titlu:  Autor:  Pret: Editura:  ");
                foreach (carte p in listaCarti)
                {
                    writer.WriteLine(p.titlu + " " + p.autor + " " + p.pret+" "+p.editura);
                }

                writer.Close();
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul";
            ofd.Filter= "Text files(*.txt)| *.txt | All files(*.*) | *.* ";
            ofd.FilterIndex = 1;
            //descj=hidere
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                listaCarti.Clear();
                StreamReader stream = new StreamReader(ofd.FileName);
                String linie = stream.ReadLine();
                while ((linie = stream.ReadLine() )!= null)
                {
                    try
                        //preluare per element
                    { String[] token = linie.Split(' ');
                        carte c = new carte();
                        c.titlu = token[0];
                        c.autor = token[1];
                        c.pret = int.Parse(token[2]);
                        c.editura = token[3];
                        listaCarti.Add(c);

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    stream.Close();
                    populeazaListView1();
                }
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            FormDomeniu d = new  FormDomeniu();
            this.Hide();
            d.Show();
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void alteArticoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intermediar d = new Intermediar();
            this.Hide();
            d.ShowDialog();
        }
    }
}
