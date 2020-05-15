using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TP2_Fundamentos
{
    class Pessoa
    { 

        public string nome { get; set; }
        public string sobrenome { get; set; }
        public DateTime aniversario { get; set; }


        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome, DateTime aniversario)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.aniversario = aniversario;
        }

    }


    
}
