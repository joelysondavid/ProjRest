using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public class Util
    {

        // método auxiliar que apaga os textbox
        public static void ClearTxt(Panel panel)
        {
            // obtem os campos
            var campos = panel.Controls;

            // apaga cada campo que for txtbox
            foreach (Control campo in campos)
            {
                if (campo.GetType() == typeof(TextBox)||campo.GetType()==typeof(MaskedTextBox))
                    campo.Text = "";
            }
        }

        public static bool VerificaNome(string nome)
        {
            if (nome.Where(c => char.IsLetter(c)).Count() == nome.Length)
                return true;
            else
            {
                MessageBox.Show("Nome inválido, certifique-se de que o nome está escrito corretamente!", "Aviso!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
