using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Factory
{
    public static class ModelsFactory
    {
        private static MyAirport.Model.ModelPIM Singleton = null;

        public static MyAirport.Model.ModelPIM Model
        {
            get
            {
                if (Singleton == null)
                {
                    switch (ConfigurationManager.AppSettings["Factory"])
                    {
                        //case "SQL"
                        //singleton = new MyAirport.Model.ModelSql();
                        //break;
                        case "Natif":
                            Singleton = new MyAirport.Model.NatifModel();
                            break;
                    }
                }
                return Singleton;
            }
        }
    }
}
