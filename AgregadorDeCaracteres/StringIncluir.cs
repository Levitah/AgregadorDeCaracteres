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
    public partial class StringIncluir : Form
    {
        public string retorno { get; set; }

        public static string ObterString()
        {
            StringIncluir formulario = new StringIncluir();
            formulario.ShowDialog();
            return formulario.retorno;
        }

        public StringIncluir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retorno = textBox1.Text;
            this.Close();
        }
    }
}
