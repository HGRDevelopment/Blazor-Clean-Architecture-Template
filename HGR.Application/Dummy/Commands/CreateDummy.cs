using HGR.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Dummy.Commands
{
    public class CreateDummy : IRequest<Dummyentitiy>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
