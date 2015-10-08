using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Entities;

// ReSharper disable once CheckNamespace
namespace MyAirport.Model
{
    public class NatifModel : Model.ModelPIM
    {
        public List<VolDefinition> Vols = new List<VolDefinition>
        {
            new VolDefinition {Id = 1, CIE="4U", Date = new DateTime(2015,10,08, 07,30,00), Ligne="75402"}
        };


        public override VolDefinition GetVol(int idVol)
        {
            return this.Vols.Find(x => x.Id == idVol);
        }

        public override BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }
    }
}
