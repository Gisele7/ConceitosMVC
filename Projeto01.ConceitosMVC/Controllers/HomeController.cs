using Projeto01.ConceitosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto01.ConceitosMVC.Controllers
{
    public class HomeController : Controller
    {
        public string MostrarTexto()
        {
            return "<h1>Conceitos do MVC</h1>";
        }

        public Produto MostrarProduto()
        {
            Produto produto = new Produto()
            {
                Codigo = 120,
                Descricao = "Armário",
                Preco = 1200.0
            };
            return produto;
        }
        public string MostrarValor(int id)
        {
            return $"Valor informado: {id}";
        }

        // GET: Home
        //Dentro do controle os métodos não são chamados de métodos, são chamados de Action 

        public ActionResult Index()
        {
            return View();
        }

    }
}