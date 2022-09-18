using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05___RA6322098
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jogador player;
        Jogador[] vetorJogador = new Jogador[3];
        int i = 0;
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                player = new Jogador();
                player.Nome = txtNome.Text;
                player.Peso = Convert.ToDouble(txtPeso.Text);
                player.Altura = Convert.ToDouble(txtAltura.Text);
                player.Idade = Convert.ToInt32(txtIdade.Text);
                player.NumeroDaCamisa = Convert.ToInt32(txtNumero.Text);
                player.Time = txtTime.Text;
                vetorJogador[i] = player;

                MessageBox.Show("Jogador Salvo.");

                txtNome.Text = "";
                txtPeso.Text = "";
                txtAltura.Text = "";
                txtIdade.Text = "";
                txtNumero.Text = "";
                txtTime.Text = "";
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar os dados.");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {      

            for (int j = 0; j < 3; j++)
            {
                if (vetorJogador[j].Nome.Equals(btnPesquisar.Text))
                {
                    txtNome.Text = vetorJogador[j].Nome;
                    txtPeso.Text = vetorJogador[j].Peso.ToString();
                    txtAltura.Text = vetorJogador[j].Altura.ToString();
                    txtIdade.Text = vetorJogador[j].Idade.ToString();
                    txtNumero.Text = vetorJogador[j].NumeroDaCamisa.ToString();
                    txtTime.Text = vetorJogador[j].Time.ToString();

                    j = 2;
                    btnPesquisar.Text = "";
                }
                else
                {
                    if (j == 2)
                    {
                        MessageBox.Show("Jogador não encontrado!");
                        btnPesquisar.Text = "";
                    }
                }
            }
        }
    }
}
