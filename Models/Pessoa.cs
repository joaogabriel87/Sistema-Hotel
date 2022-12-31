using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_resrvar_de_um_hotel.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome  = sobrenome;

        }
        private string Nome {get; set;}
        private string Sobrenome {get; set;}
        private string NomeCompleto =>$"{Nome} {Sobrenome}".ToUpper();


    }
}