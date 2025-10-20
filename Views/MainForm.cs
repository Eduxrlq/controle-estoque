using System;
using System.Windows.Forms;
using ControleEstoque.Data;
using ControleEstoque.Models;

namespace ControleEstoque.Views
{
    public partial class MainForm : Form
    {
        private readonly ProdutoRepositorio repositorio = new();
        private int idSelecionado = -1;

        public MainForm()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = repositorio.Listar();
            dgvProdutos.Columns["Id"].Visible = false;
            dgvProdutos.AutoResizeColumns();
        }

        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var produto = new Produto
            {
                Id = idSelecionado,
                Nome = txtNome.Text.Trim(),
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtPreco.Text)
            };

            if (idSelecionado == -1)
                repositorio.Adicionar(produto);
            else
                repositorio.Atualizar(produto);

            LimparCampos();
            AtualizarGrid();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do produto é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida. Informe um número inteiro >= 0.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido. Informe um número maior ou igual a zero (ex: 12.50).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return false;
            }

            return true;
        }

        private void dgvProdutos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProdutos.Rows[e.RowIndex].DataBoundItem is not Produto produto) return;

            idSelecionado = produto.Id;
            txtNome.Text = produto.Nome;
            txtQuantidade.Text = produto.Quantidade.ToString();
            txtPreco.Text = produto.Preco.ToString("F2");
        }

        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                repositorio.Remover(idSelecionado);
                LimparCampos();
                AtualizarGrid();
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            idSelecionado = -1;
            txtNome.Focus();
        }
    }
}
