using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class CityDto
    {
        public string Name { get; set; }
        public int IdstateFk { get; set; }
    }
}