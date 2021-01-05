using System.Collections.Generic;
using Models;
using Views;

namespace Controllers
{
    public class ProdutosController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();
        
        public void MostrarProduto()
        {
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos); 
        }

    }
}