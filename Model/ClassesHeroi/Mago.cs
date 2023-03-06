using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caminho_Do_Heroi.Model.ClassesHeroi
{
    public class Mago : Heroi
    {
        public Mago(string? nome)
        {
            this.Nome = nome;
            this.Pv = 10;
            this.Pm = 20;
        }
        public Mago(String? nome,int pv,int pm,int lvl){
            this.Nome = nome;
            this.Pv = pv;
            this.Pm = pm;
            this.Level = lvl;
        }
        public override string ToString(){return "Classe: " + this.GetType().Name + base.ToString();}
    }
}