using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSC2018_TP09_S3.ViewClass
{
    public class UsuarioView
    {
        public String Nombres { set; get; }
        public String Apellidos { set; get; }
        public DateTime Fecha { set; get; }
        [DisplayName("N° Pasaporte")]
        public String Numero { set; get; }
        public int PaisID { set; get; }
        public String Pais { set; get; }
        public String Telefono { set; get; }
        public Image Photo { set; get; }
    }
}
