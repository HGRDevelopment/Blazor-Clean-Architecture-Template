using HGR.Application.Abstractions;
using HGR.Application.Dummy.Queries;
using HGR.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Dummy.QueryHandlers
{

    public class GetDummyByIdHandler(IDummyRepository dummyRepository) : IRequestHandler<GetDummyById, Dummyentitiy>
    {
        public async Task<Dummyentitiy> Handle(GetDummyById request, CancellationToken cancellationToken)
        {
            return await dummyRepository.GetDummyById(request.Id);
        }
    }
}
