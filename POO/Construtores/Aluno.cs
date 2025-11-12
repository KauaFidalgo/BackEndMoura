
namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public int Idade;

        public int Nota;

        public Aluno(string n, int i, int nota)
        {
            Nome = n;
            Idade = i;
            Nota = nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Nota: {Nota}");
        }
    }
}