using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using caminho_do_heroi.View.Menu;

namespace caminho_do_heroi.Controller
{
    public class MenuController
    {
        public void MenuPrincipal(){
            switch(Inicial.DisplayMenu()){
                case 1:
                    Inicial.NewGame();
                break;
                case 2:
                    Console.WriteLine("Carrega dados");
                break;
                case 3:
                    Console.WriteLine("Instrucoes");
                break;
                default:
                    Console.Clear();
                    Environment.Exit(0);
                break;
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}