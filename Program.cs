using System;
using Polimorfismo_POO.classes;

namespace Polimorfismo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Professor professor = new Professor();
            professor.ValeRefeicao();

            Coordenador coordenador = new Coordenador();
            coordenador.ValeRefeicao();

        }
    }
}
