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
    public partial class PneumaticiForma : Form
    {
        Pneumatici temp;

        public PneumaticiForma()
        {
            InitializeComponent();
        }

        public PneumaticiForma(Pneumatici o)
        {
            InitializeComponent();
            Init(o);
        }

        void Init(Pneumatici f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            tBoxDimenzije.Text = f.Dimenzije;
            cBoxTip.SelectedIndex = (int)f.Tip;
            cBoxStanje.SelectedIndex = (int)f.Stanje;

            this.Text = "Azuriraj pneumatike";
            button1.Text = "Azuriraj";
            temp = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            TipGuma t = TipGuma.Letnje;
            if (cBoxTip.Text == "Letnje")
                t = TipGuma.Letnje;
            if (cBoxTip.Text == "Zimske")
                t = TipGuma.Zimske;
            if (cBoxTip.Text == "MS")
                t = TipGuma.MS;

            var collection = database.GetCollection<Pneumatici>("Pneumatici");

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Dimenzije = tBoxDimenzije.Text;
                temp.Tip = t;
                temp.Stanje = cBoxStanje.Text == "Novi" ? Stanje.Novi : Stanje.Polovni;

                var query = Builders<Pneumatici>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Pneumatici su uspesno azurirani.");
            }
            else
            {
                Pneumatici p = new Pneumatici
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Dimenzije = tBoxDimenzije.Text,
                    Tip = t,
                    Stanje = cBoxStanje.Text == "Novi" ? Stanje.Novi : Stanje.Polovni
                };

                collection.InsertOne(p);

                MessageBox.Show("Pneumatici su uspesno dodati.");
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

        private void tBoxDimenzije_Leave(object sender, EventArgs e)
        {
            if (tBoxDimenzije.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxDimenzije.Focus();
            }
        }

        private void cBoxTip_Leave(object sender, EventArgs e)
        {
            if (cBoxTip.SelectedIndex == -1)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBoxTip.Focus();
            }
        }

        private void cBoxStanje_Leave(object sender, EventArgs e)
        {
            if (cBoxStanje.SelectedIndex == -1)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBoxStanje.Focus();
            }
        }
    }
}
