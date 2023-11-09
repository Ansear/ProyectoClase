using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Interface;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ProyectoClaseContext _context;
        private ICity _cities;
        private ICountry _countries;
        private IState _states;
        private IPersonType _persontypes;
        private ICustomer _customers;

        public UnitOfWork(ProyectoClaseContext context)
        {
            _context = context;
        }

        public ICountry Countries
        {
            get
            {
                _countries ??= new CountryRepository(_context);
                return _countries;
            }
        }
        public ICity Cities
        {
            get
            {
                _cities ??= new CityRepository(_context);
                return _cities;
            }
        }
        public IState States
        {
            get
            {
                _states ??= new StateRepository(_context);
                return _states;
            }
        }
        public IPersonType PersonTypes
        {
            get
            {
                _persontypes ??= new PersonTypeRepository(_context);
                return _persontypes;
            }
        }
        public ICustomer Customers
        {
            get
            {
                _customers ??= new CustomerRepository(_context);
                return _customers;
            }
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}