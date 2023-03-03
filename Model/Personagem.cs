namespace caminho_do_heroi
{
    public class Personagem
    {
        private string? nome;
        private int pv;     //pontos de vida
        private int pm;     //pontos de magia
        private int level;

        public Personagem()
        {
            Level = 1;
        }

        public string? Nome { get => nome; set => nome = value; }
        public int Pv { get => pv; set => pv = value; }
        public int Pm { get => pm; set => pm = value; }
        public int Level { get => level; set => level = value; }

        public override string ToString()
        {
            return  "\nNome: " + Nome +
                    "\nPV: " + Pv +
                    "\nPM: " + Pm;
        }
    }
}