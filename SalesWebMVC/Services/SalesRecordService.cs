using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMVCContext _context;

        public SalesRecordService(SalesWebMVCContext context)
        {
            _context = context;
        }

        // buscando registro de vendas por data
        public async Task<List<RegistrosDeVendas>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroDeVendas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)                         //fazendo um join com a tabela vendedor e Departament e ordenando por Data
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }


        // buscando por grupo o registro de vendas por data
        public async Task<List<IGrouping<Departamento, RegistrosDeVendas>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroDeVendas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)                         //fazendo um join com a tabela vendedor e Departament e ordenando por Data
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }
    }
}
