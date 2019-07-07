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
    public partial class AkumulatorForma : Form
    {
        private Akumulatori temp;

        public AkumulatorForma()
        {
            InitializeComponent();
        }

        public AkumulatorForma(Akumulatori a)
        {
            InitializeComponent();
            Init(a);
        }

        private void Init(Akumulatori a)
        {
            numCena.Value = (decimal)a.Cena;
            numKolicina.Value = (int)a.Kolicina;
            tBoxDim.Text = a.Dimenzije;
            numKapacitet.Value = a.Kapacitet;
            numKolicina.Value = a.Kolicina;
            numVoltaza.Value = a.Voltaza;
            numSnaga.Value = a.Snaga;

            this.Text = "Azuriraj akumulator";
            button1.Text = "Azuriraj";
            temp = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Akumulatori>("Akumulator");
           
            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = "";
                temp.Marka = "";
                temp.Voltaza = (int)numVoltaza.Value;
                temp.Kapacitet = (int)numKapacitet.Value;
                temp.Snaga = (int)numSnaga.Value;
                temp.Dimenzije = tBoxDim.Text;
                var query = Builders<Akumulatori>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Akumulator je uspesno azuriran!");

            }
            else
            {
                Akumulatori a = new Akumulatori
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Model = "",
                    Marka = "",
                    Voltaza = (int)numVoltaza.Value,
                    Kapacitet = (int)numKapacitet.Value,
                    Snaga = (int)numSnaga.Value,
                    Dimenzije = tBoxDim.Text
                };
                collection.InsertOne(a);

                MessageBox.Show("Akumulator je uspesno dodat!");
            }

            this.Close();
        }

        private void numCena_Leave(object sender, EventArgs e)
        {
            if(numCena.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno","Poruka",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

        private void numVoltaza_Leave(object sender, EventArgs e)
        {
            if (numVoltaza.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numVoltaza.Focus();
            }
        }

        private void numKapacitet_Leave(object sender, EventArgs e)
        {
            if (numKapacitet.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKapacitet.Focus();
            }
        }

        private void numSnaga_Leave(object sender, EventArgs e)
        {
            if (numSnaga.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSnaga.Focus();
            }
        }

        

        private void tBoxDim_Leave(object sender, EventArgs e)
        {
            if (tBoxDim.Text == "")
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxDim.Focus();
            }
        }
    }
}
