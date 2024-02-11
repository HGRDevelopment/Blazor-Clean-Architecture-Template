using HGR.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Dummy.Commands
{
    public record CreateDummyCommand(string Name, string Email) : IRequest<Dummyentitiy>;

}
