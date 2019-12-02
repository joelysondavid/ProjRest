﻿using System;
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
                if (campo.GetType() == typeof(TextBox))
                    campo.Text = "";
            }
        }
    }
}