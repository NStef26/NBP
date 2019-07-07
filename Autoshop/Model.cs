using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Autoshop
{
   public  class Model
    {
        public ObjectId Id { get; set; }
        public string ModelAuta { get; set; }
        public int Godiste { get; set; }
        public List<MongoDBRef> ListaKomponenti { get; set; }
        //public MongoDBRef Marka { get; set; }

        public Model()
        {
            ListaKomponenti = new List<MongoDBRef>();
        }
    }
}
