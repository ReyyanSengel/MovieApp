using MovieApp.Application.Interfaces.IUnitOfWork;
using MovieApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieAppContext _context;

        public UnitOfWork(MovieAppContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
