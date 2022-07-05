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
        public DateTime time;

        public Dieux(string nom, DateTime time)
        {
            this.nom = nom;
            this.time = time;
        }

        public string Nom { get => nom; set => nom = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}
