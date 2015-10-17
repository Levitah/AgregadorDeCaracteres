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
    public partial class Trim : Form
    {
        private KeyValuePair<bool?, bool?> TrimEsquerdaDireita { get; set; }

        public static KeyValuePair<bool?, bool?> ObterInformacoesTrim()
        {
            Trim formulario = new Trim();
            formulario.ShowDialog();
            return formulario.TrimEsquerdaDireita;
        }

        public Trim()
        {
            InitializeComponent();
            TrimEsquerdaDireita = new KeyValuePair<bool?, bool?>(null, null);
        }

        private void fBtnConfirmar_Click(object sender, EventArgs e)
        {
            TrimEsquerdaDireita = new KeyValuePair<bool?, bool?>(fChkEsquerda.Checked, fChkDireita.Checked);
            this.Close();
        }

        private void fBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}