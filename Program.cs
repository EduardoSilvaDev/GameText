using System;
using caminho_do_heroi;
using caminho_do_heroi.ClassesDePersonagens;

namespace Caminho_do_Heroi
{
    class Program
    {
        static public void Main(String[] args)
        {
            Tuple<string,int> recebe = MenuCriacaoPersonagem();
            Personagem? personagem = CriarPersonagem(recebe.Item1,recebe.Item2);
            Console.WriteLine(personagem.ToString());
            Console.ReadLine();

            string arquivo = @"C:\Users\Eduardo\Desktop\Code\C\caminho_do_heroi\dados\"+personagem.Nome+personagem.GetType().Name +".txt";
            using(StreamWriter sw = File.CreateText(arquivo)){
                sw.WriteLine(personagem.GetType().Name);
                sw.WriteLine(personagem.Nome);
                sw.WriteLine(personagem.Pv);
                sw.WriteLine(personagem.Pm);
            }
        }
        static Personagem CriarPersonagem(string? nome,int tipo){
            if(tipo == 1)return new Guerreiro(nome);
            if(tipo == 2)return new Mago(nome);
            if(tipo == 3)return new Arqueiro(nome);
            else return new Guerreiro(nome);
        }
        static Tuple<string,int> MenuCriacaoPersonagem(){
            string? nome = "";
            int classe = 0;
            while(true){
                Console.Clear();
                while(string.IsNullOrEmpty(nome)){
                    Console.WriteLine("\tOla! Bem Vindo ao Caminho do Herói!\n");
                    Console.Write("Por favor, digite seu nome: ");
                    nome = Console.ReadLine();
                    Console.Clear();
                }
                while(classe<1||classe>3){
                    Console.WriteLine("\tAgora escolha sua Classe: \n");
                    Console.WriteLine("1 - Guerreiro");
                    Console.WriteLine("2 - Mago");
                    Console.WriteLine("3 - Arqueiro");
                    Console.Write("> ");
                    try{
                        classe = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception){}
                    Console.Clear();
                }
                break;
            }
            return Tuple.Create(nome,classe);
        }
        static int Decisoes(string[] opcoes){
            int escolha=-1;
            while(escolha<0||escolha>opcoes.Length){
                Console.WriteLine(String.Join("\n",opcoes));
                Console.Write("> ");
                try{escolha = Convert.ToInt32(Console.ReadLine());}catch(Exception){}
                Console.Clear();
            }
            return escolha;
        }

    }
}

