using caminho_do_heroi.Utils;
using Caminho_Do_Heroi.Controller.Historia;
using Caminho_Do_Heroi.Controller.InGame;
using Caminho_Do_Heroi.Model;
using Caminho_Do_Heroi.Model.ClassesHeroi;
using Caminho_Do_Heroi.Utils;
using Caminho_Do_Heroi.View;

namespace Caminho_Do_Heroi.Controller
{
    public class MenuPrincipalController
    {
        public void inicio(){
            while(true)
            {
                Console.Clear();
                int repete=1;
                
                switch(MenuOption()){
                    case 1:
                        Scene01.ShowText();
                        repete = 0;
                    break;
                    case 2:
                        repete = LoadProfile();
                        // dar um resumo da historia

                    break;
                    case 3:
                        Console.WriteLine(string.Join("\n",Menu.Instrucoes));
                        Input.Await();
                        Console.Clear();
                    break;
                    case 0:
                        Environment.Exit(0);
                    break;
                    default:
                        foreach(char c in "Iniciando Jogo . . .")
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }
                    break;
                }
                if(repete==0)break;
            }
        }
        private int MenuOption()
        {
            int option = -1;
            while(option < 0 || option > Menu.Principal.Count())
            {
                foreach(string texto in Menu.Principal)Console.WriteLine(texto);
                option = Input.ReadInt();
                if((option < 0 || option > Menu.Principal.Count()))Console.WriteLine(Cores.Red("Opção Invpalida!"));
                Console.Clear();
            }
            return option;
        }
        public int LoadProfile()
        {
            string[] files = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(),"Data"));
            int option = -1;
            do{
                ListProfiles(files);
                
                option = Input.ReadInt();
                
                if(option < 0 || option > files.Count()){
                    Console.Write(Cores.Red("Opção Inválida!"));
                    Input.Await();
                }
                Console.Clear();

            }while(option<0||option>files.Count());
            if(option==0)return 1;
            
            string[] file = File.ReadAllLines((@"Data\"+files[option-1]+".txt"));
            Heroi hero = ReadDatasHeroInFile(file);
            Game.hero = hero;
            return 0;
            // string[] linhas = File.ReadAllLines(@"Data\"+files[option-1]+".txt");
            
            // Console.WriteLine("Ola " + files[1]);
        }
        private void ListProfiles(string[] files){
            // Lista o nome de todos os arquivos
            for(int i=0;i<files.Count();i++){
                files[i] = Path.GetFileName(files[i]);
                files[i] = files[i].Replace(".txt","");
                Console.WriteLine((i+1) + " - " +files[i]);
            }
            Console.WriteLine("0 - Voltar");
        }
        public (string,int) heroi(){
            
            return ("nome",1);
        }
        
        private Heroi ReadDatasHeroInFile(string[] files){
            // retorna uma string[] com apenas os dados do heroi que estao armazenados no arquivo    
            // string[] files = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(),@"Data\"+nome+".txt"));
            for(int i=0;i<files.Count();i++){
                string until = "";
                foreach(char text in files[i].ToArray())
                {
                    until += text;
                    if(text==' ')break;
                }
                files[i] = files[i].Replace(until,"");
            }
            
            return LoadDatasHero(
                ClassInNumeral(files[0]),   // Classe
                files[1].ToString(),        // Nome
                Convert.ToInt32(files[2]),  // Pv
                Convert.ToInt32(files[3]),  // Pm
                Convert.ToInt32(files[4])   // Level
            );
        }
        private int ClassInNumeral(string? nome){
            if(nome == "Gerreiro")return 1;
            if(nome == "Mago")return 2;
            if(nome == "Arqueiro")return 3;
            else return 0;
        }
        public Heroi LoadDatasHero(int classe,string nome,int pv,int pm, int lvl){
            if(classe == 1)return new Guerreiro(nome,pv,pm,lvl);
            if(classe == 1)return new Mago(nome,pv,pm,lvl);
            if(classe == 1)return new Arqueiro(nome,pv,pm,lvl);
            return new Heroi(nome,pv,pm,lvl);
        }
    }
}