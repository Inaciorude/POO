using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;

            p1.Apresentar();
        }
    }
    
}