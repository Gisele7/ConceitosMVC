using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.ConceitosMVC.Models
{
    //Modelo para a aplicação
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao{ get; set; }
        public double Preco{ get; set; }

        
        public override string ToString()
        {
            return $"Código: {Codigo}, Descrição: {Descricao}, Preco: {Preco:c}";
        }
    }
}