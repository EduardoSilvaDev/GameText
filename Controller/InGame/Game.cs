using Caminho_Do_Heroi.Model;
using Caminho_Do_Heroi.Utils;

namespace Caminho_Do_Heroi.Controller.InGame
{
    static public class Game
    {
        static public Heroi? hero;
        static public void Inicio()
        {
            if(hero != null){
                Console.WriteLine($"\n\nOla {hero.Nome}");
                Input.Await();
                Console.WriteLine(hero.ToString());
            }
        }
        
    }
}