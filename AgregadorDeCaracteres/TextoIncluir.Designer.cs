namespace AgregadorDeCaracteres
{
    partial class TextoIncluir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fTxtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fBtnConfirmar = new System.Windows.Forms.Button();
            this.fBtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fTxtTexto
            // 
            this.fTxtTexto.BackColor = System.Drawing.Color.Azure;
            this.fTxtTexto.Location = new System.Drawing.Point(57, 12);
            this.fTxtTexto.Name = "fTxtTexto";
            this.fTxtTexto.Size = new System.Drawing.Size(368, 20);
            this.fTxtTexto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto:";
            // 
            // fBtnConfirmar
            // 
            this.fBtnConfirmar.Location = new System.Drawing.Point(269, 38);
            this.fBtnConfirmar.Name = "fBtnConfirmar";
            this.fBtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.fBtnConfirmar.TabIndex = 1;
            this.fBtnConfirmar.Text = "Confirmar";
            this.fBtnConfirmar.UseVisualStyleBackColor = true;
            this.fBtnConfirmar.Click += new System.EventHandler(this.fBtnConfirmar_Click);
            // 
            // fBtnCancelar
            // 
            this.fBtnCancelar.Location = new System.Drawing.Point(350, 38);
            this.fBtnCancelar.Name = "fBtnCancelar";
            this.fBtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.fBtnCancelar.TabIndex = 2;
            this.fBtnCancelar.Text = "Cancelar";
            this.fBtnCancelar.UseVisualStyleBackColor = true;
            this.fBtnCancelar.Click += new System.EventHandler(this.fBtnCancelar_Click);
            // 
            // TextoIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(437, 71);
            this.Controls.Add(this.fBtnCancelar);
            this.Controls.Add(this.fBtnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fTxtTexto);
            this.Name = "TextoIncluir";
            this.Text = "Agregador de Caracteres - Texto para Inclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fTxtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fBtnConfirmar;
        private System.Windows.Forms.Button fBtnCancelar;
    }
}