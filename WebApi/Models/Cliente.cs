using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Cliente
    {
        public String Nome { get; set; }
        public String DataNascimento { get; set; }
        public String CPF { get; set; }
        public String Email { get; set; }

        public Cliente(string nome, string data, string cpf, string email)
        {
            this.Nome = nome;
            this.DataNascimento = data;
            this.CPF = cpf;
            this.Email = email;

        }
    }
}