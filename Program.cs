using Caminho_Do_Heroi.Controller;
using Caminho_Do_Heroi.Controller.InGame;
using Caminho_Do_Heroi.Utils;

namespace Caminho_Do_Heroi
{
    internal class Program
    {
        static void Main(String[] args){
            MenuPrincipalController menu = new MenuPrincipalController();
            while(true){
                menu.inicio();
                Game.Inicio();
                Input.Await();
            }
        }
    }
}