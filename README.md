# Controle Simples de Estoque


Protótipo de controle de estoque desenvolvido em C# (.NET 8, WinForms), com interface intuitiva e minimalista. O projeto inclui funcionalidades básicas de cadastro, edição e exclusão de produtos, com validações automáticas para reduzir erros de entrada de dados.

# 📝 Funcionalidades 

- Adicionar produtos: nome, quantidade e preço.

- Editar produtos: clique no item da tabela para atualizar os dados.

- Excluir produtos: confirmação antes da exclusão.

 Validações automáticas:

- Campos obrigatórios

- Quantidade e preço não podem ser negativos

- Alertas de entrada inválida

- Tabela de produtos dinâmica: exibe produtos cadastrados com visual minimalista.

- Limpeza de campos: botão “Limpar” para resetar os campos.

## 💡 Observações ##

O sistema funciona em memória (não possui banco de dados).

Pode ser expandido facilmente para incluir:

Persistência com SQLite/EF Core

Relatórios de estoque

Filtros por quantidade/preço

Exportação para CSV ou Excel

