using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_wielki_piec
{
    public class Every_Sensor_data
    {

        public string time_every { get; set; }
        public string value_1 { get; set; }
        public string value_2 { get; set; }
        public string value_3 { get; set; }

        public string get_data_final()
        {
            return this.time_every + this.value_1 + this.value_2 + this.value_3;
        }

    }
}
