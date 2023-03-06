using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caminho_Do_Heroi.Model.ClassesHeroi
{
    public class Guerreiro : Heroi
    {
        public Guerreiro(string? nome)
        {
            this.Nome = nome;
            this.Pv = 20;
            this.Pm = 10;
        }
        public Guerreiro(String? nome,int pv,int pm,int lvl){
            this.Nome = nome;
            this.Pv = pv;
            this.Pm = pm;
            this.Level = lvl;
        }
        public override string ToString(){return "Classe: " + this.GetType().Name + base.ToString();}
    }
}