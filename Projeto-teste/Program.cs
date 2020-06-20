using System;
using System.Collections.Generic;

namespace Projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Tenha esperança, vai passar!");
            Console.WriteLine("Eu quero sair");
            Console.ReadLine();

            //Criação e instanciação de lista
            List<string> estados = new List<string>();
            estados.Add("Amazonas");
            estados.Insert(0, "Acre");
            estados.Insert(2, "Amapá");
            estados.Insert(1, "Alagoas");
            estados.Add("Bahia");
            estados.Add("Ceará");
            estados.Add("Espírito Santo");
            estados.Add("Goiás");
            estados.Add("Mato Grosso do Sul");
            estados.Add("Minas Gerais");
            estados.Add("Paraná");
            estados.Add("Rio de Janeiro");
            estados.Add("Rio Grande do Norte");
            estados.Add("Rio Grande do Sul");
            estados.Add("Santa Catarina");
            estados.Add("São Paulo");

            foreach(string obj in estados)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Quantidade de estados na lista: "+estados.Count);

            List<string> result = estados.FindAll(x => x[0] == 'R');
            Console.WriteLine("\nEstados brasileiros que começam com a letra R: ");
            foreach (string obj in result)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
