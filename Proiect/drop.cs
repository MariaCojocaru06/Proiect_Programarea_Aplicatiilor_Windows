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

namespace Proiect
{
    public partial class drop : Form
    {
        public drop()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] cale = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            foreach(String ca in cale)
            {
                string[] continut = File.ReadAllLines(ca);
                TreeNode rad = new TreeNode("Articole");
                treeView1.Nodes.Add(rad);
                foreach(string linie in continut)
                {
                    string[] cuvinte = linie.Split('\t');
                    TreeNode copil = new TreeNode(cuvinte[0]);
                    rad.Nodes.Add(copil);
                    TreeNode co1 = new TreeNode("Categorie "+cuvinte[0]);
                    copil.Nodes.Add(co1);
                    TreeNode co2 = new TreeNode("Marca "+cuvinte[1]);
                    copil.Nodes.Add(co2);
                    


                }
            
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            FormDomeniu d = new FormDomeniu();
            d.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void paginaPrincipalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDomeniu d = new FormDomeniu();
            d.Show();
            this.Hide();
            this.Close();
        }
    }
    }

