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
        public Megrendeles(string id, string datum, string email)
        {
            this.email=email;
            this.id=id;
            this.datum=datum;
            
        }
    }
}
