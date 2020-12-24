using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClienteMVC.Models
{
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Estado { get; set; }
    }
}
