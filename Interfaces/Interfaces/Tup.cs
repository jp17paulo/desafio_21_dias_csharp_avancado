﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Tup : IVeiculo
    {
        //Novo carro
        public Tup()
        {
            this.Marca = "Tup";
        }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }

        private string logo = "imagem.jpg";
        // virtual -> Dizendo que a classe deve ser sobrescrita
        public virtual void Salvar()
        {
            Console.WriteLine($"Ação para salvar os dados com o logo {logo} na marca {this.Marca}");
            //throw new NotImplementedException();
        }

        public void Excluir()
        {
            Console.WriteLine("Ação para excluir dados");
        }
    }
}
