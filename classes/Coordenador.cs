using System;

namespace Polimorfismo_POO.classes
{
    public class Coordenador : Taxa
    {
        public string tipo;

        public override void ValeRefeicao()
        {
            Console.WriteLine($"A taxa do coordenador é de 30%");
        }
    }
}
//override = sobrescreve o método ValeRefeicao da classe taxa alterando a mensagem