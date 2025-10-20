using System.Collections.Generic;
using System.Linq;
using ControleEstoque.Models;

namespace ControleEstoque.Data
{
    public class ProdutoRepositorio
    {
        private readonly List<Produto> produtos = new();
        private int contadorId = 1;

        public List<Produto> Listar() => produtos.Select(p => new Produto {
            Id = p.Id,
            Nome = p.Nome,
            Quantidade = p.Quantidade,
            Preco = p.Preco
        }).ToList();

        public void Adicionar(Produto produto)
        {
            produto.Id = contadorId++;
            produtos.Add(produto);
        }

        public void Atualizar(Produto produtoAtualizado)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == produtoAtualizado.Id);
            if (produto != null)
            {
                produto.Nome = produtoAtualizado.Nome;
                produto.Quantidade = produtoAtualizado.Quantidade;
                produto.Preco = produtoAtualizado.Preco;
            }
        }

        public void Remover(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }
    }
}
