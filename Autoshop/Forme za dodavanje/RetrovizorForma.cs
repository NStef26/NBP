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
    public partial class RetrovizorForma : Form
    {
        Retrovizor temp;

        public RetrovizorForma()
        {
            InitializeComponent();
        }

        public RetrovizorForma(Retrovizor o)
        {
            InitializeComponent();
            Init(o);
        }

        void Init(Retrovizor f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            comboBox1.SelectedIndex = (int)f.Tip;

            this.Text = "Azuriraj retrovizor";
            button1.Text = "Azuriraj";
            temp = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Retrovizor>("Retrovizor");

            TipRetrovizora t = TipRetrovizora.Desni;

            if (comboBox1.Text == "Desni")
                t = TipRetrovizora.Desni;
            if (comboBox1.Text == "Levi")
                t = TipRetrovizora.Levi;
            if (comboBox1.Text == "Unutrasnji")
                t = TipRetrovizora.Unutrasnji;

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Tip = t;

                var query = Builders<Retrovizor>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Retrovizor je uspesno azuriran.");
            }
            else
            {
                Retrovizor r = new Retrovizor
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Tip = t
                };

                collection.InsertOne(r);

                MessageBox.Show("Retrovizor je uspesno dodat.");
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
