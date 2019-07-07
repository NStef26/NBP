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
    public partial class MotorForma : Form
    {
        private Motor temp;

        public MotorForma()
        {
            InitializeComponent();
        }

        public MotorForma(Motor o)
        {
            InitializeComponent();
            Init(o);
        }

        private void Init(Motor f)
        {
            numCena.Value = (decimal)f.Cena;
            numKolicina.Value = f.Kolicina;
            tBoxMarka.Text = f.Marka;
            tBoxModel.Text = f.Model;
            numKonjske.Value = f.KonjskeSnage;
            numKubikaza.Value = f.Kubikaza;
            numKilovati.Value = f.Kilovati;
            comboBox1.SelectedIndex = (int)f.VrstaGoriva;

            this.Text = "Azuriraj motor";
            button1.Text = "Azuriraj";
            temp = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            VrstaGoriva v = VrstaGoriva.Benzin;
            if (comboBox1.Text == "Dizel")
                v = VrstaGoriva.Dizel;
            if (comboBox1.Text == "Benzin")
                v = VrstaGoriva.Benzin;
            if (comboBox1.Text == "TNG")
                v = VrstaGoriva.TNG;

            var collection = database.GetCollection<Motor>("Motor");

            if (button1.Text == "Azuriraj")
            {
                temp.Cena = (double)numCena.Value;
                temp.Kolicina = (int)numKolicina.Value;
                temp.Model = tBoxMarka.Text;
                temp.Marka = tBoxModel.Text;
                temp.KonjskeSnage = (int)numKonjske.Value;
                temp.Kubikaza = (int)numKubikaza.Value;
                temp.Kilovati = (int)numKilovati.Value;
                temp.VrstaGoriva = v;

                var query = Builders<Motor>.Filter.Eq("_id", temp.Id);
                collection.ReplaceOne(query, temp);

                MessageBox.Show("Uspesno je azuriran motor.");
            }
            else
            {
                Motor m = new Motor
                {
                    Cena = (double)numCena.Value,
                    Kolicina = (int)numKolicina.Value,
                    Marka = tBoxMarka.Text,
                    Model = tBoxModel.Text,
                    KonjskeSnage = (int)numKonjske.Value,
                    Kubikaza = (int)numKubikaza.Value,
                    Kilovati = (int)numKilovati.Value,
                    VrstaGoriva = v
                };

                collection.InsertOne(m);

                MessageBox.Show("Uspesno je dodat motor.");
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

        private void numKonjske_Leave(object sender, EventArgs e)
        {
            if (numKonjske.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKonjske.Focus();
            }
        }

        private void numKubikaza_Leave(object sender, EventArgs e)
        {
            if (numKubikaza.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKubikaza.Focus();
            }
        }

        private void numKilovati_Leave(object sender, EventArgs e)
        {
            if (numKilovati.Value == 0)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKilovati.Focus();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Polje mora biti popunjeno", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
            }
        }
    }
}
