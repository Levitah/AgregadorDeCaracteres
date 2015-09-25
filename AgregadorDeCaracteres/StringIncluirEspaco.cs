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
    public partial class StringIncluirEspaco : Form
    {
        private KeyValuePair<int, string> retorno { get; set; }

        public static KeyValuePair<int, string> ObterString()
        {
            StringIncluirEspaco formulario = new StringIncluirEspaco();
            formulario.ShowDialog();
            return formulario.retorno;
        }

        public StringIncluirEspaco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retorno = new KeyValuePair<int, string>(int.Parse(textBox2.Text), textBox1.Text);
            this.Close();
        }
    }
}
