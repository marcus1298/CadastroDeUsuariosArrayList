using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList usuarios = new ArrayList();
        ArrayList senhas = new ArrayList();

        usuarios.Add("Felipe");
        senhas.Add("3250");
        Console.WriteLine("Cadastre o primeiro usuário e sua senha");
        usuarios.Add(Console.ReadLine());
        senhas.Add(Console.ReadLine());
        Console.WriteLine("Cadastre o segundo usuário e sua senha");
        usuarios.Add(Console.ReadLine());
        senhas.Add(Console.ReadLine());

        int tentativas = 0;
        while (tentativas < 3)
        {
            Console.WriteLine("Digite seu nome de usuário");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();
     
            if (usuarios.Contains(nome) && senhas[usuarios.IndexOf(nome)].Equals(senha))
            {
                Console.WriteLine("Usuário autorizado");
                break;
            }
            else
            {
                Console.WriteLine("Nome de usuário ou senha incorretos");
                tentativas++;
            }
        }
        if (tentativas == 3)
        {
            Console.WriteLine("Você excedeu o número máximo de tentativas");
        }
    }
}