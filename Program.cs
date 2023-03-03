using caminho_do_heroi.Controller;
using caminho_do_heroi.Objetos;

namespace Caminho_do_Heroi
{
    class Program
    {
        static public void Main(String[] args)
        {
            while(true){
                MenuController menu = new MenuController();
                menu.MenuPrincipal();
                
                // Console.ReadLine();
            }
        }
    }
}

