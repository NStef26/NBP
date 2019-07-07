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
using Autoshop.Forme_za_dodavanje;
using MongoDB.Bson;

namespace Autoshop
{
    public partial class Pretraga : Form
    {
        private bool markaSet, modelSet, komponentSet;
        private int lastHit;
        private List<Proizvod> listaProizvoda;
        private List<Komponenta> listaKomponenti;

        public Pretraga()
        {
            InitializeComponent();
            cBoxMarka.DataSource = VratiSveMarke();
            cBoxModel.Visible = false;
            cBoxKomponente.Visible = false;
            dgv.Enabled = false;
            markaSet = modelSet = komponentSet = false;
            InitializeMenuStrip();
            lastHit = -1;
            listaProizvoda = new List<Proizvod>();
            listaKomponenti = new List<Komponenta>();
            btnKupi.Enabled = false;
            btnPonisti.Enabled = false;
        }

        private List<string> VratiSveMarke()

        {
            List<string> marke = new List<string>();

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Marka>("Marka");

            var markeTemp = collection.Find<Marka>(FilterDefinition<Marka>.Empty).ToList();
            foreach (Marka m in markeTemp)
            {
                if(!marke.Contains(m.MarkaAutomobila))
                    marke.Add(m.MarkaAutomobila);
            }

            //cBoxMarka.SelectedIndex = -1;
            return marke;
        }

        private void InitializeMenuStrip()
        {
            var update = cmsUD.Items.Add("Update");
            update.Click += Update_Click;

            var delete = cmsUD.Items.Add("Delete");
            delete.Click += Delete_Click;

            var kolicina = cmsUD.Items.Add("Povecaj kolicinu");
            kolicina.Click += Kolicina_Click;

            var dodajUKorpu = cmsUD.Items.Add("Dodaj u korpu");
            dodajUKorpu.Click += DodajUKorpu_Click;
        }

        private void DodajUKorpu_Click(object sender, EventArgs e)
        {
            if (lastHit == -1)
                return;

            object id = dgv.Rows[lastHit].Cells["Id"].Value;
            double cena = (double)dgv.Rows[lastHit].Cells["Cena"].Value;

            string tipKomponente = cBoxKomponente.Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("NBP");

            listaKomponenti.Add((Komponenta)dgv.Rows[lastHit].DataBoundItem);

            if (listaProizvoda.Any(f => f.Id.Equals(id)))
            {
                listaProizvoda.Where(f => f.Id.Equals(id)).First().Kolicina++;
                listaProizvoda.Where(f => f.Id.Equals(id)).First().Cena += cena;
            }
            else
            {
                listaProizvoda.Add(new Proizvod { Id = id, Kolicina = 1, ImeKolekcije = tipKomponente, Cena = cena });
            }
            btnKupi.Enabled = true;
            btnPonisti.Enabled = true;
        }

