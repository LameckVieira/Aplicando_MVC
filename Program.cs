using System;
using Controllers;

namespace Aplicando_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produtosController = new ProdutosController();
            produtosController.MostrarProduto();

        }
    }
}
