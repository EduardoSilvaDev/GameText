namespace caminho_do_heroi.Utils
{
    static public class Cores
    {
        static public string Black(String STRING){
            return $"\x1b[30m{STRING}\x1b[0m";
        }
        static public string Red(String STRING){
            return $"\x1b[31m{STRING}\x1b[0m";
        }
        static public string Green(String STRING){
            return $"\x1b[32m{STRING}\x1b[0m";
        }
        static public string Yellow(String STRING){
            return $"\x1b[33m{STRING}\x1b[0m";
        }
        static public string Blue(String STRING){
            return $"\x1b[34m{STRING}\x1b[0m";
        }
        static public string Purple(String STRING){
            return $"\x1b[35m{STRING}\x1b[0m";
        }
        static public string LightBlue(String STRING){
            return $"\x1b[36m{STRING}\x1b[0m";
        }
        static public string White(String STRING){
            return $"\x1b[37m{STRING}\x1b[0m";
        }   
    }
}