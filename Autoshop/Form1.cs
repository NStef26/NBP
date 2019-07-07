using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using Autoshop.Komponente;
using Autoshop.Forme_za_dodavanje;
using MongoDB.Driver.Core.Operations;
using MongoDB.Bson.Serialization;

namespace Autoshop
{
    public partial class Form1 : Form
    {
        private bool markaSet; 

        public Form1()
        {
            InitializeComponent();
            cBoxMarka.DataSource = VratiSveMarke();
            cBoxMarka.SelectedItem = null;
            markaSet = false;
            cBoxModel.Visible = false;
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
                if (!marke.Contains(m.MarkaAutomobila))
                    marke.Add(m.MarkaAutomobila);
            }

            //cBoxMarka.SelectedIndex = -1;
            return marke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            var database = client.GetDatabase("NBP");

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("NBP");

            var collection = database.GetCollection<Model>("Model");

            Model model1 = new Model { ModelAuta = "A5", Godiste = 2008 };
            Model model2 = new Model { ModelAuta = "A4", Godiste = 2003 };
            Model model3 = new Model { ModelAuta = "Mondeo", Godiste = 1992 };
            Model model4 = new Model { ModelAuta = "Focus", Godiste = 2004 };
            Model model5 = new Model { ModelAuta = "Golf 4", Godiste = 2003 };
            Model model6 = new Model { ModelAuta = "Golf 5", Godiste = 2007 };

            collection.InsertOne(model1);
            collection.InsertOne(model2);
            collection.InsertOne(model3);
            collection.InsertOne(model4);
            collection.InsertOne(model5);
            collection.InsertOne(model6);

            var c = database.GetCollection<Marka>("Marka");

            Marka audi = new Marka { MarkaAutomobila = "Audi" };
            Marka voolkswagen = new Marka { MarkaAutomobila = "Volkswagen" };
            Marka ford = new Marka { MarkaAutomobila = "Ford" };

            c.InsertOne(audi);
            c.InsertOne(voolkswagen);
            c.InsertOne(ford);

            var collectionAkumulatori = database.GetCollection<Akumulatori>("Akumulator");

            Akumulatori a1 = new Akumulatori { Cena = 3534, Kolicina = 3, Marka = "", Model = "", Voltaza = 12, Kapacitet = 40, Snaga = 390, Dimenzije = "175 X 175 X 190" };
            Akumulatori a2 = new Akumulatori { Cena = 3984, Kolicina = 10, Marka = "", Model = "", Voltaza = 12, Kapacitet = 45, Snaga = 390, Dimenzije = "207 X 175 X 190" };
            Akumulatori a3 = new Akumulatori { Cena = 4390, Kolicina = 5, Marka = "", Model = "", Voltaza = 12, Kapacitet = 45, Snaga = 360, Dimenzije = "210 X 175 Z 190" };

            collectionAkumulatori.InsertOne(a1);
            collectionAkumulatori.InsertOne(a2);
            collectionAkumulatori.InsertOne(a3);

            var collectionBrisaci = database.GetCollection<Brisaci>("Brisaci");

            Brisaci b1 = new Brisaci { Cena = 1285.2, Kolicina = 4, Marka = "Volkswagen", Model = "Golf 4", Dimenzija = "260mm", Tip = Tip.Prednji };
            Brisaci b2 = new Brisaci { Cena = 3348, Kolicina = 2, Marka = "Ford", Model = "Focus", Dimenzija = "540mm/540mm", Tip = Tip.Zadnji };
            Brisaci b3 = new Brisaci { Cena = 790.56, Kolicina = 1, Marka = "Audi", Model = "A4", Dimenzija = "625mm/625mm", Tip = Tip.Prednji };

            collectionBrisaci.InsertOne(b1);
            collectionBrisaci.InsertOne(b2);
            collectionBrisaci.InsertOne(b3);

