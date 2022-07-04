using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    
    public class carte : Articol,ICloneable
    {[NotMapped] public List<string> tip_achizitie { get; set; }
       public int Id { get; set; }
        public int Domeniu_ID { get; set; }

        public String titlu { get; set; }
       public String autor { get; set; }
        public DateTime an_aparitie { get; set; }
      //  public Domeniu domeniu { get; set; }
        public Livrare livrare { get; set; }
        public string editura { get; set; }
        public  float valoare { get; set; }
        public carte()
        {

        }
        
        public override string GetDetalii()
        {
            return $"{ this.titlu} are autorul {this.autor}";
        }

        public carte(List<string> tip_achizitie,string editura, string titlu, string autor,
            DateTime an_aparitie)
        {
            this.tip_achizitie = tip_achizitie;
            this.titlu = titlu;
            this.autor = autor;
            this.editura = editura;
            this.an_aparitie = an_aparitie;
           
        }

        public carte(List<string> tip_achizitie, string editura, string titlu, string autor,float pret)
        {
            this.tip_achizitie = tip_achizitie;
            this.titlu = titlu;
            this.autor = autor;
            this.editura = editura;
            this.pret = pret;

            //switch (tip_achizitie.ToArray())
            //{
            //    case 1:
            //        this.tip_achizitie[0]
            
            
            
            //}




        }
        public Object Clone()
        {
            carte clona = new carte
            { titlu = this.titlu,
                autor = this.autor,
                an_aparitie = this.an_aparitie,
                editura=this.editura,
                tip_achizitie=new List<string>()

            };
            foreach(String tip in this.tip_achizitie)
            {
                clona.tip_achizitie.Add(tip);
            }
            return clona;
        }
    }
}
