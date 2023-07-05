                                                                    using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Application.Interfaces.IRepository;
using MovieApp.Application.Interfaces.IUnitOfWork;
using MovieApp.Persistence.Context;
using MovieApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Persistence
{
    public static class ServiceRegistration
    { 
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MovieAppContext>(
               options => options.UseSqlServer("name=ConnectionStrings:SqlConnection"));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork,UnitOfWork>();
        }
    }
}
