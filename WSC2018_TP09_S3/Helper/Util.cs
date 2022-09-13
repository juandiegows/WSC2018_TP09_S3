
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2018_TP09_S3.Helper
{
    public static class Util
    {
        public static ErrorProvider Error = new ErrorProvider();
        public static void Requerido(this TextBox text)
        {
       
            text.Validating += (sender, e) =>
            {
                Error.SetError(text, "");
                text.Text = text.Text.TrimStart();
                if(text.Text.Trim().Length == 0)
                {
                    Error.SetError(text, "Este campo es obligatorio");
                    e.Cancel = true;
                    return;
                }
            };
        }
        public static void SoloNumero(this TextBox text)
        {
           
            text.KeyPress += (sender, e) =>
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                {

                    e.Handled = true;
                }
            };
        }
    }
}
