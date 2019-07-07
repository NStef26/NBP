using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;



namespace Autoshop.Komponente
{
    public class Komponenta
    {
        public ObjectId Id { get; set; }
        public double Cena { get; set; }
        public int Kolicina { get; set; }
        //public  image { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }

    }
}
