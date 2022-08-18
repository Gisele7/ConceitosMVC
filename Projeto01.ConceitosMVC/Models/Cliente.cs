using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto01.ConceitosMVC.Models
{
    public class Cliente
    {


        [Required(ErrorMessage = "Por favor, preencha o CPF.")] //Campo obrigatório
        [Display(Name = "CPF do Cliente")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 dígitos.")] //Tamanho do campo
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o nome.")] //Campo obrigatório
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, preencha a data de nascimento.")] //Campo obrigatório
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required()]
        [Display(Name = "UF Residência")]
        public string UfResidencia { get; set; }
    }
}