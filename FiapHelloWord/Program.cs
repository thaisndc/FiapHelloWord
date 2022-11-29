using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapHelloWord.Modelo;

namespace FiapHelloWord // Responsável por declarar um escopo ou bloco que contém um conjunto de classes relacionadas.
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloModelo modelo= new HelloModelo();

            Console.WriteLine("Fiap - Olá C#");

            Console.Read(); // Para manter a janela aberta.
        }
    }
}
