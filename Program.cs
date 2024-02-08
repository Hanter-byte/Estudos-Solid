using System.Security.Cryptography;

class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Pedro",22);
        Console.WriteLine("O nome é: " + pessoa.nome);
        pessoa.MudarNome("Luiz");
        Console.WriteLine("O novo nome é: " + pessoa.nome);
        Console.WriteLine(pessoa.id);
    }
}