            var collectionDodatna = database.GetCollection<DodatnaOprema>("Dodatna Oprema");

            DodatnaOprema d1 = new DodatnaOprema { Cena = 3190, Kolicina = 5, Marka = "", Model = "", Tip = TipOpreme.PrvaPomoc, Opis = "Komplet za prvu pomoc tip B Galenika, Set sijalica H4, Traka za vucu 2T, Sigurnosni trougao, Obelezavajuci prsluk " };
            DodatnaOprema d2 = new DodatnaOprema { Cena = 6800, Kolicina = 1, Marka = "Audi", Model = "A4", Tip = TipOpreme.Presvlaka, Opis = "Presvlaka sa oznakom, kozna" };
            DodatnaOprema d3 = new DodatnaOprema { Cena = 2500, Kolicina = 3, Marka = "Volkswagen", Model = "Golf 4", Tip = TipOpreme.Patosnica, Opis = "Tepih patosniza, gumirana" };

            collectionDodatna.InsertOne(d1);
            collectionDodatna.InsertOne(d2);
            collectionDodatna.InsertOne(d3);

            var collectionFarovi = database.GetCollection<Farovi>("Farovi");

            Farovi f1 = new Farovi { Cena = 13811.04, Kolicina = 2, Marka = "Volkswagen", Model = "Golf 5", Opis = "Sa motorom. Hromirana unutrašnjost. Crna unutrašnjost. Providno staklo." };
            Farovi f2 = new Farovi { Cena = 31104, Kolicina = 1, Marka = "Audi", Model = "A5", Opis = "Sa motorom. Žuti žmigavac. Hromirana unutrašnjost. Sa sočivom. Providno staklo." };
            Farovi f3 = new Farovi { Cena = 13910.40, Kolicina = 1, Marka = "Ford", Model = "Focus", Opis = "Sa motorom. Siva unutrašnjost. Hromirana unutrašnjost. Dnevno svetlo. Providno staklo." };

            collectionFarovi.InsertOne(f1);
            collectionFarovi.InsertOne(f2);
            collectionFarovi.InsertOne(f3);

            var collectionMotori = database.GetCollection<Motor>("Motor");

            Motor m1 = new Motor { Cena = 2200, Kolicina = 1, Marka = "Ford", Model = "Focus", VrstaGoriva = VrstaGoriva.Benzin, KonjskeSnage = 115, Kubikaza = 1800, Kilovati = 85 };
            Motor m2 = new Motor { Cena = 11000, Kolicina = 1, Marka = "Audi", Model = "A4", VrstaGoriva = VrstaGoriva.Dizel, KonjskeSnage = 190, Kubikaza = 2000, Kilovati = 140 };
            Motor m3 = new Motor { Cena = 7200, Kolicina = 1, Marka = "Volkswagen", Model = "Golf 4", VrstaGoriva = VrstaGoriva.Benzin, KonjskeSnage = 115, Kubikaza = 1900, Kilovati = 85 };

            collectionMotori.InsertOne(m1);
            collectionMotori.InsertOne(m2);
            collectionMotori.InsertOne(m3);

            var collectionPneumatici = database.GetCollection<Pneumatici>("Pneumatici");

            Pneumatici p1 = new Pneumatici { Cena = 4500, Kolicina = 5, Marka = "Volkswagen", Model = "Golf 5", Dimenzije = "205/55 R16", Tip = TipGuma.Zimske, Stanje = Stanje.Novi };
            Pneumatici p2 = new Pneumatici { Cena = 6756.40, Kolicina = 4, Marka = "Ford", Model = "Focus", Dimenzije = "215/55 R16", Tip = TipGuma.MS, Stanje = Stanje.Novi };
            Pneumatici p3 = new Pneumatici { Cena = 7303.79, Kolicina = 5, Marka = "Audi", Model = "A4", Dimenzije = "215/55 ZR16", Tip = TipGuma.Letnje, Stanje = Stanje.Novi };

