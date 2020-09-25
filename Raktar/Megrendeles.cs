    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class Megrendeles
    {
        private string datum;
        public string DATUM
        {
            get { return datum; }
            set { datum = value; }
        }
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }    
        private string email;

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        private List<Tetel> tetelek;
        public void TetelHozzaad(string kod, int db)
        {
            tetelek.Add(new Tetel(kod, db));
        }
        public Megrendeles(string id, string datum, string email)
        {
            this.email=email;
            this.id=id;
            this.datum=datum;
            tetelek = new List<Tetel>();
            
        }
    }
}