        private void Kolicina_Click(object sender, EventArgs e)
        {
            if (lastHit == -1)
                return;

            object id = dgv.Rows[lastHit].Cells["Id"].Value;

            string tipKomponente = cBoxKomponente.Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("NBP");

            if (tipKomponente == "Akumulator")
            {
                var o = database.GetCollection<Akumulatori>("Akumulator").Find<Akumulatori>(Builders<Akumulatori>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Brisaci")
            {
                var o = database.GetCollection<Brisaci>("Brisaci").Find<Brisaci>(Builders<Brisaci>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();

            }
            if (tipKomponente == "Dodatna Oprema")
            {
                var o = database.GetCollection<DodatnaOprema>("Dodatna Oprema").Find<DodatnaOprema>(Builders<DodatnaOprema>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Farovi")
            {
                var o = database.GetCollection<Farovi>("Farovi").Find<Farovi>(Builders<Farovi>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Motor")
            {
                var o = database.GetCollection<Motor>("Motor").Find<Motor>(Builders<Motor>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Pneumatici")
            {
                var o = database.GetCollection<Pneumatici>("Pneumatici").Find<Pneumatici>(Builders<Pneumatici>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Rashladni Sistem")
            {
                var o = database.GetCollection<RashladniSistem>("Rashladni Sistem").Find<RashladniSistem>(Builders<RashladniSistem>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Retrovizor")
            {
                var o = database.GetCollection<Retrovizor>("Retrovizor").Find<Retrovizor>(Builders<Retrovizor>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Sijalice")
            {
                var o = database.GetCollection<Sijalice>("Sijalice").Find<Sijalice>(Builders<Sijalice>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }
            if (tipKomponente == "Stakla")
            {
                var o = database.GetCollection<Stakla>("Stakla").Find<Stakla>(Builders<Stakla>.Filter.Eq("_id", id)).First();
                var form = new DodajKolicinu(o);
                form.FormClosed += Form_FormClosed1;
                form.Show();
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost?safe=true";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("NBP");

            object id = dgv.Rows[lastHit].Cells["Id"].Value;
            string tipKomponente = cBoxKomponente.Text;
            string model = cBoxModel.Text;

            ObjectId id_ref = (ObjectId)dgv.Rows[lastHit].Cells["Id"].Value;

            if (tipKomponente != "Akumulator")
            {
                var modeli = database.GetCollection<Model>("Model").Find(Builders<Model>.Filter.Eq("ModelAuta", model)).First();
                modeli.ListaKomponenti.Remove(new MongoDBRef(tipKomponente, id_ref));
                database.GetCollection<Model>("Model").ReplaceOne(Builders<Model>.Filter.Eq("_id", modeli.Id), modeli);
                if (tipKomponente == "Brisaci")
                {
                    database.GetCollection<Brisaci>("Brisaci").DeleteOne(Builders<Brisaci>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Dodatna Oprema")
                {
                    database.GetCollection<DodatnaOprema>("Dodatna Oprema").DeleteOne(Builders<DodatnaOprema>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Farovi")
                {
                    database.GetCollection<Farovi>("Farovi").DeleteOne(Builders<Farovi>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Motor")
                {
                    database.GetCollection<Motor>("Motor").DeleteOne(Builders<Motor>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Pneumatici")
                {
                    var o = database.GetCollection<Pneumatici>("Pneumatici").DeleteOne(Builders<Pneumatici>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Rashladni Sistem")
                {
                    var o = database.GetCollection<RashladniSistem>("Rashladni Sistem").DeleteOne(Builders<RashladniSistem>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Retrovizor")
                {
                    var o = database.GetCollection<Retrovizor>("Retrovizor").DeleteOne(Builders<Retrovizor>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Sijalice")
                {
                    database.GetCollection<Sijalice>("Sijalice").DeleteOne(Builders<Sijalice>.Filter.Eq("_id", id));

                }
                if (tipKomponente == "Stakla")
                {
                    database.GetCollection<Stakla>("Stakla").DeleteOne(Builders<Stakla>.Filter.Eq("_id", id));

                }
            }
            if (tipKomponente == "Akumulator")
            {
                var modeli = database.GetCollection<Model>("Model").Find(Builders<Model>.Filter.Empty).ToList();
                foreach (Model m in modeli)
                {
                    m.ListaKomponenti.Remove(new MongoDBRef(tipKomponente, id_ref));
                    database.GetCollection<Model>("Model").ReplaceOne(Builders<Model>.Filter.Eq("_id", m.Id), m);
                }

                database.GetCollection<Akumulatori>("Akumulator").DeleteOne(Builders<Akumulatori>.Filter.Eq("_id", id));

            }
            MessageBox.Show("Komponenta je uspešno obrisana");
            this.Invalidate();
            //throw new NotImplementedException();
            PopuniDGV();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (lastHit == -1)
                return;

            object id = dgv.Rows[lastHit].Cells["Id"].Value;
            //MessageBox.Show(id);

            string tipKomponente = cBoxKomponente.Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("NBP");

            //object o = new object();

            if (tipKomponente == "Akumulator")
            {
                var o = database.GetCollection<Akumulatori>("Akumulator").Find<Akumulatori>(Builders<Akumulatori>.Filter.Eq("_id", id)).First();
                var form = new AkumulatorForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Brisaci")
            {
                var o = database.GetCollection<Brisaci>("Brisaci").Find<Brisaci>(Builders<Brisaci>.Filter.Eq("_id", id)).First();
                var form = new BrisacForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Dodatna Oprema")
            {
                var o = database.GetCollection<DodatnaOprema>("Dodatna Oprema").Find<DodatnaOprema>(Builders<DodatnaOprema>.Filter.Eq("_id", id)).First();
                var form = new DodatnaForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Farovi")
            {
                var o = database.GetCollection<Farovi>("Farovi").Find<Farovi>(Builders<Farovi>.Filter.Eq("_id", id)).First();
                var form = new FaroviForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Motor")
            {
                var o = database.GetCollection<Motor>("Motor").Find<Motor>(Builders<Motor>.Filter.Eq("_id", id)).First();
                var form = new MotorForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Pneumatici")
            {
                var o = database.GetCollection<Pneumatici>("Pneumatici").Find<Pneumatici>(Builders<Pneumatici>.Filter.Eq("_id", id)).First();
                var form = new PneumaticiForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Rashladni Sistem")
            {
                var o = database.GetCollection<RashladniSistem>("Rashladni Sistem").Find<RashladniSistem>(Builders<RashladniSistem>.Filter.Eq("_id", id)).First();
                var form = new RashladniForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Retrovizor")
            {
                var o = database.GetCollection<Retrovizor>("Retrovizor").Find<Retrovizor>(Builders<Retrovizor>.Filter.Eq("_id", id)).First();
                var form = new RetrovizorForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Sijalice")
            {
                var o = database.GetCollection<Sijalice>("Sijalice").Find<Sijalice>(Builders<Sijalice>.Filter.Eq("_id", id)).First();
                var form = new SijaliceForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            if (tipKomponente == "Stakla")
            {
                var o = database.GetCollection<Stakla>("Stakla").Find<Stakla>(Builders<Stakla>.Filter.Eq("_id", id)).First();
                var form = new StaklaForma(o);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
        }

        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            PopuniDGV();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopuniDGV();
        }

        private void cBoxMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cBoxMarka.Text) || cBoxMarka.SelectedIndex == -1)
                return;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Marka>("Marka");

            var marke = collection.Find<Marka>(FilterDefinition<Marka>.Empty).ToList();

            List<string> modeli = new List<string>();

            foreach (Marka m in marke)
            {
                if (m.MarkaAutomobila == cBoxMarka.SelectedValue.ToString())
                {
                    foreach (var mt in m.Modeli)
                    {
                        var query = Builders<Model>.Filter.Eq("_id", mt.Id);
                        if (!modeli.Contains(database.GetCollection<Model>("Model").Find<Model>(query).First().ModelAuta))
                            modeli.Add(database.GetCollection<Model>("Model").Find<Model>(query).First().ModelAuta);
                        //modeli.Add(database.GetCollection<Model>("Model").FindOneById(mt.Id).ModelAuta);
                    }
                }
            }

            cBoxModel.DataSource = modeli;
            cBoxModel.Visible = true;
            markaSet = true;
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv.ContextMenuStrip = cmsUD;
                    lastHit = e.RowIndex;
                    cmsUD.Show(dgv, dgv.PointToClient(Cursor.Position));
                }
            }
        }



        private void cmsUD_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Name);
        }

        private void cBoxModel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cBoxModel.Text) || cBoxModel.SelectedIndex == -1)
                return;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Marka>("Marka");

            //var marke = collection.FindAll();
            var marke = collection.Find<Marka>(FilterDefinition<Marka>.Empty).ToList();

            Model m = new Model();

            foreach (Marka mt in marke)
            {
                if (mt.MarkaAutomobila == cBoxMarka.SelectedValue.ToString())
                {
                    foreach (var mo in mt.Modeli)
                    {
                        
                        var test = database.GetCollection<Model>("Model").Find(Builders<Model>.Filter.Eq("_id", mo.Id)).First();
                        //if (database.GetCollection<Model>("Model").FindOneById(mo.Id).ModelAuta == cBoxModel.Text)
                        //    m = database.GetCollection<Model>("Model").FindOneById(mo.Id);
                        if (test.ModelAuta == cBoxModel.Text)
                            m = test;
                    }
                }
            }

            List<string> listaKomponenti = new List<string>();

            foreach (var k in m.ListaKomponenti)
            {
                if (!listaKomponenti.Contains(k.CollectionName))
                    listaKomponenti.Add(k.CollectionName);
            }

            cBoxKomponente.DataSource = listaKomponenti;
            cBoxKomponente.Visible = true;
            modelSet = true;
            komponentSet = true;
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            new Korpa(listaProizvoda, listaKomponenti).Show();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            listaProizvoda = new List<Proizvod>();
            btnKupi.Enabled = false;
            btnPonisti.Enabled = false;
        }

        private void cBoxKomponente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!komponentSet)
                return;
            if (string.IsNullOrEmpty(cBoxKomponente.Text) || cBoxKomponente.SelectedIndex == -1)
                return;

            PopuniDGV();


            
        }
        private void PopuniDGV()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Marka>("Marka");

            var marke = collection.Find<Marka>(FilterDefinition<Marka>.Empty).ToList();

            Model m = new Model();

            foreach (Marka mt in marke)
            {
                if (mt.MarkaAutomobila == cBoxMarka.SelectedValue.ToString())
                {
                    foreach (var mo in mt.Modeli)
                    {
                        //if (database.GetCollection<Model>("Model").FindOneById(mo.Id).ModelAuta == cBoxModel.Text)
                        //    m = database.GetCollection<Model>("Model").FindOneById(mo.Id);

                        var test = database.GetCollection<Model>("Model").Find(Builders<Model>.Filter.Eq("_id", mo.Id)).First();
                        if (test.ModelAuta == cBoxModel.Text)
                            m = test;
                    }
                }
            }

            List<object> lista = new List<object>();

            foreach (var k in m.ListaKomponenti)
            {
                if (k.CollectionName == cBoxKomponente.Text)
                {
                    if (k.CollectionName == "Akumulator")
                        lista.Add(database.GetCollection<Akumulatori>(k.CollectionName).Find(Builders<Akumulatori>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Brisaci")
                        lista.Add(database.GetCollection<Brisaci>(k.CollectionName).Find(Builders<Brisaci>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Dodatna Oprema")
                        lista.Add(database.GetCollection<DodatnaOprema>(k.CollectionName).Find(Builders<DodatnaOprema>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Farovi")
                        lista.Add(database.GetCollection<Farovi>(k.CollectionName).Find(Builders<Farovi>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Motor")
                        lista.Add(database.GetCollection<Motor>(k.CollectionName).Find(Builders<Motor>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Pneumatici")
                        lista.Add(database.GetCollection<Pneumatici>(k.CollectionName).Find(Builders<Pneumatici>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Rashladni Sistem")
                        lista.Add(database.GetCollection<RashladniSistem>(k.CollectionName).Find(Builders<RashladniSistem>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Retrovizor")
                        lista.Add(database.GetCollection<Retrovizor>(k.CollectionName).Find(Builders<Retrovizor>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Sijalice")
                        lista.Add(database.GetCollection<Sijalice>(k.CollectionName).Find(Builders<Sijalice>.Filter.Eq("_id", k.Id)).First());
                    if (k.CollectionName == "Stakla")
                        lista.Add(database.GetCollection<Stakla>(k.CollectionName).Find(Builders<Stakla>.Filter.Eq("_id", k.Id)).First());

                }
            }

            dgv.DataSource = lista;
            dgv.Enabled = true;
        }
    }

    
}