            collectionPneumatici.InsertOne(p1);
            collectionPneumatici.InsertOne(p2);
            collectionPneumatici.InsertOne(p3);

            var collectionRashladni = database.GetCollection<RashladniSistem>("Rashladni Sistem");

            RashladniSistem rs1 = new RashladniSistem { Cena = 1200.12, Kolicina = 2, Marka = "Audi", Model = "A4", Tip = TipRashladnog.Termostat, Dimenzija = "20x30" };
            RashladniSistem rs2 = new RashladniSistem { Cena = 1550, Kolicina = 6, Marka = "Volkswagen", Model = "Golf 4", Tip = TipRashladnog.Hladnjak, Dimenzija = "30x50" };
            RashladniSistem rs3 = new RashladniSistem { Cena = 343, Kolicina = 1, Marka = "Ford", Model = "Focus", Tip = TipRashladnog.Ventilator, Dimenzija = "30x30" };

            collectionRashladni.InsertOne(rs1);
            collectionRashladni.InsertOne(rs2);
            collectionRashladni.InsertOne(rs3);

            var collectionRetrovizor = database.GetCollection<Retrovizor>("Retrovizor");

            Retrovizor r1 = new Retrovizor { Cena = 1230.5, Kolicina = 2, Marka = "Audi", Model = "A4", Tip = TipRetrovizora.Unutrasnji };
            Retrovizor r2 = new Retrovizor { Cena = 2100, Kolicina = 10, Marka = "Volkswagen", Model = "Golf 5", Tip = TipRetrovizora.Levi };
            Retrovizor r3 = new Retrovizor { Cena = 1950, Kolicina = 5, Marka = "Volkswagen", Model = "Golf 4", Tip = TipRetrovizora.Desni };
            Retrovizor r4 = new Retrovizor { Cena = 1720.99, Kolicina = 9, Marka = "Ford", Model = "Mondeo", Tip = TipRetrovizora.Desni };

            collectionRetrovizor.InsertOne(r1);
            collectionRetrovizor.InsertOne(r2);
            collectionRetrovizor.InsertOne(r3);
            collectionRetrovizor.InsertOne(r4);

            var collectionSijalice = database.GetCollection<Sijalice>("Sijalice");

            Sijalice s1 = new Sijalice { Cena = 300, Kolicina = 12, Marka = "Ford", Model = "Focus", Vati = 15, Tip = TipSijalice.Zmigavac };
            Sijalice s2 = new Sijalice { Cena = 990, Kolicina = 3, Marka = "Ford", Model = "Focus", Vati = 23, Tip = TipSijalice.Kratko };
            Sijalice s3 = new Sijalice { Cena = 1234, Kolicina = 1, Marka = "Audi", Model = "A4", Vati = 9, Tip = TipSijalice.Maglenke };

            collectionSijalice.InsertOne(s1);
            collectionSijalice.InsertOne(s2);
            collectionSijalice.InsertOne(s3);

            var collectionStakla = database.GetCollection<Stakla>("Stakla");

            Stakla st1 = new Stakla { Cena = 5550.9, Kolicina = 2, Marka = "Audi", Model = "A4", Dimenzije = "120x70", Tip = TipStakla.Vetrobransko };
            Stakla st2 = new Stakla { Cena = 6109.90, Kolicina = 4, Marka = "Volkswagen", Model = "Golf 4", Dimenzije = "80x80", Tip = TipStakla.PrednjeDesno };
            Stakla st3 = new Stakla { Cena = 7300.1, Kolicina = 2, Marka = "Volkswagen", Model = "Golf 5", Dimenzije = "40x80", Tip = TipStakla.ZadnjeLevo };

            collectionStakla.InsertOne(st1);
            collectionStakla.InsertOne(st2);
            collectionStakla.InsertOne(st3);

            var collectionModeli = database.GetCollection<Model>("Model");
            //var modeli = collectionModeli.FindAll();
            
