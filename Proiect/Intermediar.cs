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
    public partial class Intermediar : Form
    {
        public Intermediar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drop d = new drop();
            this.Hide();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            clipboard c = new clipboard();
            c.Show();
            this.Close();
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormDomeniu d = new FormDomeniu();
            d.Show();
            this.Close();
            this.Hide();
            
        }
    }
    }

