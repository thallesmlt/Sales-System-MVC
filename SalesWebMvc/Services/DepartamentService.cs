using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
namespace SalesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly Data.SalesWebMvcContext _context;
        public DepartamentService(Data.SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }

    }
}
