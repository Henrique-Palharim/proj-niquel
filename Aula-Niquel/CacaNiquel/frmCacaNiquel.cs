using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaNiquel
{
    public partial class frmCacaNiquel : Form
    {

        /*
            
            Henrique - 09
            CTI - Informática II Noturno

        */


        /* -------------------- VARIÁVEIS GLOBAIS -------------------- */

        private Random sorteio = new Random();

        private int niquel1, niquel2, niquel3;
        private int contaGiro = 0;
        private int contaNiquel = 1;

        /* -------------------- COMPONENTES -------------------- */

        public frmCacaNiquel()
        {
            InitializeComponent();
            btJogar.Enabled = true;
        }

        private void tmrNiquel_Tick(object sender, EventArgs e)
        {
            contaGiro++;

            if (contaNiquel == 1)
            {
                niquel1 = sorteio.Next(0, 10);
                lblNumNiquel1.Text = niquel1.ToString();
            }
            else if (contaNiquel == 2)
            {
                niquel2 = sorteio.Next(0, 10);
                lblNumNiquel2.Text = niquel2.ToString();
            }
            else if (contaNiquel == 3)
            {
                niquel3 = sorteio.Next(0, 10);
                lblNumNiquel3.Text = niquel3.ToString();
            }
            else
            {
                tmrNiquel.Enabled = false;

                VerificarVitoria();

                // Reiniciar estados
                btJogar.Text = "&Jogar";
                contaGiro = 0;
                contaNiquel = 1;
                btJogar.Enabled = true;
            }

            if (contaGiro == 5)
            {
                contaNiquel++;
                contaGiro = 0;
            }
        }

        /* -------------------- FUNÇÕES -------------------- */

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (btJogar.Text == "&Jogar")
            {
                LimparLabels();
                contaNiquel = 1;
                contaGiro = 0;

                tmrNiquel.Enabled = true;
                btJogar.Text = "&Parar";
            }
            else if (btJogar.Text == "&Parar")
            {
                tmrNiquel.Enabled = false;
                btJogar.Text = "&Continuar";
            }
            else if (btJogar.Text == "&Continuar")
            {
                tmrNiquel.Enabled = true;
                btJogar.Text = "&Parar";
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCacaNiquel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja mesmo sair da aplicação?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void LimparLabels()
        {
            lblNumNiquel1.Text = "";
            lblNumNiquel2.Text = "";
            lblNumNiquel3.Text = "";
        }

        private void VerificarVitoria()
        {
            string sequencia = $"{niquel1} - {niquel2} - {niquel3}";

            if (niquel1 == niquel2 && niquel1 == niquel3)
            {
                MessageBox.Show($"Parabéns, você ganhou um MILHÃO 😄 !!!\n\nSequência: {sequencia}", "Tigrinho Wins !!!");
            }
            else if (niquel1 == niquel2 || niquel1 == niquel3 || niquel2 == niquel3)
            {
                MessageBox.Show($"Parabéns, você ganhou um Milho 😐 !!\n\nSequência: {sequencia}", "Tigrinho Wins !!!");
            }
            else
            {
                MessageBox.Show($"Parabéns, você ganhou um milhinho 😥 !\n\nSequência: {sequencia}", "Tigrinho Wins !!!");
            }
        }
    }
}