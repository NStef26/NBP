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
    public partial class DodatnaForma : Form
    {
        private DodatnaOprema temp;

        public DodatnaForma()
        {
            InitializeComponent();
        }
        public DodatnaForma(DodatnaOprema o)
        {
            InitializeComponent();
            Init(o);
        }

        private void Init(DodatnaOprema d)
        {
            numCena.Value = (decimal)d.Cena;
            numKolicina.Value = d.Kolicina;
            tBoxMarka.Text = d.Marka;
            tBoxModel.Text = d.Model;
            tBoxOpis.Text = d.Opis;
            comboBox1.SelectedIndex = (int)d.Tip;

            this.Text = "Azuriraj dodatnu opremu";
            button1.Text = "Azuriraj";
            temp = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            TipOpreme t = TipOpreme.PrvaPomoc;

            if (comboBox1.Text == "Prva Pomoc")
                t = TipOpreme.PrvaPomoc;
            if (comboBox1.Text == "Patosnica")
                t = TipOpreme.Patosnica;
            if (comboBox1.Text == "Presvlaka")
                t = TipOpreme.Presvlaka;

            var collection = database.GetCollection<DodatnaOprema>("Dodatna Oprema");

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Opis = tBoxOpis.Text;
                temp.Tip = t;

                var query = Builders<DodatnaOprema>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Dodatna oprema je uspesno azurirana.");
            }
            else
            {
                DodatnaOprema d = new DodatnaOprema
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Opis = tBoxOpis.Text,
                    Tip = t
                };

                collection.InsertOne(d);

                MessageBox.Show("Dodatna oprema je uspesno sacuvana.");
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

        private void tBoxModel_TextChanged(object sender, EventArgs e)
        {
            if (tBoxModel.Text == "")
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

        private void tBoxOpis_TextChanged(object sender, EventArgs e)
        {
            if (tBoxOpis.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxOpis.Focus();
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
