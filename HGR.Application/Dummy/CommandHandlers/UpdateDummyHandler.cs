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
    public class UpdateDummyHandler(IDummyRepository dummyRepository) : IRequestHandler<UpdateDummyCommand, Dummyentitiy>
    {
        public async Task<Dummyentitiy> Handle(UpdateDummyCommand request, CancellationToken cancellationToken)
        {
            return await dummyRepository.UpdateDummy(request.ID, request.Name, request.Email);

        }
    }
}
