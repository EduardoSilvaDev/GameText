using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using caminho_do_heroi.ClassesDePersonagens;

namespace caminho_do_heroi.Controller
{
    static public class CreateChar
    {
        static public void _createChar(string nome,int classe){
            // Tuple<string,int> recebe = MenuCriacaoPersonagem();

            Personagem? personagem = CriarPersonagem(nome,classe);
            Personagem CriarPersonagem(string? nome,int tipo){
                if(tipo == 1)return new Guerreiro(nome);
                if(tipo == 2)return new Mago(nome);
                if(tipo == 3)return new Arqueiro(nome);
                else return new Guerreiro(nome);
            }

            string caminho = Path.Combine(Directory.GetCurrentDirectory(),@"dados\"+personagem.Nome+".txt");
            using(StreamWriter sw = File.CreateText(caminho)){
                sw.WriteLine("Classe: " + personagem.GetType().Name);
                sw.WriteLine("Nome: " + personagem.Nome);
                sw.WriteLine("PV: " + personagem.Pv);
                sw.WriteLine("PM: " + personagem.Pm);
            }
        }
        static public bool ExistsNameChar(string nome){
            string caminho = Path.Combine(Directory.GetCurrentDirectory(),"dados");
            string[] files = Directory.GetFiles(caminho);
            for(int i=0;i<files.Count();i++){
                files[i] = Path.GetFileName(files[i]);
                files[i] = files[i].Replace(".txt","");

                if(nome==files[i])return true;
                // Console.WriteLine(files[i]);
            }
            return false;
        }
        
    }
}