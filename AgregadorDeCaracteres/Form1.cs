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
        public Form1()
        {
            InitializeComponent();
        }

        private void fBtnIncluirAntes_Click(object sender, EventArgs e)
        {
            IncluirTexto(IncluirEm.Antes);
        }

        private void fBtnIncluirDepois_Click(object sender, EventArgs e)
        {
            IncluirTexto(IncluirEm.Depois);
        }

        private void IncluirTexto(IncluirEm incluirEm)
        {
            IncluirTexto(incluirEm, 0);
        }

        private void IncluirTexto(IncluirEm incluirEm, int espaco)
        {
            string textoIncluir = TextoIncluir.ObterTexto();
            if (string.IsNullOrEmpty(textoIncluir))
                return;

            List<string> palavras = new List<string>();
            foreach (string palavra in fTxtTexto.Text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None))
                if (incluirEm == IncluirEm.Antes)
                    palavras.Add(textoIncluir + palavra);
                else if (incluirEm == IncluirEm.Depois)
                    palavras.Add(palavra + textoIncluir);
                else if (incluirEm == IncluirEm.Espaco)
                    palavras.Add(IncluirEmEspaco(palavra, textoIncluir, espaco));
            fTxtTexto.Text = string.Join(Environment.NewLine, palavras.ToArray());
        }

        private string IncluirEmEspaco(string linha, string palavraIncluir, int espaco)
        {
            string[] palavras = linha.Split(' ');
            string palavraMontada = string.Empty;
            int contador = 0;

            foreach (string palavra in palavras) {
                if (contador == 0)
                    palavraMontada += palavra;
                else if (contador == espaco)
                    palavraMontada += palavraIncluir + palavra;
                else
                    palavraMontada += " " + palavra;
                contador++;
            }

            return palavraMontada;
        }

        private void fBtnIncluirEmEspaco_Click(object sender, EventArgs e)
        {
            int espaco = NumeroEspaco.ObterNumero();
            if (espaco < 1)
                return;

            IncluirTexto(IncluirEm.Espaco, espaco);
        }

        private void fTxtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                fTxtTexto.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.Back)
            {
                SendKeys.SendWait("^+{LEFT}{BACKSPACE}");
            }
        }

        private void fBtnTrim_Click(object sender, EventArgs e)
        {
            KeyValuePair<bool?, bool?> trimEsquerdaDireita = Trim.ObterInformacoesTrim();
            if (trimEsquerdaDireita.Key.HasValue && trimEsquerdaDireita.Value.HasValue)
            {
                string palavraAlterada = string.Empty;
                List<string> palavras = new List<string>();
                foreach (string palavra in fTxtTexto.Text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None))
                {
                    palavraAlterada = palavra;
                    if (trimEsquerdaDireita.Key.Value)
                        palavraAlterada = palavraAlterada.TrimStart();
                    if (trimEsquerdaDireita.Value.Value)
                        palavraAlterada = palavraAlterada.TrimEnd();
                    palavras.Add(palavraAlterada);
                }
                fTxtTexto.Text = string.Join(Environment.NewLine, palavras.ToArray());
            }
        }
    }

    public enum IncluirEm
    {
        Antes = 1,
        Depois,
        Espaco
    }
}