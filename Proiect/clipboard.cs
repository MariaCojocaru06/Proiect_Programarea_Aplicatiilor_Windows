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
    public partial class clipboard : Form
    {
        private Label label;
        private bool imageOnSrc = true;
        public clipboard()
        {
            InitializeComponent();
            //label = new Label();

            //label.Location = new Point(10, 10);
            //label.Text = "0";

            //this.Controls.Add(label);

           // Form1.sizeChanged += UpdateLabel;

            src.ImageLocation = "C:\\Users\\User\\Desktop\\poza.jpg";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageOnSrc)
            {
                Clipboard.SetImage(src.Image);

                dst.Image = Clipboard.GetImage();
                src.Image = null;

                imageOnSrc = false;
            }
            else
            {
                Clipboard.SetImage(dst.Image);

                src.Image = Clipboard.GetImage();
                dst.Image = null;

                imageOnSrc = true;
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            textBox1.Clear();
        }

        private void paginaPrincipalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDomeniu d = new FormDomeniu();
            d.Show();
            this.Hide();
            this.Close();
        }
    }
    }

    
