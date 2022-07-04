using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistrograma
{
  public  class Coloana
    {
        public string label { get; set; }
        public float pret { get; set; }
        public string color { get; set; }

        public Coloana(string label, float pret, string color)
        {
            this.label = label;
            this.pret = pret;
            this.color = color;
        }
    }
}
