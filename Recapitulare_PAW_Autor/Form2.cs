using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recapitulare_PAW_Autor
{
    public partial class Form2 : Form
    {
        public Carte carte {  get; set; } //doar prin intermediul adaugarii cartii aici putem adauga in formularul principal, asigura accesul public la carte
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string id;
            string denumire;
            DateTime dataLansare;
            float pret = 0; //rescriem atributele cartii fara private in fata

            id = tb_id.Text; //luam datele din formular din tb, cb sau ce mai exista
            denumire = tb_denumire.Text;
            dataLansare = DateTime.Parse(dtp_dataLansare.Text);
            if (float.Parse(clb_Pret.SelectedItems[0].ToString()) > 0)
            {
                pret = float.Parse(clb_Pret.SelectedItems[0].ToString());

            }

            carte = new Carte(id, denumire, dataLansare, pret); //in cartea creata mai sus(la inceput) adaugam o carte noua care contine elementele citite din forms

            DialogResult = DialogResult.OK; //obtine raspunsul cancel din partea dialogului
            Close(); //inchidem formularul
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //obtine raspunsul cancel din partea dialogului
            Close(); //inchidem formularul
        }
    }
}
