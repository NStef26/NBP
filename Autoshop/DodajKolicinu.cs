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
using MongoDB.Driver;

namespace Autoshop
{
    public partial class DodajKolicinu : Form
    {
        private Akumulatori akumulator;
        private Brisaci brisac;
        private DodatnaOprema dodatna;
        private Farovi far;
        private Motor motor;
        private Pneumatici pneumatik;
        private RashladniSistem rashladni;
        private Retrovizor retrovizor;
        private Sijalice sijalice;
        private Stakla stakla;
        string pitanje;

        public DodajKolicinu()
        {

        }

        public DodajKolicinu(Motor o)
        {
            InitializeComponent();
            motor = o;
            this.Text = "Povecaj kolicinu motora";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost motora sa ID-jem:" + o.Id.ToString();
        }

        public DodajKolicinu(Akumulatori o)
        {
            InitializeComponent();
            akumulator = o;
            this.Text = "Povecaj kolicinu akumulatora";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost akumulatora sa ID-jem:" + o.Id.ToString();
        }

        public DodajKolicinu(Brisaci o1)
        {
            InitializeComponent();
            brisac = o1;
            this.Text = "Povecaj kolicinu brisaca";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost brisaca sa ID-jem:" + o1.Id.ToString();
        }

        public DodajKolicinu(DodatnaOprema o2)
        {
            InitializeComponent();
            dodatna = o2;
            this.Text = "Povecaj kolicinu dodatne opreme";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost dodatne opreme sa ID-jem:" + o2.Id.ToString();
        }

        public DodajKolicinu(Farovi o3)
        {
            InitializeComponent();
            far = o3;
            this.Text = "Povecaj kolicinu farova";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost fara sa ID-jem:" + o3.Id.ToString();
        }

        public DodajKolicinu(Pneumatici o4)
        {
            InitializeComponent();
            pneumatik = o4;
            this.Text = "Povecaj kolicinu pneumatika";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost pneumatika sa ID-jem:" + o4.Id.ToString();
        }

        public DodajKolicinu(RashladniSistem o5)
        {
            InitializeComponent();
            rashladni = o5;
            this.Text = "Povecaj kolicinu rashladnog sistema";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost rashladnog sistema sa ID-jem:" + o5.Id.ToString();
        }

        public DodajKolicinu(Retrovizor o6)
        {
            InitializeComponent();
            retrovizor = o6;
            this.Text = "Povecaj kolicinu retrovizora";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost retrovizora sa ID-jem:" + o6.Id.ToString();
        }

        public DodajKolicinu(Sijalice o7)
        {
            InitializeComponent();
            sijalice = o7;
            this.Text = "Povecaj kolicinu sijalice";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost sijalice sa ID-jem:" + o7.Id.ToString();
        }

        public DodajKolicinu(Stakla o8)
        {
            InitializeComponent();
            stakla = o8;
            this.Text = "Povecaj kolicinu stakla";
            pitanje = "Da li ste sigurni da hocete da povecate vrednost stakla sa ID-jem:" + o8.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("NBP");

            DialogResult dialogResult = MessageBox.Show(pitanje + " za " + numKolicina.Value.ToString() + " ?", "Pitanje", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (this.Text == "Povecaj kolicinu motora")
                {
                    var collection = database.GetCollection<Motor>("Motor");
                    motor.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Motor>.Filter.Eq("_id", motor.Id);
                    database.GetCollection<Motor>("Motor").ReplaceOne(query, motor);
                }
                if (this.Text == "Povecaj kolicinu akumulatora")
                {
                    var collection = database.GetCollection<Akumulatori>("Akumulator");
                    akumulator.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Akumulatori>.Filter.Eq("_id", akumulator.Id);
                    database.GetCollection<Akumulatori>("Akumulator").ReplaceOne(query, akumulator);
                }
                if (this.Text == "Povecaj kolicinu brisaca")
                {
                    var collection = database.GetCollection<Brisaci>("Brisaci");
                    brisac.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Brisaci>.Filter.Eq("_id", brisac.Id);
                    database.GetCollection<Brisaci>("Brisaci").ReplaceOne(query, brisac);
                }
                if (this.Text == "Povecaj kolicinu dodatne opreme")
                {
                    var collection = database.GetCollection<DodatnaOprema>("Dodatna Oprema");
                    dodatna.Kolicina += (int)numKolicina.Value;
                    var query = Builders<DodatnaOprema>.Filter.Eq("_id", dodatna.Id);
                    database.GetCollection<DodatnaOprema>("Dodatna Oprema").ReplaceOne(query, dodatna);
                }
                if (this.Text == "Povecaj kolicinu farova")
                {
                    var collection = database.GetCollection<Farovi>("Farovi");
                    far.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Farovi>.Filter.Eq("_id", far.Id);
                    database.GetCollection<Farovi>("Farovi").ReplaceOne(query, far);
                }
                if (this.Text == "Povecaj kolicinu pneumatika")
                {
                    var collection = database.GetCollection<Pneumatici>("Pneumatici");
                    pneumatik.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Pneumatici>.Filter.Eq("_id", pneumatik.Id);
                    database.GetCollection<Pneumatici>("Pneumatici").ReplaceOne(query, pneumatik);
                }
                if (this.Text == "Povecaj kolicinu rashladnog sistema")
                {
                    var collection = database.GetCollection<RashladniSistem>("Rashladni Sistem");
                    rashladni.Kolicina += (int)numKolicina.Value;
                    var query = Builders<RashladniSistem>.Filter.Eq("_id", rashladni.Id);
                    database.GetCollection<RashladniSistem>("Rashladni Sistem").ReplaceOne(query, rashladni);
                }
                if (this.Text == "Povecaj kolicinu retrovizora")
                {
                    var collection = database.GetCollection<Retrovizor>("Retrovizor");
                    retrovizor.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Retrovizor>.Filter.Eq("_id", retrovizor.Id);
                    database.GetCollection<Retrovizor>("Retrovizor").ReplaceOne(query, retrovizor);
                }
                if (this.Text == "Povecaj kolicinu sijalice")
                {
                    var collection = database.GetCollection<Sijalice>("Sijalice");
                    sijalice.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Sijalice>.Filter.Eq("_id", sijalice.Id);
                    database.GetCollection<Sijalice>("Sijalice").ReplaceOne(query, sijalice);
                }
                if (this.Text == "Povecaj kolicinu stakla")
                {
                    var collection = database.GetCollection<Stakla>("Stakla");
                    stakla.Kolicina += (int)numKolicina.Value;
                    var query = Builders<Stakla>.Filter.Eq("_id", stakla.Id);
                    database.GetCollection<Stakla>("Stakla").ReplaceOne(query, stakla);
                }
            }
            else
            {

            }

            this.Close();
        }
    }
}
