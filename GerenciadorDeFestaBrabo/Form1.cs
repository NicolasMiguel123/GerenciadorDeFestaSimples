using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFestaBrabo
{
    public partial class Form1 : Form
    {
        // Variaveis globais:
        // List<string> lista = new List<string>();
        public Form1()
        {
            InitializeComponent();
            // Carregar os dados das listas pro listbox:
            // libConvidados.DataSource = lista;
        }

        private void pibLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo esta vazio
            if(txbNomeconsulta.Text == "")
            {
                MessageBox.Show("O campo de nome não pode estar vazio!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verificar se a lista contem o nome informado 
                if(libConvidados.Items.Contains(txbNomeconsulta.Text)) 
                {
                    // Trocar a imagem do pibResultado pro "V"
                    pibResultado.Image = Properties.Resources.ok;
                    // Mudar o label;
                    lblResultado.Text = "Pode entrar!";
                    lblResultado.ForeColor = Color.FromArgb(22, 224, 46);
                    // Remover o convidado da lista:
                    libConvidados.Items.Remove(txbNomeconsulta.Text);
                    // Limpar o texbox
                    txbCadastro.Clear();
                }
                else
                {
                    pibResultado.Image = Properties.Resources.error;
                    lblResultado.Text = "Não pode entrar!";
                    lblResultado .ForeColor = Color.Red;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verificar se não esta vazio:
            if(txbCadastro.Text == "")
            {
                MessageBox.Show("O campo de nome não pode estar vazio!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Adicionar o nome na lista:
                // lista.Add(txbCadastro.Text);
                // Atualizar o listBox:
                libConvidados.Items.Add(txbCadastro.Text);
                // Apagar o textbox:
                txbCadastro.Text = ""; 
                txbCadastro.Clear(); // Mesma coisa que a linha de cima
            }
        }
    }
}
