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
            // serindo de parametro para criar o novo personagem

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
        static void LoadGame(){
            // talvez precise receber algum para parametro para retornar um objeto
        }
        static void DisplayInstructions(){
            // implementar as instrucoes
        }
    }
}