using Autoshop.Komponente;
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

namespace Autoshop.Forme_za_dodavanje
{
    public partial class BrisacForma : Form
    {

        private Brisaci temp;

        public BrisacForma()
        {
            InitializeComponent();
        }

        public BrisacForma(Brisaci o)
        {
            InitializeComponent();
            Init(o);

        }

        private void Init(Brisaci o)
        {
            numCena.Value = (decimal)o.Cena;
            numKolicina.Value = o.Kolicina;
            tBoxMarka.Text = o.Marka;
            tBoxModel.Text = o.Model;
            tBoxDimenzija.Text = o.Dimenzija;
            cBoxTip.SelectedIndex = (int)o.Tip;

            this.Text = "Azuriraj brisace";
            this.button1.Text = "Azuriraj";
            temp = o;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Brisaci>("Brisaci");

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Dimenzija = tBoxDimenzija.Text;
                temp.Tip = cBoxTip.Text == "Prednji" ? Tip.Prednji : Tip.Zadnji;

                var query = Builders<Brisaci>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Brisac je uspesno azuriran.");
            }
            else
            {
                Brisaci b = new Brisaci
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Dimenzija = tBoxDimenzija.Text,
                    Tip = cBoxTip.Text == "Prednji" ? Tip.Prednji : Tip.Zadnji
                };

                collection.InsertOne(b);

                MessageBox.Show("Brisac je uspesno dodat.");
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

        private void tBoxModel_Leave(object sender, EventArgs e)
        {
            if(tBoxModel.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               tBoxModel.Focus();
            }
        }

        private void tBoxMarka_TextChanged(object sender, EventArgs e)
        {
            if (tBoxMarka.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxMarka.Focus();
            }
        }

        private void tBoxDimenzija_TextChanged(object sender, EventArgs e)
        {
            if (tBoxDimenzija.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxDimenzija.Focus();
            }
        }

        private void cBoxTip_Leave(object sender, EventArgs e)
        {
            if(cBoxTip.SelectedIndex == -1)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBoxTip.Focus();
            }
        }
    }
}
