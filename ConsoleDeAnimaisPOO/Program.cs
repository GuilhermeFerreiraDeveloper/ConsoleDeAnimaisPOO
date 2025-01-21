using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeAnimaisPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal primeiroAnimal = new Animal();
            Animal segundoAnimal = new Animal();
            Animal terceiroAnimal = new Animal();
            Animal quartoAnimal = new Animal();
            Animal quintoAnimal = new Animal();

            int quantidadeGato = 0, quantidadeCachorro = 0, quantidadePeixe = 0;

            Console.Write("Controle de Animais \nInforme o nome do primeiro animal: ");
            primeiroAnimal.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal [Cachorro - Gato - Peixe]: ");
            primeiroAnimal.Tipo= Console.ReadLine();
            if (primeiroAnimal.Tipo == "Cachorro") quantidadeCachorro++;
            if (primeiroAnimal.Tipo == "Gato") quantidadeGato++;
            if (primeiroAnimal.Tipo == "Peixe") quantidadePeixe++;

            Console.Write("Controle de Animais \nInforme o nome do segundo animal: ");
            segundoAnimal.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal [Cachorro - Gato - Peixe]: ");
            segundoAnimal.Tipo= Console.ReadLine();
            if (segundoAnimal.Tipo == "Cachorro") quantidadeCachorro++;
            if (segundoAnimal.Tipo == "Gato") quantidadeGato++;
            if (segundoAnimal.Tipo == "Peixe") quantidadePeixe++;
            
            Console.Write("Controle de Animais \nInforme o nome do terceiro animal: ");
            terceiroAnimal.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal [Cachorro - Gato - Peixe]: ");
            terceiroAnimal.Tipo= Console.ReadLine();
            if (terceiroAnimal.Tipo == "Cachorro") quantidadeCachorro++;
            if (terceiroAnimal.Tipo == "Gato") quantidadeGato++;
            if (terceiroAnimal.Tipo == "Peixe") quantidadePeixe++;

            Console.Write("Controle de Animais \nInforme o nome do quarto animal: ");
            quartoAnimal.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal [Cachorro - Gato - Peixe]: ");
            quartoAnimal.Tipo= Console.ReadLine();
            if (quartoAnimal.Tipo == "Cachorro") quantidadeCachorro++;
            if (quartoAnimal.Tipo == "Gato") quantidadeGato++;
            if (quartoAnimal.Tipo == "Peixe") quantidadePeixe++;

            Console.Write("Controle de Animais \nInforme o nome do quinto animal: ");
            quintoAnimal.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal [Cachorro - Gato - Peixe]: ");
            quintoAnimal.Tipo= Console.ReadLine();
            if (quintoAnimal.Tipo == "Cachorro") quantidadeCachorro++;
            if (quintoAnimal.Tipo == "Gato") quantidadeGato++;
            if (quintoAnimal.Tipo == "Peixe") quantidadePeixe++;


            Console.WriteLine("Cachorros: "+quantidadeCachorro +" Gatos: "+quantidadeGato +" Peixes: "+quantidadePeixe);

            Console.ReadKey();
        }
    }
}
