using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{//ob de tip: pix, agenda
    [Serializable]
    public class ALte : Articol, ICloneable
    {
        private string categorie { get; set; }
        private string marca { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override String GetDetalii()
        {
            return $" produsul din categoria {categorie} are marca {marca}";
        }
    }
}
