using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autoshop.Komponente;

namespace Autoshop.Forme_za_dodavanje
{
    public partial class FaroviForma : Form
    {
        private Farovi temp;

        public FaroviForma()
        {
            InitializeComponent();
        }

        public FaroviForma(Farovi o)
        {
            InitializeComponent();
            Init(o);
        }

        private void Init(Farovi f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            tBoxOpis.Text = f.Opis;

            this.Text = "Azuriraj farove";
            button1.Text = "Azuriraj";
            temp = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Farovi>("Farovi");

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Opis = tBoxOpis.Text;

                var query = Builders<Farovi>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Farovi su uspesno azurirani.");
            }
            else
            {
                Farovi f = new Farovi
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Opis = tBoxOpis.Text
                };

                collection.InsertOne(f);

                MessageBox.Show("Farovi su uspesno dodati.");
            }

            this.Close();

        }

        private void numCena_Leave(object sender, EventArgs e)
        {
            if (numCena.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCena.Focus();
            }
        }

        private void numKolicina_Leave(object sender, EventArgs e)
        {
            if (numKolicina.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKolicina.Focus();
            }
        }

       

        private void tBoxMarka_Leave(object sender, EventArgs e)
        {
            if (tBoxMarka.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxMarka.Focus();
            }
        }

        private void tBoxModel_Leave(object sender, EventArgs e)
        {
            if (tBoxModel.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxModel.Focus();
            }
        }

        private void tBoxOpis_Leave(object sender, EventArgs e)
        {
            if (tBoxOpis.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxOpis.Focus();
            }
        }
    }
}
