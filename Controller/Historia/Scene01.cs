using Caminho_Do_Heroi.View.Historia;
namespace Caminho_Do_Heroi.Controller.Historia
{
    static public class Scene01
    {
        static public void ShowText(){
            // string

            // string[] texto = File.ReadAllLines(@"View\Historia\Scene01\01_Abertura.txt");
            // string content = File.ReadAllText(@"View\Historia\Scene01\01_Abertura.txt");
            // string[] texto = content.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string text in History_Scene01.Abertura.ToArray())
                foreach(char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
        }        
    }
}