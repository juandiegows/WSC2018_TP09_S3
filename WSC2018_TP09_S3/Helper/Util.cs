
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

        public static void Requerido(this PictureBox text)
        {

            text.Validating += (sender, e) =>
            {
                Error.SetError(text, "");

                if (text.Image == null)
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
        public static void ClearAll(this Form form)
        {
            ClearAllItem(form.Controls);
        }

        private static void ClearAllItem(Control.ControlCollection item)
        {
            foreach (var item2 in item)
            {
                if (item2 is TextBox)
                {
                    (item2 as TextBox).Text = "";
                }
                if (item2 is PictureBox)
                {
                    (item2 as PictureBox).Image = null;
                }
                if (item2 is Panel)
                {
                    ClearAllItem((item2 as Panel).Controls);
          
                }
                if (item2 is GroupBox)
                {
                    ClearAllItem((item2 as GroupBox).Controls);

                }
                if (item2 is FlowLayoutPanel)
                {
                    ClearAllItem((item2 as FlowLayoutPanel).Controls);

                }
            }
        }
    }
}
