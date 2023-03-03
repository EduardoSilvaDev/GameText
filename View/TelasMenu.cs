
namespace caminho_do_heroi.Objetos
{
    static public class TelasMenu
    {
        static public void MenuPrincipal(){
            string[] f = {
                "\t\tCaminho do Herói\n\n",
                "\t1 - Novo jogo\n",
                "\t2 - Carregar\n",
                "\t3 - Instruções\n",
                "\t0 - Sair\n",
                "\t> "
            };
            int escolha = -1;
            while(true){
                Console.Clear();
                foreach(string F in f)Console.Write(F);
                try{
                    escolha = Convert.ToInt32(Console.ReadLine());
                }catch(Exception){continue;}
                if(escolha >=0 && escolha <= f.Length-1){
                    Console.Clear();
                    break;
                }
                Console.ReadLine();
            }
            switch(escolha){
                case 1:
                    Console.WriteLine("novo jogo");
                break;
                case 2:
                    Console.WriteLine("Carrega");
                break;
                case 3:
                    Console.WriteLine("instrucoes");
                break;
                case 0:
                    Console.WriteLine("saindo");
                    Console.ReadLine();
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Escolha uma opcao valida");
                break;
            }
        }

        // private void CreateChar(){
        //     Tuple<string,int> recebe = MenuCriacaoPersonagem();
        //     Personagem? personagem = CriarPersonagem(recebe.Item1,recebe.Item2);
            
        //     // string arquivo = @"C:\Users\Eduardo\Desktop\Code\C\caminho_do_heroi\dados\"+personagem.Nome+personagem.GetType().Name +".txt";
        //     // string caminho = @"dados\"+personagem.Nome+personagem.GetType().Name +".txt";
        //     string caminho = Path.Combine(Directory.GetCurrentDirectory(),@"dados\"+personagem.Nome+".txt");
        //     using(StreamWriter sw = File.CreateText(caminho)){
        //         sw.WriteLine(personagem.GetType().Name);
        //         sw.WriteLine(personagem.Nome);
        //         sw.WriteLine(personagem.Pv);
        //         sw.WriteLine(personagem.Pm);
        //     }


        //     Tuple<string,int> MenuCriacaoPersonagem(){
        //         string? nome = "";
        //         int classe = 0;
        //         while(true){
        //             Console.Clear();
        //             while(string.IsNullOrEmpty(nome)){
        //                 Console.WriteLine("\tOla! Bem Vindo ao Caminho do Herói!\n");
        //                 Console.Write("Por favor, digite seu nome: ");
        //                 nome = Console.ReadLine();
        //                 Console.Clear();
        //             }
        //             while(classe<1||classe>3){
        //                 Console.WriteLine("\tAgora escolha sua Classe: \n");
        //                 Console.WriteLine("1 - Guerreiro");
        //                 Console.WriteLine("2 - Mago");
        //                 Console.WriteLine("3 - Arqueiro");
        //                 Console.Write("> ");
        //                 try{
        //                     classe = Convert.ToInt32(Console.ReadLine());
        //                 }
        //                 catch(Exception){}
        //                 Console.Clear();
        //             }
        //             break;
        //         }
        //         return Tuple.Create(nome,classe);
        //     }
        // }
        
        static public void InGameMenu(){
            // dentro do jogo
        }
        static public void Navigation(string[] lugares){
            // interacoes com o ambiente local
        }
    }
}