using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{[Serializable]
    public class  Domeniu
    {   public int Id { get; set; }
        public String Denumire { get; set; }
        public String Descriere { get; set; }
        public int nrCarti { get; set; }
        public List<carte> carti { get; set; }
    }
}
