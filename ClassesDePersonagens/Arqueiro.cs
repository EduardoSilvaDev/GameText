using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace caminho_do_heroi.ClassesDePersonagens
{
    public class Arqueiro : Personagem
    {
        public Arqueiro(string? nome)
        {
            this.Nome = nome;
            this.Pv = 15;
            this.Pm = 15;
        }
        public override string ToString(){return "Classe: " + this.GetType().Name + base.ToString();}
    }
}