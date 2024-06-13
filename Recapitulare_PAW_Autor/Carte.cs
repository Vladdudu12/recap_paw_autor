using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulare_PAW_Autor
{
    public class Carte:ICloneable, IComparable<Carte>
    {
        private string id;
        private string denumire;
        private DateTime dataLansare;
        private float pret;

        public Carte()
        {
        }

        public Carte(string id = "-", string denumire = "-", DateTime dataLansare = new DateTime(), float pret = 0)
        {
            this.id = id;
            this.denumire = denumire;
            this.dataLansare = dataLansare;
            this.pret = pret;
        }

        public string Id { get => id; set => id = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public DateTime DataLansare { get => dataLansare; set => dataLansare = value; }
        public float Pret { get => pret; set => pret = value; }

        public object Clone()
        {
            Carte copie = new Carte();
            copie.id = this.id;
            copie.denumire = this.denumire;
            copie.dataLansare = this.dataLansare;
            copie.pret = this.pret;
            return copie;
        }

        public int CompareTo(Carte other)
        {
            if(this == other)
            {
                return 0;
            }
            else if(this.pret > other.pret)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
