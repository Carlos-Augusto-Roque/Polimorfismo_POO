using System;

namespace Polimorfismo_POO.classes
{
    public class Professor : Taxa
    {
        public string turma;

        public override void ValeRefeicao(){
            Console.WriteLine($"A taxa do professor é 10%");
        }
    }
}

//override = sobrescreve o método ValeRefeicao da classe taxa alterando a mensagem