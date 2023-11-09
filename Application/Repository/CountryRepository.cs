using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interface;
using Persistence.Data;

namespace Application.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountry
    {
        private readonly ProyectoClaseContext _context;

        public CountryRepository(ProyectoClaseContext context) : base(context)
        {
            _context = context;
        }
    }
}