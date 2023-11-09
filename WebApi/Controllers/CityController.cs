using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UnitOfWork;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace WebApi.Controllers
{
    public class CityController : BaseController
    {
        private readonly UnitOfWork _unitOfWork;

        public CityController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<City>>> Get()
        {
            var cities = await _unitOfWork.Cities.GetAllAsync();
            return List<cities>;
        }
    }
}