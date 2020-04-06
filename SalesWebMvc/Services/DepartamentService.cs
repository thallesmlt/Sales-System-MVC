using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
namespace SalesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly Data.SalesWebMvcContext _context;
        public DepartamentService(Data.SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
