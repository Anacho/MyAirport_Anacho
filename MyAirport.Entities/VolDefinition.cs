using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Entities
{
    public class VolDefinition
    {
        private int? id;
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string CIE { get; set; }
        public string Ligne;
        public DateTime Date;
        public List<string> Banques;
    }
}
