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
    public partial class frmMegaSena : Form
    {
        /*
            
            Henrique - 09
            CTI - Informática II Noturno

        */


        /* -------------------- VARIÁVEIS GLOBAIS -------------------- */

        private Random sorteio = new Random();
        private int numeroSorteado;
        private int[,] cartao; // declarando a matriz sem iniclializar com valores

        /* -------------------- COMPONENTES -------------------- */

        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void btSortearNumeros_Click(object sender, EventArgs e)
        {
            // consistência de dados - quantidade de cartões
            if (String.IsNullOrWhiteSpace(txtQuantidadeCartoes.Text))
            {
                MessageBox.Show("Informe a quantidade de cartões desejados !!",
                    "Mega Sena",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
                return;
            }

            // verificar se existe cartões
            if (Convert.ToInt32(txtQuantidadeCartoes.Text) <= 0)
            {
                MessageBox.Show("A quantidade de cartões deve ser maior que zero.",
                        "Mega Sena",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );
            }
            else
            {
                cartao = new int[Convert.ToInt32(txtQuantidadeCartoes.Text), 6]; // definindo o tamanho (dimensões) da matriz
                GerarCartoes();
            }

        }

        /* -------------------- FUNÇÕES -------------------- */

        private void GerarCartoes()
        {
            // limpar o conteúdo anterior antes de gerar os novos números
            lstNumCartoes.Items.Clear();

            // quantidade de linhas (cartões)
            for (int i = 0; i < Convert.ToInt32(txtQuantidadeCartoes.Text); i++)
            {
                string numerosCartao = ""; // para armazenar os números do cartão com separador
                List<int> numerosSorteados = new List<int>(); // lista para armazenar os números já sorteados

                // quantidade de colunas (números por cartão)
                for (int j = 0; j < 6; j++)
                {
                    // gerar número aleatório entre 1 e 75 sem repetição
                    do
                    {
                        numeroSorteado = sorteio.Next(1, 76);
                    } while (numerosSorteados.Contains(numeroSorteado));  // evita número repetido no cartão

                    cartao[i, j] = numeroSorteado;

                    // adicionando número ao cartão com separador
                    if (j == 5)
                    {
                        // não adicionar o traço no último número
                        numerosCartao += numeroSorteado.ToString("00");
                    }
                    else
                    {
                        // adicionando número com traço
                        numerosCartao += numeroSorteado.ToString("00") + " - ";
                    }
                }

                // exibir no label e na lista de cartões
                lblNumeros.Text += numerosCartao + " - ";  // adiciona o cartão na label com quebra de linha
                lstNumCartoes.Items.Add(numerosCartao);  // adiciona o cartão na lista
            }
        }
    }
}