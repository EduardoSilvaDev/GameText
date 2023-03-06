using caminho_do_heroi.Controller;

namespace caminho_do_heroi.View.Menu
{
    static public class Inicial
    {
        static public int DisplayMenu(){
            int escolha=-1;
            string[] texts = {
                "\t\tCaminho do Herói\n",
                "\n\t1 - Novo Jogo",
                "\n\t2 - Carregar Jogo",
                "\n\t3 - Instruções",
                "\n\t0 - Sair",
                "\n\t> "
            };
            do{
                Console.Clear();
                foreach(string txt in texts)Console.Write(txt);
                try{
                    escolha = Convert.ToInt32(Console.ReadLine());
                }catch(Exception){continue;};
            }while(escolha<0||escolha>texts.Length-1);
            return escolha;
        }
        static public void NewGame(){
            // duas funcoes para retornar os valores 
            // inserindo-os de parametro para criar o novo personagem

            CreateChar._createChar(RetornaNome(),RetornaClasse());
            
            string RetornaNome(){
                string? nome = "";
                do{
                    Console.Clear();
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();

                    if(string.IsNullOrEmpty(nome))continue;

                    if(CreateChar.ExistsNameChar(nome)){
                        Console.WriteLine("Já existe este nome, por favor digite outro nome");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else break;
                }while(true);
                return nome;
            }
            int RetornaClasse(){
                int classe = 0;
                do{
                    while(classe<1||classe>3){
                        Console.Clear();
                        Console.WriteLine("\n\tEscolha Sua Classe");
                        Console.WriteLine("1 - Guerreiro");
                        Console.WriteLine("2 - Mago");
                        Console.WriteLine("3 - Arqueiro");
                        try{
                            classe = Convert.ToInt32(Console.ReadLine());
                        }catch(Exception){}
                    }
                    if(classe>=1&&classe<=3)break;
                }while(true);
                return classe;
            }
        }
        static public void LoadGame(){
            // talvez precise receber algum para parametro para retornar um objeto
            Console.Clear();
            // string caminho = Path.Combine(Directory.GetCurrentDirectory(),"dados");
            string[] files = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(),"dados"));
            for(int i=0;i<files.Count();i++){
                files[i] = Path.GetFileName(files[i]);
                files[i] = files[i].Replace(".txt","");
            }
            int options=-1;
            do{
                Console.WriteLine("\t\tJogos Salvos\n");
                for(int i=0;i<files.Count();i++)Console.WriteLine(i+1 + " - " + files[i]);
                Console.WriteLine("0 - Voltar");
                Console.Write("> ");
                try{
                    options = Convert.ToInt32(Console.ReadLine());
                }catch(Exception){options=-1;};
                if(options<0||options>files.Count())options=-1;
                Console.Clear();
            }while(options<0||options>files.Count());
            if(options!=0)Console.WriteLine($"Voce Escolheu: {files[options-1]}");
        }
        static void DisplayInstructions(){
            // implementar as instrucoes
        }
    }
}