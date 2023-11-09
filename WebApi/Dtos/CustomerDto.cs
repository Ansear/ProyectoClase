using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Idcustomer { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public int IdcityFk { get; set; }
        public DateOnly DateRegister { get; set; }
    }
}