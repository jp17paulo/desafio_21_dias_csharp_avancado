using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Tornese : Tup
    {
        public Tornese()
        {
            this.Marca = "Tornese";
        }
        public override void Salvar()
        {
            base.Salvar();
            Console.WriteLine($"Um novo comportamento para esta ação na marca {this.Marca}");
        }

        public new void Excluir()
        {
            Console.WriteLine("Ação2 para excluir dados");
        }
    }
}
