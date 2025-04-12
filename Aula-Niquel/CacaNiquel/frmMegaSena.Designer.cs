namespace CacaNiquel
{
    partial class frmMegaSena
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
            this.btSortearNumeros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeCartoes = new System.Windows.Forms.TextBox();
            this.lstNumCartoes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumerosRepetidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSortearNumeros
            // 
            this.btSortearNumeros.Location = new System.Drawing.Point(230, 785);
            this.btSortearNumeros.Margin = new System.Windows.Forms.Padding(7);
            this.btSortearNumeros.Name = "btSortearNumeros";
            this.btSortearNumeros.Size = new System.Drawing.Size(133, 87);
            this.btSortearNumeros.TabIndex = 1;
            this.btSortearNumeros.Text = "Sortear Números";
            this.btSortearNumeros.UseVisualStyleBackColor = true;
            this.btSortearNumeros.Click += new System.EventHandler(this.btSortearNumeros_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de Cartões:";
            // 
            // txtQuantidadeCartoes
            // 
            this.txtQuantidadeCartoes.Location = new System.Drawing.Point(327, 25);
            this.txtQuantidadeCartoes.Name = "txtQuantidadeCartoes";
            this.txtQuantidadeCartoes.Size = new System.Drawing.Size(219, 35);
            this.txtQuantidadeCartoes.TabIndex = 3;
            // 
            // lstNumCartoes
            // 
            this.lstNumCartoes.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumCartoes.FormattingEnabled = true;
            this.lstNumCartoes.ItemHeight = 28;
            this.lstNumCartoes.Location = new System.Drawing.Point(42, 150);
            this.lstNumCartoes.Name = "lstNumCartoes";
            this.lstNumCartoes.Size = new System.Drawing.Size(504, 312);
            this.lstNumCartoes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Números Repetidos:";
            // 
            // lblNumerosRepetidos
            // 
            this.lblNumerosRepetidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumerosRepetidos.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerosRepetidos.ForeColor = System.Drawing.Color.White;
            this.lblNumerosRepetidos.Location = new System.Drawing.Point(42, 546);
            this.lblNumerosRepetidos.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNumerosRepetidos.Name = "lblNumerosRepetidos";
            this.lblNumerosRepetidos.Size = new System.Drawing.Size(504, 208);
            this.lblNumerosRepetidos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Números Sorteados:";
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(593, 899);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumerosRepetidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNumCartoes);
            this.Controls.Add(this.txtQuantidadeCartoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSortearNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmMegaSena";
            this.Text = "Mega Sena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSortearNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeCartoes;
        private System.Windows.Forms.ListBox lstNumCartoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumerosRepetidos;
        private System.Windows.Forms.Label label1;
    }
}