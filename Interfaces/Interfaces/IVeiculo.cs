﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IVeiculo
    {
        string Marca { get; set; }
        string Nome { get; set; }
        int Ano { get; set; }

        void Salvar();
    }
}
