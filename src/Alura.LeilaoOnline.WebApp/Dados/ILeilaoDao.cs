﻿using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
  public interface ILeilaoDao
  {
    IEnumerable<Categoria> BuscarCategoria();

    IEnumerable<Leilao> BuscarLeiloes();

    Leilao BuscaPorId(int id);

    void Incluir(Leilao leilao);

    void Alterar(Leilao leilao);

    void Excluir(Leilao leilao);
  }
}
