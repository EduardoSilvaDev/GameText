namespace caminho_do_heroi.ClassesDePersonagens
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string? nome)
        {
            this.Nome = nome;
            this.Pv = 20;
            this.Pm = 10;
        }
        public override string ToString(){return "Classe: " + this.GetType().Name + base.ToString();}
    }
}