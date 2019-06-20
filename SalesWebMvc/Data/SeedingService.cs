using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Eletronic");

            Seller s1 = new Seller(1, "Leonardo", "leo.simoes@hotmail.com", new DateTime(1996, 12, 3), 3000.0, d1);
            Seller s2 = new Seller(1, "Alisson", "alissonrodrigues@hotmail.com", new DateTime(1996, 12, 3), 3000.0, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2019, 6, 20), 2000.0, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(1, new DateTime(2019, 6, 20), 3000.0, SalesStatus.Billed, s2);

            _context.Department.AddRange(d1, d2);
            _context.Seller.AddRange(s1, s2);
            _context.SalesRecord.AddRange(sr1, sr2);

            _context.SaveChanges();
        }
    }
}
