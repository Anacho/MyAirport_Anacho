using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Entities
{
    public class VolDefinition
    {
        public int? Id { get; set; }
        public string CIE { get; set; }
        public string Ligne { get; set; }
        public DateTime Date { get; set; }
        public List<string> Banques { get; set; }
    }
}
