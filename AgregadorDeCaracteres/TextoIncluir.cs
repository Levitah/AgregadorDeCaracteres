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
    public partial class TextoIncluir : Form
    {
        private string Texto { get; set; }

        public static string ObterTexto()
        {
            TextoIncluir formulario = new TextoIncluir();
            formulario.ShowDialog();
            return formulario.Texto;
        }

        public TextoIncluir()
        {
            InitializeComponent();
        }

        private void fBtnConfirmar_Click(object sender, EventArgs e)
        {
            Texto = fTxtTexto.Text;
            this.Close();
        }

        private void fBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}