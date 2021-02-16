﻿using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
  public class LeilaoDaoComEfCore : ILeilaoDao
  {
    AppDbContext _context;

    public LeilaoDaoComEfCore()
    {
      _context = new AppDbContext();
    }

    public IEnumerable<Leilao> BuscarTodosLeiloes() => _context.Leiloes.Include(l => l.Categoria);

    public IEnumerable<Categoria> BuscarTodasCategorias() => _context.Categorias;


    public void Incluir(Leilao leilao)
    {
      _context.Leiloes.Add(leilao);
      _context.SaveChanges();
    }

    public void Alterar(Leilao leilao)
    {
      _context.Leiloes.Update(leilao);
      _context.SaveChanges();
    }

    public void Excluir(Leilao leilao)
    {
      _context.Leiloes.Remove(leilao);
      _context.SaveChanges();
    }

    public Leilao BuscarLeilaoPorId(int id)
    {
      return _context.Leiloes.Find(id);
    }
  }
}
