using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recapitulare_PAW_Autor
{
    public partial class Form1 : Form
    {
        Autor autor; //cream un autor
        public Form1()
        {
            InitializeComponent();
            BindingList<Carte> listaCarti = new BindingList<Carte>(); //cream un binding list nou OBLIGATORIU LA GRID
            autor = new Autor(listaCarti, "1", "Gabivas", new DateTime(1999, 5, 27)); //dam o valoare default la autor

            dataGridView1.DataSource = autor.CartiPublicate; //numele gridului.DataSource ia valoarea listei de carti publicate din autor OBLIGATORIU LA GRID
        }

        private void btn_CalculeazaPret_Click(object sender, EventArgs e)
        {
            BindingList<Carte> listaCarti = new BindingList<Carte>();
            listaCarti.Add(new Carte("1", "Morometii", new DateTime(1900, 11, 1), 15));
            listaCarti.Add(new Carte("2", "Moara cu noroc", new DateTime(1800, 11, 1), 16));
            
            Autor autor = new Autor(listaCarti, "1", "Ion Creanga", new DateTime(1987, 12, 13));
            autor += new Carte("3", "Harap-Alb", new DateTime(1680, 9, 9), 9);

            float pretTotal = autor.calculeazaPretTotal();
            string mesaj = $"Autorul {autor.Nume} are carti in valoare de {pretTotal} de lei.";
            MessageBox.Show(mesaj);

        }

        private void btn_adaugaCarte_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //cream formularul 2 ca sa il putem deschide
            if(form2.ShowDialog() == DialogResult.OK) //rezultatul trebuie sa fie dialogResult.OK
            {
                autor += form2.carte; //adaugam in lista din autor cartea facuta in form2 (de asta am facut cartea publica la inceput)
                lv_carti.Items.Clear(); //dam refresh la ce avem in listview
                foreach(Carte carte in autor.CartiPublicate) //trecem prin toata lista de carti din autor
                {
                    ListViewItem itm = new ListViewItem(carte.Id); 
                    itm.SubItems.Add(carte.Denumire);
                    itm.SubItems.Add(carte.DataLansare.ToString());
                    itm.SubItems.Add(carte.Pret.ToString()); //adaugam ca ListViewItem / SubItems atributele cartii

                    lv_carti.Items.Add(itm); //adaucam in tabela randul format
                }
                MessageBox.Show("S-a adaugat cartea!");
            }
            else
            {
                MessageBox.Show("Nu s-a adaugat nicio carte!");
            }

        }

        private void serializateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) //OBLIGATORIU verificam ca DialogResult sa fie OK
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write); //cream un fileStream
                BinaryFormatter formatter = new BinaryFormatter(); //cream un binaryFormatter
                formatter.Serialize(fileStream, autor); //serializam formatterul
                fileStream.Close(); //inchidem fileStream ul creat

            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Deserialize(fileStream); //identic ca la serializare, doar ca desrializam formatterul ++SA NU UITI SA SCRII SERIALIZABLE LA CLASA
                fileStream.Close();
            }
        }
    }
}
