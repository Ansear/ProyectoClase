using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interface;
using Persistence.Data;

namespace Application.Repository
{
    public class StateRepository : GenericRepository<State>, IState
    {
        private readonly ProyectoClaseContext _context;

        public StateRepository(ProyectoClaseContext context) : base(context)
        {
            _context = context;
        }
    }
}