public class Pessoa
{
    public Guid id;
    public string nome;
    public int idade;

    public Pessoa(string nome, int idade)
    {
        id = Guid.NewGuid();
        this.nome = nome;

        if (idade < 18)
        {
            Console.WriteLine("Idade minima é 18 anos!");
        }
        else
        {
            this.idade = idade;
        }
    }
    public void MudarNome(string nome)
    {
        this.nome = nome;
    }
}