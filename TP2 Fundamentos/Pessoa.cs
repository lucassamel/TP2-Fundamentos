using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TP2_Fundamentos
{
    class Pessoa
    { 

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Aniversario { get; set; }


        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome, DateTime aniversario)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Aniversario = aniversario;
        }

    }


    
}
