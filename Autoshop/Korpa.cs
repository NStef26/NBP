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
using MongoDB.Bson;
using MongoDB.Driver;

namespace Autoshop
{
    public partial class Korpa : Form
    {
        List<Komponenta> listaKomponenti;
        List<Proizvod> listaProizvoda;

        public Korpa()
        {
            InitializeComponent();
        }

        public Korpa(List<Proizvod> lista, List<Komponenta> komponente)
        {
            InitializeComponent();
            lBox.DataSource = lista;
            lblCena.Text = "Ukupna cena je " + IzracunajCenu(lista).ToString() + " dinara.";
            listaKomponenti = komponente;
            listaProizvoda = lista;
        }

        void PostaviLabelu(double cena)
        {
            lblCena.Text = "Ukupna cena je " + cena.ToString() + " dinara.";
        }

        public Korpa(List<Proizvod> lista)
        {
            InitializeComponent();
            lBox.DataSource = lista.ToArray();
            lblCena.Text = "Ukupna cena je " + IzracunajCenu(lista).ToString() + " dinara.";
        }

        double IzracunajCenu(List<Proizvod> lista)
        {
            double cena = 0;

            foreach (var x in lista)
                cena += x.Cena;

            return cena;
        }

        private void lBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lBox.SelectedItem != null)
            {
                int index = lBox.SelectedIndex;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(listaKomponenti[index].ToString(), this, PointToClient(Cursor.Position), 2000);
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (lBox.SelectedIndex != -1)
            {
                int index = lBox.SelectedIndex;
                listaKomponenti.RemoveAt(index);
                listaProizvoda.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Ne mozete brisati kada nista nije selektovano.");
            }

            if (listaProizvoda.Count == 0)
            {
                btnUkloni.Enabled = false;
                btnKupi.Enabled = false;
            }

            PostaviLabelu(IzracunajCenu(listaProizvoda));
            lBox.DataSource = null;
            lBox.DataSource = listaProizvoda;
            lBox.Refresh();
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            //TODO: dodati da se radi update ukoliko je kolicina kada se oduzme > 0, ili delete elementa i referenci svuda gde se pojavljuje
            MessageBox.Show("Kupili ste " + listaProizvoda.Count.ToString() + " artikla, i vas racun je " + IzracunajCenu(listaProizvoda).ToString() + " dinara.");
            this.Close();
        }
    }
}
