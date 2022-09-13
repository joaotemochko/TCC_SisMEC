﻿using SisMEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories.Interfaces
{
   public interface ICarroRepository
    {
        IEnumerable<Carro> Carros { get; }
        Carro GetCarroById(int carroId);
    }
}
