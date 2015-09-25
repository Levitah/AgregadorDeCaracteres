using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgregadorDeCaracteres
{
    public partial class NumeroEspaco : Form
    {
        private int Numero { get; set; }

        public static int ObterNumero()
        {
            NumeroEspaco formulario = new NumeroEspaco();
            formulario.ShowDialog();
            return formulario.Numero;
        }

        public NumeroEspaco()
        {
            InitializeComponent();
        }

        private void fBtnConfirmar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (int.TryParse(fTxtNumero.Text, out numero))
            {
                Numero = int.Parse(fTxtNumero.Text);
                this.Close();
            }
        }

        private void fBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}