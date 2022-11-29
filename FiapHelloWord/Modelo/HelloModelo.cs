using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWord.Modelo
{
    public class HelloModelo
    {
        public string Mensagem = "Olá FiapOn";

        public string Mensagem3 { get; private set; }

        public HelloModelo()
       {
        Cliente m = new Cliente();
       }
        
     }

}

