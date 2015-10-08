using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAirport.Entities;

namespace MyAirport.Model
{
    /// <summary>
    /// Classe mère pour tous les modèles d'accès aux données
    /// </summary>
    public abstract class ModelPIM
    {
        /// <summary>
        /// Retourne un vol unique via son id
        /// </summary>
        /// <param name="idVol">Id unique du vol</param>
        /// <returns>VolDefinition correspondant à l'id donné en param</returns>
        abstract public VolDefinition GetVol(int idVol);

        abstract public BagageDefinition GetBagage(int idBagage);
    }
}
