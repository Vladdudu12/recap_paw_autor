using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulare_PAW_Autor
{
    [Serializable] //sa nu uit sa scrii serializable daca ai nevoie de citire/scriere binara la clasa
    public class Autor:ICalculPret
    {
        private string id;
        private string nume;
        private DateTime dataNasterii;
        BindingList<Carte> cartiPublicate;

        public Autor()
        {
        }

        public Autor(BindingList<Carte> cartiPublicate, string id = "-", string nume = "-", DateTime dataNasterii = new DateTime())
        {
            this.id = id;
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.cartiPublicate = new BindingList<Carte>();
            foreach (Carte carte in cartiPublicate)
            {
                this.cartiPublicate.Add(carte);
            }
        }
        public string Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public BindingList<Carte> CartiPublicate { get => cartiPublicate; set => cartiPublicate = value; }

        public float calculeazaPretTotal()
        {
            float suma = 0;
            foreach(Carte carte in cartiPublicate)
            {
                suma = suma + carte.Pret;
            }
            return suma;
        }

        public static Autor operator+(Autor autor, Carte carte)
        {
            autor.cartiPublicate.Add(carte);
            return autor;
        }
    }
}
