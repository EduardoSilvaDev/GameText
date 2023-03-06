
using Caminho_Do_Heroi.Model;
using Caminho_Do_Heroi.Model.ClassesHeroi;
using Caminho_Do_Heroi.Utils;
using Caminho_Do_Heroi.View;

namespace Caminho_Do_Heroi.Controller
{
    public class MakeHero
    {
        private Heroi Hero;
        public Heroi GetHero(){return Hero;}

        public MakeHero(){
            string? nome = "";
            int classe = -1;
            while(string.IsNullOrEmpty(nome)){
                Console.Write("Digite seu nome: ");
                nome = Input.Readline();
            }
            while(classe < 0 || classe > 3){
                Console.Write(string.Join("\n",Menu.Classes));
                classe = Input.ReadInt();
            }

            Hero = CreateTypeHero(nome,classe);
            SalveDatas(Hero);
        }
        
        private void SalveDatas(Heroi heroi){
            string caminho = Path.Combine(Directory.GetCurrentDirectory(),@"Data\"+heroi.Nome+".txt");
            using(StreamWriter sw = File.CreateText(caminho)){
                sw.WriteLine("Classe:" + heroi.GetType().Name);
                sw.WriteLine("Nome: " + heroi.Nome);
                sw.WriteLine("PV: " + heroi.Pv);
                sw.WriteLine("PM: " + heroi.Pm);
                sw.WriteLine("Level: " + heroi.Level);
            }
        }
        public Heroi CreateTypeHero(string? nome,int classe){
            if(classe == 1)return new Guerreiro(nome);
            if(classe == 1)return new Mago(nome);
            if(classe == 1)return new Arqueiro(nome);
            return new Heroi(nome);
        }
    }
}