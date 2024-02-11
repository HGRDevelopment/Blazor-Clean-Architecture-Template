using HGR.Application.Abstractions;
using HGR.Application.Dummy.Commands;
using HGR.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Dummy.CommandHandlers
{
    public class CreateDummyHandler(IDummyRepository dummyRepository) : IRequestHandler<CreateDummyCommand, Dummyentitiy>
    {
        public async Task<Dummyentitiy> Handle(CreateDummyCommand request, CancellationToken cancellationToken)
        {
            var dummy = new Dummyentitiy()
            {
                Name = "Clean Architecture Demo",
                Email = "HGR@CleanArchitecture.com"
            };
            return await dummyRepository.AddDummy(dummy);
        }
    }
}
