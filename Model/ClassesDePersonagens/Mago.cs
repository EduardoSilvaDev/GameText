using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace caminho_do_heroi.ClassesDePersonagens
{
    public class Mago : Personagem
    {
        public Mago(string? nome)
        {
            this.Nome = nome;
            this.Pv = 10;
            this.Pm = 20;
        }
        public override string ToString(){return "Classe: " + this.GetType().Name + base.ToString();}
    }
}