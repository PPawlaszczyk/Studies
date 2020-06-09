using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_wielki_piec
{
    public class Sensor_data_txt
    {

        public string time { get; set; }
        public string value { get; set; }
        public string ticking_time { get; set; }
        public string get_data()
        {
            return this.time + this.value + this.ticking_time;
        }

    }
}
