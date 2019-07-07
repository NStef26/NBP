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
    public partial class RashladniForma : Form
    {
        RashladniSistem temp;

        public RashladniForma()
        {
            InitializeComponent();
        }

        public RashladniForma(RashladniSistem o)
        {
            InitializeComponent();
            Init(o);
        }

        void Init(RashladniSistem f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            tBoxDimenzija.Text = f.Dimenzija;
            cBoxTip.SelectedIndex = (int)f.Tip;

            this.Text = "Azuriraj rashladni sistem";
            button1.Text = "Azuriraj";
            temp = f;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<RashladniSistem>("Rashladni Sistem");

            TipRashladnog t = TipRashladnog.Hladnjak;
            if (cBoxTip.Text == "Hladnjak")
                t = TipRashladnog.Hladnjak;
            if (cBoxTip.Text == "Termostat")
                t = TipRashladnog.Termostat;
            if (cBoxTip.Text == "Ventilator")
                t = TipRashladnog.Ventilator;

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Dimenzija = tBoxDimenzija.Text;
                temp.Tip = t;

                var query = Builders<RashladniSistem>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Rashladni sistem je uspesno azuriran.");
            }
            else
            {
                RashladniSistem r = new RashladniSistem
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Dimenzija = tBoxDimenzija.Text,
                    Tip = t
                };

                collection.InsertOne(r);

                MessageBox.Show("Rashladni sistem je uspesno dodat.");
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

        private void tBoxDimenzija_Leave(object sender, EventArgs e)
        {
            if (tBoxDimenzija.Text == "")
            {

                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxDimenzija.Focus();
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
    }
}
