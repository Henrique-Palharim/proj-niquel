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
            // Limpar o conteúdo anterior antes de gerar os novos números
            lstNumCartoes.Items.Clear();
            lblNumerosRepetidos.Text = "";  // Limpar o texto de números repetidos

            // Lista para armazenar números já sorteados (de todos os cartões)
            List<int> numerosSorteadosGlobal = new List<int>();  // Lista global de números sorteados
            List<int> numerosRepetidos = new List<int>();  // Lista para armazenar números repetidos

            // Quantidade de linhas (cartões)
            for (int i = 0; i < Convert.ToInt32(txtQuantidadeCartoes.Text); i++)
            {
                string numerosCartao = ""; // Para armazenar os números do cartão com separador
                List<int> numerosSorteadosCartao = new List<int>(); // Lista para armazenar os números sorteados do cartão atual

                // Quantidade de colunas (números por cartão)
                for (int j = 0; j < 6; j++)
                {
                    // Gerar número aleatório entre 1 e 50 sem repetição no cartão
                    do
                    {
                        numeroSorteado = sorteio.Next(1, 51);
                    } while (numerosSorteadosCartao.Contains(numeroSorteado));  // Evita número repetido dentro do mesmo cartão

                    cartao[i, j] = numeroSorteado;

                    // Adiciona o número ao cartão com separador
                    if (j == 5)
                    {
                        // Não adicionar o traço no último número
                        numerosCartao += numeroSorteado.ToString("00");
                    }
                    else
                    {
                        // Adicionando número com traço
                        numerosCartao += numeroSorteado.ToString("00") + " - ";
                    }

                    // Verificar se o número já foi sorteado em outros cartões
                    if (numerosSorteadosGlobal.Contains(numeroSorteado) && !numerosRepetidos.Contains(numeroSorteado))
                    {
                        // Adicionar à lista de repetidos
                        numerosRepetidos.Add(numeroSorteado);
                    }

                    // Adicionar o número à lista global de números sorteados
                    numerosSorteadosGlobal.Add(numeroSorteado);

                    // Adicionar número ao cartão do sorteio atual
                    numerosSorteadosCartao.Add(numeroSorteado);
                }

                // Ordenar os números do cartão antes de exibir
                int[] linhaOrdenada = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    linhaOrdenada[j] = cartao[i, j];
                }
                Array.Sort(linhaOrdenada);  // Ordenar os números da linha em ordem crescente

                // Atualizar a matriz com os números ordenados
                for (int j = 0; j < 6; j++)
                {
                    cartao[i, j] = linhaOrdenada[j];
                }

                // Atualizar a string de números do cartão com os números ordenados
                numerosCartao = string.Join(" - ", linhaOrdenada.Select(n => n.ToString("00")));

                // Exibir o número no label e na lista de cartões
                lstNumCartoes.Items.Add("     " + numerosCartao);  // Adiciona o cartão na lista
            }

            // Exibir os números repetidos em ordem crescente e formatados em uma única linha, separados por " - "
            if (numerosRepetidos.Count > 0)
            {
                // Ordenar a lista de números repetidos em ordem crescente
                numerosRepetidos.Sort();  // Ordenar a lista em ordem crescente

                // Armazenar os números repetidos em uma matriz (lista de listas) para garantir a quebra de linha a cada 8 números
                List<List<int>> numerosRepetidosFormatados = new List<List<int>>();
                List<int> linhaAtual = new List<int>();

                foreach (var numero in numerosRepetidos)
                {
                    linhaAtual.Add(numero);
                    if (linhaAtual.Count == 8)  // A cada 8 números, cria uma nova linha
                    {
                        numerosRepetidosFormatados.Add(new List<int>(linhaAtual));
                        linhaAtual.Clear();
                    }
                }

                // Adicionar qualquer número restante que não tenha completado a linha de 8
                if (linhaAtual.Count > 0)
                {
                    numerosRepetidosFormatados.Add(linhaAtual);
                }

                // Agora, formatamos os números repetidos para a label, com quebras de linha entre as listas de 8 números
                lblNumerosRepetidos.Text = FormatRepetidosParaLabel(numerosRepetidosFormatados);
            }
        }


        // Função que formata os números repetidos para exibição na label, com quebras de linha a cada 8 números
        private string FormatRepetidosParaLabel(List<List<int>> numerosRepetidosFormatados)
        {
            StringBuilder formattedText = new StringBuilder();

            foreach (var linha in numerosRepetidosFormatados)
            {
                // Criar a string de números para cada linha, separando com " - "
                string linhaFormatada = string.Join(" - ", linha.Select(n => n.ToString("00")));
                formattedText.AppendLine(linhaFormatada);  // Adiciona a linha formatada
            }

            return formattedText.ToString();
        }





    }
}