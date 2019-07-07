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
    public partial class StaklaForma : Form
    {
        Stakla temp;

        public StaklaForma()
        {
            InitializeComponent();
        }

        public StaklaForma(Stakla o)
        {
            InitializeComponent();
            Init(o);
        }

        void Init(Stakla f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            tBoxDim.Text = f.Dimenzije;
            cBoxTip.SelectedIndex = (int)f.Tip;

            this.Text = "Azuriraj stakla";
            button1.Text = "Azuriraj";
            temp = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Stakla>("Stakla");

            TipStakla t = TipStakla.PrednjeDesno;
            if (cBoxTip.Text == "Prednje Desno")
                t = TipStakla.PrednjeDesno;
            if (cBoxTip.Text == "Prednje Levo")
                t = TipStakla.PrednjeLevo;
            if (cBoxTip.Text == "Zadnje Desno")
                t = TipStakla.ZadnjeDesno;
            if (cBoxTip.Text == "Zadnje Levo")
                t = TipStakla.ZadnjeLevo;
            if (cBoxTip.Text == "Vetrobransko")
                t = TipStakla.Vetrobransko;
            if (cBoxTip.Text == "Zadnje")
                t = TipStakla.Zadnje;

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.Dimenzije = tBoxDim.Text;
                temp.Tip = t;

                var query = Builders<Stakla>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Staklo je uspesno azurirano.");
            }
            else
            {
                Stakla s = new Stakla
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    Dimenzije = tBoxDim.Text,
                    Tip = t
                };

                collection.InsertOne(s);

                MessageBox.Show("Staklo je uspesno dodato.");
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

        private void cBoxTip_Leave(object sender, EventArgs e)
        {
            if (cBoxTip.SelectedIndex == -1)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBoxTip.Focus();
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
