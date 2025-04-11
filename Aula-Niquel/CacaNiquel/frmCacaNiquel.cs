/*
    se quiser exlcuir a parte de emoji ou de número, deve apagar os seguintes componentes:

    - tmrNiquel_Tick
    - btJogar_Click
    - função : VerificarVitoria()
 */

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
        private int contaGiro = 0, contaNiquel = 1;
        
        private string niquel1s, niquel2s, niquel3s;
        private string[] emoji = new string[]
        {
            "🍉", "🍇", "🍒", "🍊", "🍐", "🥑", "🍎", "🍈", "🥭", "🍌"
        };

        /* -------------------- COMPONENTES -------------------- */

        public frmCacaNiquel()
        {
            InitializeComponent();

            btJogar.Enabled = true;
            btJogarEmoji.Enabled = true;
        }

        private void tmrNiquel_Tick(object sender, EventArgs e)
        {

            // a cada tick do timer ocorre o seguinte :

            contaGiro++; // atualiza o contador a cada tick do timer

            // verificar em qual label o níquel está
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
                // atingiu a condição de término
                tmrNiquel.Enabled = false;

                lblNumNiquel1.Text = niquel1.ToString();
                lblNumNiquel2.Text = niquel2.ToString();
                lblNumNiquel3.Text = niquel3.ToString();

                VerificarVitoria();

                btJogar.Text = "&Jogar";

                contaGiro = 0;
                contaNiquel = 0;
            }

            // contGiro atinge o limite máximo de sorteios e passa para a próxima label, resetando o contador de giros
            if (contaGiro == 5)
            {
                contaNiquel++; // próxima label (número)
                contaGiro = 0;
            }

        }

        private void tmrNiquelEmoji_Tick(object sender, EventArgs e)
        {

            // a cada tick do timer ocorre o seguinte :

            contaGiro++; // atualiza o contador a cada tick do timer

            // verificar em qual label o níquel está
            if (contaNiquel == 1)
            {
                niquel1s = emoji[sorteio.Next(0, emoji.Length)];
                lblNumNiquel1.Text = niquel1s;
            }
            else if (contaNiquel == 2)
            {
                niquel2s = emoji[sorteio.Next(0, emoji.Length)];
                lblNumNiquel2.Text = niquel2s;
            }
            else if (contaNiquel == 3)
            {
                niquel3s = emoji[sorteio.Next(0, emoji.Length)];
                lblNumNiquel3.Text = niquel3s;
            }
            else
            {
                // atingiu a condição de término
                tmrNiquelEmoji.Enabled = false;

                lblNumNiquel1.Text = niquel1s;
                lblNumNiquel2.Text = niquel2s;
                lblNumNiquel3.Text = niquel3s;

                VerificarVitoriaEmoji();

                btJogarEmoji.Text = "&Jogar";

                contaGiro = 0;
                contaNiquel = 0;
            }

            // contGiro atinge o limite máximo de sorteios e passa para a próxima label, resetando o contador de giros
            if (contaGiro == 5)
            {
                contaNiquel++; // próxima label (número)
                contaGiro = 0;
            }

        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            
            btJogarEmoji.Enabled = false;
            if (tmrNiquel.Enabled) // se o temporizador estiver ativo, significa que o sorteio está ocorrendo
            {
                // para o sorteio
                tmrNiquel.Enabled = false;
                btJogar.Text = "&Continuar"; // altera o texto do botão para "Jogar"
            }
            else
            {
                // inicia o sorteio
                tmrNiquel.Enabled = true;
                btJogar.Text = "&Parar"; // altera o texto do botão para "Parar"
            }

        }

        private void btJogarEmoji_Click(object sender, EventArgs e)
        {

            btJogar.Enabled = false;
            if (tmrNiquelEmoji.Enabled) // se o temporizador estiver ativo, significa que o sorteio está ocorrendo
            {
                // para o sorteio
                tmrNiquelEmoji.Enabled = false;
                btJogarEmoji.Text = "&Continuar 🍒"; // altera o texto do botão para "Jogar"
            }
            else
            {
                // inicia o sorteio
                tmrNiquelEmoji.Enabled = true;
                btJogarEmoji.Text = "&Parar 🍒"; // altera o texto do botão para "Parar"
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            // encerra o programa
            Application.Exit();
        }

        private void frmCacaNiquel_FormClosing(object sender, FormClosingEventArgs e)
        {
            // verificar se o usuário realmente deseja sair
            DialogResult r = MessageBox.Show("Deseja mesmo sair da aplicação?", "", MessageBoxButtons.YesNo);

            if (r == DialogResult.No) e.Cancel = true;
            else e.Cancel = false;
        }

        /* -------------------- FUNÇÕES -------------------- */

        private void VerificarVitoria() // verificar quantos números da sequência sorteada são iguais
        {
            if (niquel1 == niquel2 && niquel1 == niquel3)
            {
                // todos os valores são iguais
                MessageBox.Show(
                    "Parabéns, você ganhou um MILHÃO 😄 !!!\n\n" +
                    $"Sequência: {niquel1.ToString()} - {niquel2.ToString()} - {niquel3.ToString()}",
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }
            else if (niquel1 == niquel2 || niquel1 == niquel3 || niquel2 == niquel3)
            {
                // apenas dois dos três valores são iguais
                MessageBox.Show(
                    "Parabéns, você ganhou um Milho 😐 !!\n\n" +
                    $"Sequência: {niquel1.ToString()} - {niquel2.ToString()} - {niquel3.ToString()}",
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }
            else
            {
                // nenhum dos valores são iguais
                MessageBox.Show(
                    "Parabéns, você ganhou um milhinho 😥 !\n\n" +
                    $"Sequência: {niquel1.ToString()} - {niquel2.ToString()} - {niquel3.ToString()}",
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }

        }

        private void VerificarVitoriaEmoji() // verificar quantos números da sequência sorteada são iguais
        {
            if (niquel1s == niquel2s && niquel1s == niquel3s)
            {
                // todos os valores são iguais
                MessageBox.Show(
                    "Parabéns, você ganhou um MILHÃO 😄 !!!\n\n" +
                    $"Sequência: {niquel1s} - {niquel2s} - {niquel3s}",
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }
            else if (niquel1s == niquel2s || niquel1s == niquel3s || niquel2s == niquel3s)
            {
                // apenas dois dos três valores são iguais
                MessageBox.Show(
                    "Parabéns, você ganhou um Milho 😐 !!\n\n" +
                    $"Sequência: {niquel1s} - {niquel2s} - {niquel3s}",
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }
            else
            {
                // nenhum dos valores são iguais
                MessageBox.Show(
                    "Parabéns, você ganhou um milhinho 😥 !\n\n" +
                    $"Sequência: {niquel1s} - {niquel2s} - {niquel3s}",
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }

        }
        
    }
}