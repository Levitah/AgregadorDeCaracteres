namespace AgregadorDeCaracteres
{
    partial class Trim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trim));
            this.fChkEsquerda = new System.Windows.Forms.CheckBox();
            this.fChkDireita = new System.Windows.Forms.CheckBox();
            this.fBtnCancelar = new System.Windows.Forms.Button();
            this.fBtnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fChkEsquerda
            // 
            this.fChkEsquerda.AutoSize = true;
            this.fChkEsquerda.Checked = true;
            this.fChkEsquerda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fChkEsquerda.Location = new System.Drawing.Point(22, 16);
            this.fChkEsquerda.Name = "fChkEsquerda";
            this.fChkEsquerda.Size = new System.Drawing.Size(71, 17);
            this.fChkEsquerda.TabIndex = 0;
            this.fChkEsquerda.Text = "Esquerda";
            this.fChkEsquerda.UseVisualStyleBackColor = true;
            // 
            // fChkDireita
            // 
            this.fChkDireita.AutoSize = true;
            this.fChkDireita.Checked = true;
            this.fChkDireita.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fChkDireita.Location = new System.Drawing.Point(122, 16);
            this.fChkDireita.Name = "fChkDireita";
            this.fChkDireita.Size = new System.Drawing.Size(56, 17);
            this.fChkDireita.TabIndex = 1;
            this.fChkDireita.Text = "Direita";
            this.fChkDireita.UseVisualStyleBackColor = true;
            // 
            // fBtnCancelar
            // 
            this.fBtnCancelar.Location = new System.Drawing.Point(103, 50);
            this.fBtnCancelar.Name = "fBtnCancelar";
            this.fBtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.fBtnCancelar.TabIndex = 4;
            this.fBtnCancelar.Text = "Cancelar";
            this.fBtnCancelar.UseVisualStyleBackColor = true;
            this.fBtnCancelar.Click += new System.EventHandler(this.fBtnCancelar_Click);
            // 
            // fBtnConfirmar
            // 
            this.fBtnConfirmar.Location = new System.Drawing.Point(22, 50);
            this.fBtnConfirmar.Name = "fBtnConfirmar";
            this.fBtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.fBtnConfirmar.TabIndex = 3;
            this.fBtnConfirmar.Text = "Confirmar";
            this.fBtnConfirmar.UseVisualStyleBackColor = true;
            this.fBtnConfirmar.Click += new System.EventHandler(this.fBtnConfirmar_Click);
            // 
            // Trim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(200, 85);
            this.Controls.Add(this.fBtnCancelar);
            this.Controls.Add(this.fBtnConfirmar);
            this.Controls.Add(this.fChkDireita);
            this.Controls.Add(this.fChkEsquerda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trim";
            this.Text = "Trim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fChkEsquerda;
        private System.Windows.Forms.CheckBox fChkDireita;
        private System.Windows.Forms.Button fBtnCancelar;
        private System.Windows.Forms.Button fBtnConfirmar;
    }
}