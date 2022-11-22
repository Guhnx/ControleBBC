using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaniaTrabalho
{
    class Pessoa
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string celular { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public Pessoa(string id, string nome, string cpf, string estado,
                  string cidade,string celular, string usuario, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.estado = estado;
            this.cidade = cidade;
            this.celular = celular;
            this.usuario = usuario;
            this.senha = senha;
        }//fecha o construtor
    }
}
