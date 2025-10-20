using System;
using System.Windows.Forms;

namespace ControleEstoque.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dgvProdutos;
        private Label lblNome;
        private Label lblQuantidade;
        private Label lblPreco;
        private Button btnLimpar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.txtNome = new TextBox();
            this.txtQuantidade = new TextBox();
            this.txtPreco = new TextBox();
            this.btnSalvar = new Button();
            this.btnExcluir = new Button();
            this.btnLimpar = new Button();
            this.dgvProdutos = new DataGridView();
            this.lblNome = new Label();
            this.lblQuantidade = new Label();
            this.lblPreco = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();

            // Form style - minimalista
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "ControleEstoque";

            // Labels
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new System.Drawing.Point(20, 18);
            this.lblNome.AutoSize = true;

            this.lblQuantidade.Text = "Quantidade";
            this.lblQuantidade.Location = new System.Drawing.Point(20, 68);
            this.lblQuantidade.AutoSize = true;

            this.lblPreco.Text = "Preço (R$)";
            this.lblPreco.Location = new System.Drawing.Point(20, 118);
            this.lblPreco.AutoSize = true;

            // TextBoxes
            this.txtNome.Location = new System.Drawing.Point(120, 15);
            this.txtNome.Size = new System.Drawing.Size(240, 23);
            this.txtNome.BorderStyle = BorderStyle.FixedSingle;

            this.txtQuantidade.Location = new System.Drawing.Point(120, 65);
            this.txtQuantidade.Size = new System.Drawing.Size(120, 23);
            this.txtQuantidade.BorderStyle = BorderStyle.FixedSingle;

            this.txtPreco.Location = new System.Drawing.Point(120, 115);
            this.txtPreco.Size = new System.Drawing.Size(120, 23);
            this.txtPreco.BorderStyle = BorderStyle.FixedSingle;

            // Buttons
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(380, 15);
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.FlatStyle = FlatStyle.Flat;
            this.btnSalvar.Click += new EventHandler(this.btnSalvar_Click);

            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Location = new System.Drawing.Point(380, 55);
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.FlatStyle = FlatStyle.Flat;
            this.btnLimpar.Click += new EventHandler((s,e) => {
                txtNome.Clear(); txtQuantidade.Clear(); txtPreco.Clear(); txtNome.Focus();
            });

            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Location = new System.Drawing.Point(380, 95);
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.FlatStyle = FlatStyle.Flat;
            this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);

            // DataGridView
            this.dgvProdutos.Location = new System.Drawing.Point(20, 160);
            this.dgvProdutos.Size = new System.Drawing.Size(600, 240);
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.CellClick += new DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.BorderStyle = BorderStyle.FixedSingle;

            // Add controls
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvProdutos);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
