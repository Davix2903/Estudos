﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Final
{
    public class Cliente : Usuarios
    {
        public Endereco Endereco
        {
            get => default(Endereco);
            set
            {
            }
        }
    }
}