using System;
using System.Collections.Generic;
using Models;

namespace Views
{
    public class ProdutoView
    {
        
        public void ListarTodos(List<Produto> produtos)
        {
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preço : {item.Preco}");
            }
        }

    }
}