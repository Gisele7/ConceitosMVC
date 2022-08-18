using Projeto01.ConceitosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto01.ConceitosMVC.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }
        //Strongly typed views
        [HttpGet]
        public ActionResult Cadastro()
        {

            ViewBag.ListaEstados = new SelectList(new List<string>() { "RS", "PA", "SP", "RJ", "SC" });
            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Cliente cliente)
        {


            //temos que retornar o cadastro na verificação, se não, dará erro
            //verifica se os dados estão válidos, caso não, ele retorna o usuário para o formulário.
            if (!ModelState.IsValid)
            {
                return Cadastro();
            }
            //Não estamos direcionando para a View Exibir, nós só estamos mostrando o CONTEÚDO da View Exibir.
            return View("Exibir", cliente);
        }

        public ActionResult Exibir(Cliente cliente)
        {
            return View(cliente);
        }
        public ActionResult Listar01()
        {
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente() {
                    Cpf = "12345678901", Nome = "Jose 1", DataNascimento = DateTime.Now, UfResidencia = "RJ" },
                new Cliente() {
                    Cpf = "78945612302", Nome = "Maria 1", DataNascimento = DateTime.Now, UfResidencia = "SC" },
                new Cliente() {
                    Cpf = "65474132598", Nome = "João 1", DataNascimento = DateTime.Now, UfResidencia = "SP" }
            };
            //Mostrar clientes da "view" Listar01 na view LISTAR
            return View("Listar", clientes);
        }

        public ActionResult Listar02()
        {
            HashSet<Cliente> clientes = new HashSet<Cliente>()
            {
                new Cliente() {
                    Cpf = "12345678901", Nome = "Jose 2", DataNascimento = DateTime.Now, UfResidencia = "RJ" },
                new Cliente() {
                    Cpf = "78945612302", Nome = "Maria 2", DataNascimento = DateTime.Now, UfResidencia = "SC" },
                new Cliente() {
                    Cpf = "65474132598", Nome = "João 2", DataNascimento = DateTime.Now, UfResidencia = "SP" }
            };
            //Mostrar clientes da "view" Listar02 na view LISTAR
            return View("Listar", clientes);
        }

    }
}