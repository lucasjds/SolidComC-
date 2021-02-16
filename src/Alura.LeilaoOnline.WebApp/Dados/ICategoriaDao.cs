﻿using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
  public interface ICategoriaDao
  {
    IEnumerable<Categoria> ConsultaCategorias();
    Categoria ConsultaCategoriaPorId(int id);
  }
}
