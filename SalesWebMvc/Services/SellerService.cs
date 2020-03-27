﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly Data.SalesWebMvcContext _context;
        public SellerService(Data.SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert (Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

