using Negocio.Models;
using Negocio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreinamentoEstoque.Controllers
{
    public class ProdutoController: Controller
    {
        [HttpGet]
        public ActionResult BuscaProduto()
        {
            //ProdutoService service = new ProdutoService();
            //Produto produto = new Produto();

            //produto = service.FindById(id);

            Produto produto = new Produto();

            produto.Descricao = "Caixa de Fósforo";
            produto.IdProduto = 1;
            produto.IdCategoria = 1;

            return View(produto);
        }

        [HttpGet]
        public ActionResult ListarProdutos()
        {
            ProdutoService service = new ProdutoService();
            List<Produto> produtos = new List<Produto>();

            produtos = service.ListAll().ToList();
            return View(produtos);
        }

        [HttpDelete]
        public ActionResult ApagarProduto(Produto produto)
        {
            ProdutoService service = new ProdutoService();
            service.Delete(produto);

            return View(produto.Descricao);
        }
    }
}