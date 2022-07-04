using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHistrograma
{
    public partial class Histograma : UserControl
    {
        public Coloana[] Data;
        Graphics g;

        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;

        const int marg = 10;
        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        //public Histograma()
        //{
        //    InitializeComponent();
        //}
        public Histograma(Coloana[] par)
        {
            InitializeComponent();
            ResizeRedraw = true;
            Data = par;
        }

        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rect = e.ClipRectangle;
            float max = 0;
            foreach (Coloana c in Data)
            {
                if (c.pret > max)
                {
                    max = c.pret;
                }
            }
            float scalare = rect.Height / max;
            float inaltime = rect.Width * 0.9f;
            float latime = (rect.Height - 300) / Data.Length;
            for (int i = 0; i < Data.Length; i++)
            {
                Coloana c = Data[i];
                float inal = c.pret * scalare;
                graphics.FillRectangle(new SolidBrush(Color.FromName(c.color)),
                    i * latime, rect.Height - inal, latime * 0.9f, inal);
            }
            int x = rect.Width - 50;
            int y = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                Coloana c = Data[i];
                graphics.FillRectangle(new SolidBrush(Color.FromName(c.color)),
                    x, y, 35, 35);
                graphics.DrawString(c.label + ":" + c.pret, new Font("Consolas", 8), new SolidBrush(Color.FromName(c.color)), x + 35, y + 20);
                y += 40;
            }


            //    Graphics gr = e.Graphics;
            //Rectangle rec = e.ClipRectangle;
            //    //Rectangle rec = new Rectangle(this.ClientRectangle.X + marg, this.ClientRectangle.Y + 4 * marg,
            //    //    this.ClientRectangle.Width - 2 * marg, this.ClientRectangle.Height - 5 * marg);
            //    Pen pen = new Pen(Color.Red, 3);
            //    gr.DrawRectangle(pen, rec);

            //    double latime = rec.Width / Data.Length / 3;
            //    double distanta = (rec.Width - Data.Length * latime) / (Data.Length + 1);
            //    double vMax = vect.Max();

            //    Brush br = new SolidBrush(culoare);

            //    Rectangle[] recs = new Rectangle[Data.Length];
            //  ///  for (int i = 0; i < nrElem; i++)
            //        for (int i = 0; i < Data.Length; i++)
            //        {
            //        recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
            //            (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
            //            (int)latime,
            //            (int)(vect[i] / vMax * rec.Height));
            //       // gr.FillEllipse(br, recs[i]);

            //        gr.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X,
            //            recs[i].Location.Y - font.Height));
            //    }
            //    //gr.FillRectangles(br, recs);

            //    // for (int i = 0; i < nrElem - 1; i++)
            //    for (int i = 0; i < Data.Length-1; i++)
            //        gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)recs[i].Location.Y),
            //            new Point((int)(recs[i + 1].Location.X + latime / 2), (int)recs[i + 1].Location.Y));

        }
    }
}
