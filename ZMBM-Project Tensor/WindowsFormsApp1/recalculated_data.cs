using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class recalculated_data
    {

        public double Strain_calc { get; set; }
    //    public double Standart_force_calc { get; set; }
        public double time_calc { get; set; }


        public double get_data_final()
        {
            return this.Strain_calc +/* this.Standart_force_calc*/ + this.time_calc;
        }
    }
}
