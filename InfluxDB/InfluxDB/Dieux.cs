using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluxDB
{
    class Dieux
    {
        public string nom;
        public string time;

        public Dieux(string nom, string time)
        {
            this.nom = nom;
            this.time = time;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Time { get => time; set => time = value; }
    }
}
