using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using caminho_do_heroi.Utils;

namespace Caminho_Do_Heroi.Utils
{
    static public class Input
    {
        static public string? Readline(){
            Console.Write("> ");
            return Console.ReadLine();
        }
        static public int ReadInt(){
            int result = -1;
            // while(!int.TryParse(Readline(),out result)){
            //     Console.WriteLine("Apenas Numero");
            // }
            try{
                result = Convert.ToInt32(Readline());
            }catch(Exception){Console.Write(Cores.Red("Apenas Numero!"));Await();Console.Clear();};
            return result;
        }
        static public decimal ReadDec(){
            decimal result = -1;
            // while(!decimal.TryParse(Readline(),out result)){
            //     Console.WriteLine("Apenas Numero decimal");
            // }
            try{
                result = Convert.ToDecimal(Readline());
            }catch(Exception){Console.Write(Cores.Red("Apenas Numero Decimal"));Await();Console.Clear();};
            return result;
        }
        static public void Await(){
            Console.ReadLine();
        }
    }
}