            List<Model> modeli = new List<Model>();
            //collection.Find(FilterDefinition<Marka>.Empty).ForEachAsync(m => marke.Add(m.MarkaAutomobila));
            collectionModeli.Find(FilterDefinition<Model>.Empty).ForEachAsync(ak=>modeli.Add(ak));
            List<Akumulatori> akumulatori = new List<Akumulatori>();
            database.GetCollection<Akumulatori>("Akumulator").Find(FilterDefinition<Akumulatori>.Empty).ForEachAsync(ak=>akumulatori.Add(ak));

            List<Brisaci> brisaci = new List<Brisaci>();
            database.GetCollection<Brisaci>("Brisaci").Find(FilterDefinition<Brisaci>.Empty).ForEachAsync(ak => brisaci.Add(ak));

            List<DodatnaOprema> dodatna = new List<DodatnaOprema>();
            database.GetCollection<DodatnaOprema>("Dodatna Oprema").Find(FilterDefinition<DodatnaOprema>.Empty).ForEachAsync(ak => dodatna.Add(ak));

            List<Farovi> farovi = new List<Farovi>();
            database.GetCollection<Farovi>("Farovi").Find(FilterDefinition<Farovi>.Empty).ForEachAsync(ak => farovi.Add(ak));

            List<Motor> motori = new List<Motor>();
            database.GetCollection<Motor>("Motor").Find(FilterDefinition<Motor>.Empty).ForEachAsync(ak => motori.Add(ak));

            List<Pneumatici> pneumatici = new List<Pneumatici>();
            database.GetCollection<Pneumatici>("Pneumatici").Find(FilterDefinition<Pneumatici>.Empty).ForEachAsync(ak => pneumatici.Add(ak));

            List<RashladniSistem> rashladni = new List<RashladniSistem>();
            database.GetCollection<RashladniSistem>("Rashladni Sistem").Find(FilterDefinition<RashladniSistem>.Empty).ForEachAsync(ak => rashladni.Add(ak));

            List<Retrovizor> retrovizori = new List<Retrovizor>();
            database.GetCollection<Retrovizor>("Retrovizor").Find(FilterDefinition<Retrovizor>.Empty).ForEachAsync(ak =>retrovizori.Add(ak));

            List<Sijalice> sijalice = new List<Sijalice>();
            database.GetCollection<Sijalice>("Sijalice").Find(FilterDefinition<Sijalice>.Empty).ForEachAsync(ak => sijalice.Add(ak));

            List<Stakla> stakla = new List<Stakla>();
            database.GetCollection<Stakla>("Stakla").Find(FilterDefinition<Stakla>.Empty).ForEachAsync(ak => stakla.Add(ak));
            


