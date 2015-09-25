namespace AgregadorDeCaracteres
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fTxtTexto = new System.Windows.Forms.TextBox();
            this.fBtnIncluirAntes = new System.Windows.Forms.Button();
            this.fBtnIncluirEmEspaco = new System.Windows.Forms.Button();
            this.fBtnIncluirDepois = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fTxtTexto
            // 
            this.fTxtTexto.BackColor = System.Drawing.Color.Azure;
            this.fTxtTexto.Location = new System.Drawing.Point(12, 12);
            this.fTxtTexto.MaxLength = 999999999;
            this.fTxtTexto.Multiline = true;
            this.fTxtTexto.Name = "fTxtTexto";
            this.fTxtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fTxtTexto.Size = new System.Drawing.Size(483, 320);
            this.fTxtTexto.TabIndex = 0;
            // 
            // fBtnIncluirAntes
            // 
            this.fBtnIncluirAntes.Location = new System.Drawing.Point(12, 338);
            this.fBtnIncluirAntes.Name = "fBtnIncluirAntes";
            this.fBtnIncluirAntes.Size = new System.Drawing.Size(75, 23);
            this.fBtnIncluirAntes.TabIndex = 1;
            this.fBtnIncluirAntes.Text = "Incluir Antes";
            this.fBtnIncluirAntes.UseVisualStyleBackColor = true;
            this.fBtnIncluirAntes.Click += new System.EventHandler(this.fBtnIncluirAntes_Click);
            // 
            // fBtnIncluirEmEspaco
            // 
            this.fBtnIncluirEmEspaco.Location = new System.Drawing.Point(202, 338);
            this.fBtnIncluirEmEspaco.Name = "fBtnIncluirEmEspaco";
            this.fBtnIncluirEmEspaco.Size = new System.Drawing.Size(104, 23);
            this.fBtnIncluirEmEspaco.TabIndex = 2;
            this.fBtnIncluirEmEspaco.Text = "Incluir em Espaço";
            this.fBtnIncluirEmEspaco.UseVisualStyleBackColor = true;
            this.fBtnIncluirEmEspaco.Click += new System.EventHandler(this.fBtnIncluirEmEspaco_Click);
            // 
            // fBtnIncluirDepois
            // 
            this.fBtnIncluirDepois.Location = new System.Drawing.Point(412, 338);
            this.fBtnIncluirDepois.Name = "fBtnIncluirDepois";
            this.fBtnIncluirDepois.Size = new System.Drawing.Size(83, 23);
            this.fBtnIncluirDepois.TabIndex = 3;
            this.fBtnIncluirDepois.Text = "Incluir Depois";
            this.fBtnIncluirDepois.UseVisualStyleBackColor = true;
            this.fBtnIncluirDepois.Click += new System.EventHandler(this.fBtnIncluirDepois_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(507, 395);
            this.Controls.Add(this.fBtnIncluirDepois);
            this.Controls.Add(this.fBtnIncluirEmEspaco);
            this.Controls.Add(this.fBtnIncluirAntes);
            this.Controls.Add(this.fTxtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agregador de Caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fTxtTexto;
        private System.Windows.Forms.Button fBtnIncluirAntes;
        private System.Windows.Forms.Button fBtnIncluirEmEspaco;
        private System.Windows.Forms.Button fBtnIncluirDepois;
    }
}

