using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class raw_data_read
    {

        public double Strain { get; set; }
        public double Standart_force { get; set; }
        public double time { get; set; }
        

        public double get_data_final()
        {
            return this.Strain + this.Standart_force + this.time;
        }

    }
}
