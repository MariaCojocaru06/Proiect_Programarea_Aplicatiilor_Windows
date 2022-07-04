using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public  abstract class Articol
    {public int Id { get; set; }

        private int cod { get; set; }
        private String denumire { get; set; }
        public  float pret { get; set; }
       

        public Articol(int cod)
        {
            this.cod = cod;
        }

        public Articol(int cod, string denumire, float pret) : this(cod)
        {
            this.denumire = denumire;
            this.pret = pret;
           
        }
        public Articol()
        {

        }
        public abstract String GetDetalii();
        public virtual String GetDenumire()
        {
            return "nedenumit";
        }
    }

}

