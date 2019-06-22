using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartamentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            //retornar a lista já ordenada por Nome
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
