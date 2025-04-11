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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btSortearNumeros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeCartoes = new System.Windows.Forms.TextBox();
            this.lstNumCartoes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeros.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.ForeColor = System.Drawing.Color.White;
            this.lblNumeros.Location = new System.Drawing.Point(42, 75);
            this.lblNumeros.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(504, 52);
            this.lblNumeros.TabIndex = 0;
            // 
            // btSortearNumeros
            // 
            this.btSortearNumeros.Location = new System.Drawing.Point(214, 518);
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
            this.lstNumCartoes.Location = new System.Drawing.Point(42, 164);
            this.lstNumCartoes.Name = "lstNumCartoes";
            this.lstNumCartoes.Size = new System.Drawing.Size(504, 312);
            this.lstNumCartoes.TabIndex = 4;
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(593, 638);
            this.Controls.Add(this.lstNumCartoes);
            this.Controls.Add(this.txtQuantidadeCartoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSortearNumeros);
            this.Controls.Add(this.lblNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmMegaSena";
            this.Text = "Mega Sena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btSortearNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeCartoes;
        private System.Windows.Forms.ListBox lstNumCartoes;
    }
}