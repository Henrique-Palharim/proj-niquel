namespace CacaNiquel
{
    partial class frmCacaNiquel
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
            this.components = new System.ComponentModel.Container();
            this.lblNumNiquel1 = new System.Windows.Forms.Label();
            this.lblNumNiquel2 = new System.Windows.Forms.Label();
            this.lblNumNiquel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btJogar = new System.Windows.Forms.Button();
            this.tmrNiquel = new System.Windows.Forms.Timer(this.components);
            this.btSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumNiquel1
            // 
            this.lblNumNiquel1.BackColor = System.Drawing.Color.White;
            this.lblNumNiquel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumNiquel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumNiquel1.ForeColor = System.Drawing.Color.Black;
            this.lblNumNiquel1.Location = new System.Drawing.Point(78, 428);
            this.lblNumNiquel1.Name = "lblNumNiquel1";
            this.lblNumNiquel1.Size = new System.Drawing.Size(85, 82);
            this.lblNumNiquel1.TabIndex = 0;
            this.lblNumNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumNiquel2
            // 
            this.lblNumNiquel2.BackColor = System.Drawing.Color.White;
            this.lblNumNiquel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumNiquel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumNiquel2.ForeColor = System.Drawing.Color.Black;
            this.lblNumNiquel2.Location = new System.Drawing.Point(187, 428);
            this.lblNumNiquel2.Name = "lblNumNiquel2";
            this.lblNumNiquel2.Size = new System.Drawing.Size(85, 82);
            this.lblNumNiquel2.TabIndex = 1;
            this.lblNumNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumNiquel3
            // 
            this.lblNumNiquel3.BackColor = System.Drawing.Color.White;
            this.lblNumNiquel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumNiquel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumNiquel3.ForeColor = System.Drawing.Color.Black;
            this.lblNumNiquel3.Location = new System.Drawing.Point(299, 428);
            this.lblNumNiquel3.Name = "lblNumNiquel3";
            this.lblNumNiquel3.Size = new System.Drawing.Size(85, 82);
            this.lblNumNiquel3.TabIndex = 2;
            this.lblNumNiquel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAÇA NÍQUEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJogar.Location = new System.Drawing.Point(78, 590);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(183, 49);
            this.btJogar.TabIndex = 5;
            this.btJogar.Text = "&Jogar";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // tmrNiquel
            // 
            this.tmrNiquel.Interval = 300;
            this.tmrNiquel.Tick += new System.EventHandler(this.tmrNiquel_Tick);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Salmon;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(278, 590);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(106, 49);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CacaNiquel.Properties.Resources.tigrinho;
            this.pictureBox1.Location = new System.Drawing.Point(78, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmCacaNiquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::CacaNiquel.Properties.Resources.testea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 706);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumNiquel3);
            this.Controls.Add(this.lblNumNiquel2);
            this.Controls.Add(this.lblNumNiquel1);
            this.Name = "frmCacaNiquel";
            this.Text = "Caça Níquel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCacaNiquel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumNiquel1;
        private System.Windows.Forms.Label lblNumNiquel2;
        private System.Windows.Forms.Label lblNumNiquel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Timer tmrNiquel;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

