using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
  public class LeilaoDao
  {
    AppDbContext _context;

    public LeilaoDao()
    {
      _context = new AppDbContext();
    }

    public IEnumerable<Categoria> BuscarCategoria()
    {
      return _context.Categorias.ToList();
    }

    public IEnumerable<Leilao> BuscarLeiloes()
    {
      return _context.Leiloes
          .Include(l => l.Categoria).ToList();
    }

    public Leilao BuscaPorId(int id)
    {
      return _context.Leiloes.First(x => x.Id == id);
    }

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
  }
}
