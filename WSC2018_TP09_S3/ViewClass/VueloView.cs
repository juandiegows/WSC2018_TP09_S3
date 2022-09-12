using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSC2018_TP09_S3.ViewClass
{
    public class VueloView
    {

        public int ID { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("N° Vuelo")]
        public String NumeroVuelo { get; set; }
        [DisplayName("Precio de Cabina")]
        public double EconomyPrice { get; set; }
    }
}
