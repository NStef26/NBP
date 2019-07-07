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
    public partial class SijaliceForma : Form
    {
        Sijalice temp;

        public SijaliceForma()
        {
            InitializeComponent();
        }

        public SijaliceForma(Sijalice o)
        {
            InitializeComponent();
            Init(o);
        }

        void Init(Sijalice f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            numVati.Value = f.Vati;
            comboBox1.SelectedIndex = (int)f.Tip;

            this.Text = "Azuriraj sijalice";
            button1.Text = "Azuriraj";
            temp = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            TipSijalice t = TipSijalice.Dugo;
            if (comboBox1.Text == "Dugo")
                t = TipSijalice.Dugo;
            if (comboBox1.Text == "Kratko")
                t = TipSijalice.Kratko;
            if (comboBox1.Text == "Maglenke")
                t = TipSijalice.Maglenke;
            if (comboBox1.Text == "Zmigavac")
                t = TipSijalice.Zmigavac;

            var collection = database.GetCollection<Sijalice>("Sijalice");

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Vati = (int)numVati.Value;
                temp.Tip = t;

                var query = Builders<Sijalice>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Sijalice su uspesno azurirane.");
            }
            else
            {
                Sijalice s = new Sijalice
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Vati = (int)numVati.Value,
                    Tip = t
                };

                collection.InsertOne(s);

                MessageBox.Show("Sijalice su uspesno dodate.");
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

        private void numVati_Leave(object sender, EventArgs e)
        {
            if (numVati.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numVati.Focus();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
            }
        }
    }
}
