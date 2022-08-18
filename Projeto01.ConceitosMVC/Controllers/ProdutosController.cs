using Projeto01.ConceitosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto01.ConceitosMVC.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos

        public ActionResult Index()
        {
            return View();
        }
        //Por padrão todo action é executado pelo método get
        //Gera o formulário
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        //Para receber os dados do form Cadastro.cshtml
        [HttpPost]
        public ActionResult Cadastro(FormCollection form)
        {
            //obtendo os dados do formulário
            int codigo = int.Parse(form["codigoTextBox"]);
            string descricao = form["descricaoTextBox"];
            double preco = double.Parse(form["precoTextBox"]);

            //criando um projeto da classe produto com os dados do formulário

            Produto produto = new Produto()
            {
                Codigo = codigo,
                Descricao = descricao,
                Preco = preco
            };
            return View("Exibir", produto);
        }
        //Esse action quando executado, ele irá gerar uma view, ele vai ter uma página e essa página vai receber o produto
        public ActionResult Exibir(Produto produto)
        {
            return View(produto);
        }
        [HttpGet]
        public ActionResult CadastroModel()
        {
            return View();
        }
        //Usando views fortementes tipadas - strongly typed views
        [HttpPost]
        public ActionResult CadastroModel(Produto produto)
        {
            return View("ExibirModel", produto);
        }
        public ActionResult ExibirModel(Produto produto)
        {
            return View(produto);
        }

    }
}