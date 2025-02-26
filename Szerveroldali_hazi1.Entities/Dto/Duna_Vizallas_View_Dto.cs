using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szerveroldali_hazi1.Entities.Dto
{
    public class Duna_Vizallas_View_Dto
    {


        public string Month { get; set; }
        public int average_value { get; set; }

        public int Minimal_value
        {
            get
            {
                return average_value - 70;

            }


        }

        public int Maximal_value
        {
            get
            {
                return average_value + 40;

            }


        }
    }
}
