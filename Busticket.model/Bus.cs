using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busticket.model
{
     public class Bus
    {
        public int id {  get; set; }
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BusNumber { get; set; }

        public string SeatCapacity { get; set; }

    }
}