            foreach (Model m in modeli)
            {
                foreach (Akumulatori a in akumulatori)
                {
                    if (m.ModelAuta == a.Model || a.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Akumulator", a.Id));
                }

                foreach (Brisaci b in brisaci)
                {
                    if (m.ModelAuta == b.Model || b.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Brisaci", b.Id));
                }
                
                foreach (DodatnaOprema d in dodatna)
                {
                    if (m.ModelAuta == d.Model || d.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Dodatna Oprema", d.Id));
                }

                foreach (Farovi f in farovi)
                {
                    if (m.ModelAuta == f.Model || f.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Farovi", f.Id));
                }

                foreach (Motor mt in motori)
                {
                    if (m.ModelAuta == mt.Model || mt.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Motor", mt.Id));
                }
                
                foreach (Pneumatici p in pneumatici)
                {
                    if (m.ModelAuta == p.Model || p.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Pneumatici", p.Id));
                }

                foreach (RashladniSistem r in rashladni)
                {
                    if (m.ModelAuta == r.Model || r.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Rashladni Sistem", r.Id));
                }

                foreach (Retrovizor r in retrovizori)
                {
                    if (m.ModelAuta == r.Model || r.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Retrovizor", r.Id));
                }

                foreach (Sijalice s in sijalice)
                {
                    if (m.ModelAuta == s.Model || s.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Sijalice", s.Id));
                }

                foreach (Stakla s in stakla)
                {
                    if (m.ModelAuta == s.Model || s.Model == "")
                        m.ListaKomponenti.Add(new MongoDBRef("Stakla", s.Id));
                }

                //collectionModeli.Save(m);
                var query = Builders<Model>.Filter.Eq("_id", m.Id);
                collectionModeli.ReplaceOne(query,m);
            }

            var collectionMarke = database.GetCollection<Marka>("Marka");
            //List<Marka> marke = new List<Marka>();
           var marke= database.GetCollection<Marka>("Marka").Find(FilterDefinition<Marka>.Empty).ToList();

           var modelist = database.GetCollection<Model>("Model").Find(FilterDefinition<Model>.Empty).ToList();

            foreach (Marka m in marke)
            {
                foreach (Model md in modelist)
                {
                    if (m.MarkaAutomobila == "Audi" && (md.ModelAuta == "A4" || md.ModelAuta == "A5"))
                        m.Modeli.Add(new MongoDBRef("Model", md.Id));

                    if (m.MarkaAutomobila == "Volkswagen" && (md.ModelAuta == "Golf 4" || md.ModelAuta == "Golf 5"))
                        m.Modeli.Add(new MongoDBRef("Model", md.Id));

                    if (m.MarkaAutomobila == "Ford" && (md.ModelAuta == "Focus" || md.ModelAuta == "Mondeo"))
                        m.Modeli.Add(new MongoDBRef("Model", md.Id));
                }
                var query = Builders<Marka>.Filter.Eq("_id", m.Id);
                collectionMarke.ReplaceOne(query, m);

            }


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

        private void cBoxMarka_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(cBoxMarka.Text) || cBoxMarka.SelectedIndex == -1)
            //    return;

            //var connectionString = "mongodb://localhost/?safe=true";
            //var client = new MongoClient(connectionString);
            //var server = client.GetServer();
            //var database = server.GetDatabase("NBP");

            //var collection = database.GetCollection<Marka>("Marka");

            //var marke = collection.FindAll();

            //List<string> modeli = new List<string>();

            //foreach (Marka m in marke)
            //{
            //    if (m.MarkaAutomobila == cBoxMarka.SelectedValue.ToString())
            //    {
            //        foreach (var mt in m.Modeli)
            //        {
            //            modeli.Add(database.GetCollection<Model>("Model").FindOneById(mt.Id).ModelAuta);
            //        }
            //    }
            //}

            //cBoxModel.DataSource = modeli;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (cBoxDodaj.Text == "Akumulatori")
            {
                var a = new AkumulatorForma();
                a.Show();
            }
            if (cBoxDodaj.Text == "Brisaci")
            {
                var a = new BrisacForma();
                a.Show();
            }
            if (cBoxDodaj.Text == "Dodatna Oprema")
            {
                var a = new DodatnaForma();
                a.Show();
            }
            if (cBoxDodaj.Text == "Farovi")
            {
                var a = new FaroviForma();
                a.Show();
            }
            if (cBoxDodaj.Text == "Motor")
            {
                var a = new MotorForma();
                a.Show();
            }
            if (cBoxDodaj.Text == "Pneumatici")
            {
                new PneumaticiForma().Show();
            }
            if (cBoxDodaj.Text == "Rashladni Sistem")
            {
                new RashladniForma().Show();
            }
            if (cBoxDodaj.Text == "Retrovizor")
            {
                new RetrovizorForma().Show();
            }
            if (cBoxDodaj.Text == "Sijalice")
            {
                new SijaliceForma().Show();
            }
            if (cBoxDodaj.Text == "Stakla")
            {
                new StaklaForma().Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Pretraga().Show();
        }
    }
}
