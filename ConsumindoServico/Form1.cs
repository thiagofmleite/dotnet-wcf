using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ClienteReference;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente cliente = new Cliente
                {
                    Nome = nome,
                    CPF = cpf
                };

                servico.Add(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception)
            {
                
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente cliente = servico.Buscar(nome);

                txtCPF.Text = cliente.CPF;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
