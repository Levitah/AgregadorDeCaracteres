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
    public partial class Form1 : Form
    {
        public string[] SEPARADOR { get; set; }
        public string[] SEPARADOR_PALAVRA { get; set; }

        public Form1()
        {
            InitializeComponent();
            SEPARADOR = new string[1];
            SEPARADOR[0] = Environment.NewLine;

            SEPARADOR_PALAVRA = new string[2];
            SEPARADOR_PALAVRA[0] = "\t";
            SEPARADOR_PALAVRA[1] = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoFinal = string.Empty;

            string textoSolicitado = StringIncluir.ObterString();

            foreach (string linha in texto.Split(SEPARADOR, StringSplitOptions.None))
                textoFinal = string.Format("{0}{1}{2}{3}", textoFinal, Environment.NewLine, textoSolicitado, linha);

            textBox1.Text = textoFinal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoFinal = string.Empty;

            string textoSolicitado = StringIncluir.ObterString();

            foreach (string linha in texto.Split(SEPARADOR, StringSplitOptions.None))
                textoFinal = string.Format("{0}{1}{2}{3}", textoFinal, Environment.NewLine, linha, textoSolicitado);

            textBox1.Text = textoFinal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> retorno = StringIncluirEspaco.ObterString();
            int emEspaco = retorno.Key;
            int contadorEspacos = 0;
            string texto = textBox1.Text;
            string textoFinal = string.Empty;
            string textoSolicitado = retorno.Value;
            string novaLinha = string.Empty;

            foreach (string linha in texto.Split(SEPARADOR, StringSplitOptions.None))
            {
                foreach (string palavra in linha.Split(SEPARADOR_PALAVRA, StringSplitOptions.None))
                {
                    if (contadorEspacos == emEspaco)
                        novaLinha += textoSolicitado + palavra;
                    else
                    {
                        if (contadorEspacos == 0)
                            novaLinha += palavra;
                        else
                            novaLinha += " " + palavra;
                    }

                    contadorEspacos = contadorEspacos + 1;
                }

                textoFinal = string.Format("{0}{1}{2}", textoFinal, Environment.NewLine, novaLinha);
                novaLinha = string.Empty;
                contadorEspacos = 0;
            }

            textBox1.Text = textoFinal;
        }
    }
}