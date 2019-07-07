using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Autoshop
{
    public class Marka 
    {
        public ObjectId Id { get; set; }
        public string MarkaAutomobila { get; set; }
        public List<MongoDBRef> Modeli { get; set; }
        public Marka()
        {
            Modeli = new List<MongoDBRef>();
        }
    }
}
