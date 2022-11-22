using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaniaTrabalho
{
    internal class Livro
    {

       public string nome { get; set; }
        public string editora { get; set; }
        public string autor { get; set; }
        public int codigo { get; set; }
        public int volume { get; set; }
        public string ano { get; set; }

        public Livro(string nome, string editora, string autor, int codigo, int volume, string ano)
        {
            this.nome = nome;
            this.editora = editora;
            this.autor = autor;
            this.codigo = codigo;
            this.volume = volume;
            this.ano = ano;
        }
    }
}
