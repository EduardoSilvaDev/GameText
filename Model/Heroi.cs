namespace Caminho_Do_Heroi.Model
{
    public class Heroi
    {
        private string? nome;
        private int pv;     //pontos de vida
        private int pm;     //pontos de magia
        private int level;

        public Heroi()
        {
            Level = 1;
        }
        public Heroi(String? nome){
            this.Pv = 5;
            this.Pm = 5;
            Level = 1;
        }
        public Heroi(String? nome,int pv,int pm,int lvl){
            this.Nome = nome;
            this.Pv = pv;
            this.Pm = pm;
            this.level = lvl;
        }

        public string? Nome { get => nome; set => nome = value; }
        public int Pv { get => pv; set => pv = value; }
        public int Pm { get => pm; set => pm = value; }
        public int Level { get => level; set => level = value; }

        public override string ToString()
        {
            return  "\nNome: " + Nome +
                    "\nPV: " + Pv +
                    "\nPM: " + Pm + 
                    "\nLevel: " + Level;
        }
    }
}