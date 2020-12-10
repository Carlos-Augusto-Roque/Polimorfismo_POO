using System;

namespace Polimorfismo_POO.classes
{
    public abstract class Taxa
    {
        private float valor;
        

        public virtual void ValeRefeicao(){
            Console.WriteLine("A taxa base a ser paga é de 5%");
        }

    }
}

//virtual = autoriza o método ser sobrescrito em outra classe, nesse caso em professor e coordenador