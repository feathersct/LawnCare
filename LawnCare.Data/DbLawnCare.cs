using System;
using System.Collections.Generic;
using System.Text;

namespace LawnCare.Data
{
    public class DbLawnCare : ILawnCareRepository
    {
        private ApplicationDbContext _db;

        public DbLawnCare(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
